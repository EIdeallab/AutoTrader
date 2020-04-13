using System;
using System.Net;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace AutoTrader.Presenter
{
    static class NaverApi
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        
        public static void RequestNews(string stockName, string startDate, string endDate, out List<NewsInfo> newsInfoList)
        {
            newsInfoList = new List<NewsInfo>();

            // ini 읽기
            StringBuilder id = new StringBuilder(32);
            StringBuilder pw = new StringBuilder(32);
            string path = Path.GetFullPath(@"../../../../NaverApiInfo.ini");
            GetPrivateProfileString("LOGIN", "ID", "", id, id.Capacity, path);
            GetPrivateProfileString("LOGIN", "PW", "", pw, pw.Capacity, path);

            // 최대 10회 요청 (100건씩 총 1000건)
            for (int i = 0; i<10; i++)
            {
                string start = "&start=" + (i * 10 + 1);
                string query = stockName + start + "&display=100&sort=sim"; // 검색할 문자열
                string url = "https://openapi.naver.com/v1/search/news.xml?query=" + query;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                request.Headers.Add("X-Naver-Client-Id", id.ToString()); // 클라이언트 아이디
                request.Headers.Add("X-Naver-Client-Secret", pw.ToString());// 클라이언트 시크릿
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string status = response.StatusCode.ToString();

                List<NewsInfo> newsInfos = new List<NewsInfo>();
                if (status == "OK")
                {
                    newsInfos = ParseXml(response);
                }
                else
                {
                    Console.WriteLine("Error 발생=" + status);
                }

                newsInfoList.AddRange(newsInfos);
                Thread.Sleep(100);
            }

            FilterList(startDate, endDate, ref newsInfoList);

        }

        private static void FilterList(string startDate, string endDate, ref List<NewsInfo> newsInfoList)
        {
            List<NewsInfo> dateBetweenNews = new List<NewsInfo>();
            foreach (NewsInfo newsInfo in newsInfoList)
            {
                DateTime stDate = DateTime.ParseExact(startDate, "yyyy-MM-dd", null);
                DateTime edDate = DateTime.ParseExact(endDate, "yyyy-MM-dd", null);
                DateTime newsDate = DateTime.ParseExact(newsInfo.Date, "ddd, dd MMM yyyy", CultureInfo.InvariantCulture);

                if(stDate <= newsDate && newsDate <= edDate)
                {
                    dateBetweenNews.Add(newsInfo);
                }
            }
            newsInfoList = dateBetweenNews;
        }

        private static List<NewsInfo> ParseXml(HttpWebResponse response)
        {
            List<NewsInfo> newsInfoList = new List<NewsInfo>();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Async = true;

            Stream stream = response.GetResponseStream();
            
            using (XmlReader reader = XmlReader.Create(stream, settings))
            {
                XmlDocument doc = new XmlDocument();
                doc.PreserveWhitespace = true;
                try
                {
                    doc.Load(reader);
                    XmlNodeList nodes = doc.SelectNodes("rss/channel/item");

                    foreach (XmlNode item in nodes)
                    {
                        NewsInfo entity = new NewsInfo
                        {
                            Title = item.SelectSingleNode("title").InnerText,
                            Link = item.SelectSingleNode("link").InnerText,
                            Desc = item.SelectSingleNode("description").InnerText,
                            Date = item.SelectSingleNode("pubDate").InnerText.Substring(0, 16)
                        };
                        newsInfoList.Add(entity);

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return newsInfoList;
        }
    }
}
