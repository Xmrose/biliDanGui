#!/usr/bin/env python3
# -*- coding: utf-8 -*-

# Biligrab-Danmaku2ASS
#
# Author: Beining@ACICFG https://github.com/cnbeining
# Author: StarBrilliant https://github.com/m13253
#
# Biligrab is licensed under MIT licence
# Permission has been granted for the use of Danmaku2ASS in Biligrab
#
# Copyright (c) 2014
#
# Permission is hereby granted, free of charge, to any person obtaining a copy
# of this software and associated documentation files (the “Software”), to deal
# in the Software without restriction, including without limitation the rights
# to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
# copies of the Software, and to permit persons to whom the Software is
# furnished to do so, subject to the following conditions:
#
# The above copyright notice and this permission notice shall be included in
# all copies or substantial portions of the Software.
#
# THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
# IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
# FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
# AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
# LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
# OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
# SOFTWARE.


import sys
if sys.version_info < (3, 0):
    sys.stderr.write('ERROR: Python 3.0 or newer version is required.\n')
    sys.exit(1)
import argparse
import gzip
import json
import hashlib
import io
import logging
import math
import os
import re
import subprocess
import tempfile
import urllib.parse
import urllib.request
import xml.dom.minidom
import zlib


USER_AGENT_PLAYER = 'Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0.2) Gecko/20100101 Firefox/6.0.2 Fengfan/1.0'
USER_AGENT_API = 'Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0.2) Gecko/20100101 Firefox/6.0.2 Fengfan/1.0'
APPKEY = '85eb6835b0a1034e'  # The same key as in original Biligrab
APPSEC = '2ad42749773c441109bdc0191257a664'  # Do not abuse please, get one yourself if you need
BILIGRAB_HEADER = {'User-Agent': USER_AGENT_API, 'Cache-Control': 'no-cache', 'Pragma': 'no-cache'}


def biligrab(url, *, debug=False, verbose=False, media=None, comment=None, cookie=None, quality=None, source=None, keep_fps=False, mpvflags=[], d2aflags={}, fakeip=None):

    url_get_metadata = 'http://api.bilibili.com/view?'
    url_get_comment = 'http://comment.bilibili.com/%(cid)s.xml'
    if source == 'overseas':
        url_get_media = 'http://interface.bilibili.com/v_cdn_play?'
    else:
        url_get_media = 'http://interface.bilibili.com/playurl?'

    def parse_url(url):
        '''Parse a bilibili.com URL
        Return value: (aid, pid)
        '''
        regex = re.compile('(http:/*[^/]+/video/)?av(\\d+)(/|/index.html|/index_(\\d+).html)?(\\?|#|$)')
        regex_match = regex.match(url)
        if not regex_match:
            raise ValueError('Invalid URL: %s' % url)
        aid = regex_match.group(2)
        pid = regex_match.group(4) or '1'
        return aid, pid

    def fetch_video_metadata(aid, pid):
        '''Fetch video metadata
        Arguments: aid, pid
        Return value: {'cid': cid, 'title': title}
        '''
        req_args = {'type': 'json', 'appkey': APPKEY, 'id': aid, 'page': pid}
        req_args['sign'] = bilibili_hash(req_args)
        _, response = fetch_url(url_get_metadata+urllib.parse.urlencode(req_args), user_agent=USER_AGENT_API, cookie=cookie)
        try:
            response = dict(json.loads(response.decode('utf-8', 'replace')))
        except (TypeError, ValueError):
            raise ValueError('Can not get \'cid\' from %s' % url)
        if 'error' in response:
            logging.error('Error message: %s' % response.get('error'))
        if 'cid' not in response:
            raise ValueError('Can not get \'cid\' from %s' % url)
        return response

    def get_media_urls(cid, *, fuck_you_bishi_mode=False):
        '''Request the URLs of the video
        Arguments: cid
        Return value: [media_urls]
        '''
        if source in {None, 'overseas'}:
            user_agent = USER_AGENT_API if not fuck_you_bishi_mode else USER_AGENT_PLAYER
            req_args = {'appkey': APPKEY, 'cid': cid}
            if quality is not None:
                req_args['quality'] = quality
            req_args['sign'] = bilibili_hash(req_args)
            _, response = fetch_url(url_get_media+urllib.parse.urlencode(req_args), user_agent=user_agent, cookie=cookie, fakeip=fakeip)
            media_urls = [str(k.wholeText).strip() for i in xml.dom.minidom.parseString(response.decode('utf-8', 'replace')).getElementsByTagName('durl') for j in i.getElementsByTagName('url')[:1] for k in j.childNodes if k.nodeType == 4]
            if not fuck_you_bishi_mode and media_urls == ['http://static.hdslb.com/error.mp4']:
                logging.error('Detected User-Agent block. Switching to fuck-you-bishi mode.')
                return get_media_urls(cid, fuck_you_bishi_mode=True)
        elif source == 'html5':
            req_args = {'aid': aid, 'page': pid}
            logging.warning('HTML5 video source is experimental and may not always work.')
            _, response = fetch_url('http://www.bilibili.com/m/html5?'+urllib.parse.urlencode(req_args), user_agent=USER_AGENT_PLAYER)
            response = json.loads(response.decode('utf-8', 'replace'))
            media_urls = [dict.get(response, 'src')]
            if not media_urls[0]:
                media_urls = []
            if not fuck_you_bishi_mode and media_urls == ['http://static.hdslb.com/error.mp4']:
                logging.error('Failed to request HTML5 video source. Retrying.')
                return get_media_urls(cid, fuck_you_bishi_mode=True)
        elif source == 'flvcd':
            req_args = {'kw': url}
            if quality is not None:
                if quality == 3:
                    req_args['quality'] = 'high'
                elif quality >= 4:
                    req_args['quality'] = 'super'
            _, response = fetch_url('http://www.flvcd.com/parse.php?'+urllib.parse.urlencode(req_args), user_agent=USER_AGENT_PLAYER)
            resp_match = re.search('<input type="hidden" name="inf" value="([^"]+)"', response.decode('gbk', 'replace'))
            if resp_match:
                media_urls = resp_match.group(1).rstrip('|').split('|')
            else:
                media_urls = []
        elif source == 'bilipr':
            req_args = {'cid': cid}
            quality_arg = '1080' if quality is not None and quality >= 4 else '720'
            logging.warning('BilibiliPr video source is experimental and may not always work.')
            resp_obj, response = fetch_url('http://pr.lolly.cc/P%s?%s' % (quality_arg, urllib.parse.urlencode(req_args)), user_agent=USER_AGENT_PLAYER)
            if resp_obj.getheader('Content-Type', '').startswith('text/xml'):
                media_urls = [str(k.wholeText).strip() for i in xml.dom.minidom.parseString(response.decode('utf-8', 'replace')).getElementsByTagName('durl') for j in i.getElementsByTagName('url')[:1] for k in j.childNodes if k.nodeType == 4]
            else:
                media_urls = []
        else:
            assert source in {None, 'overseas', 'html5', 'flvcd', 'bilipr'}
        if len(media_urls) == 0 or media_urls == ['http://static.hdslb.com/error.mp4']:
            raise ValueError('Can not get valid media URLs.')
        return media_urls
