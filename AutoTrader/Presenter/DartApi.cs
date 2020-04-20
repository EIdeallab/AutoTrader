using System;
using System.Net;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace AutoTrader.Presenter
{
    static class DartApi
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        
        public static void RequestViewer(string rceptNum)
        {
            Process.Start("http://dart.fss.or.kr/dsaf001/main.do?rcpNo=" + rceptNum);
        }

        public static void RequestDisclosure(string stockCode, string startDate, string endDate, out List<DisclosureInfo> disclosureInfos)
        {
            disclosureInfos = new List<DisclosureInfo>();

            // ini 읽기
            StringBuilder id = new StringBuilder(64);
            string path = Path.GetFullPath(@"../../../../ApiInfo.ini");
            GetPrivateProfileString("LOGIN", "ID", "", id, id.Capacity, path);

            bool bNext = true;
            int index = 0;

            while (bNext)
            {
                index++;
                string cert_key = "crtfc_key=" + id.ToString();
                string corp_code = "&corp_code=" + stockCode;
                string begin_date = "&bgn_de=" + startDate.Replace("-", "");
                string end_date = "&end_de=" + endDate.Replace("-", "");
                string page_count = "&page_count=100";
                string page_no = "&page_no=" + index;
                string query = cert_key + corp_code + begin_date + end_date + page_count;
                string url = "https://opendart.fss.or.kr/api/list.xml?" + query;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.UserAgent = "Mozilla / 5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
                request.ContentType = "application/xml";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                
                string status = response.StatusCode.ToString();

                if (status == "OK")
                {
                    Stream stream = response.GetResponseStream();
                    bNext = ParseXml(stream, ref disclosureInfos);
                }
                else
                {
                    Console.WriteLine("Error 발생=" + status);
                    bNext = false;
                }
            }
        }

        private static bool ParseXml(Stream stream, ref List<DisclosureInfo> disclosureInfos)
        {
            bool bNext = false;
            XmlReaderSettings settings = new XmlReaderSettings();
            using (XmlReader reader = XmlReader.Create(stream, settings))
            {
                XmlDocument doc = new XmlDocument();
                doc.PreserveWhitespace = true;
                try
                {
                    doc.Load(reader);

                    // 다음 페이지 확인
                    XmlNode pageNumNode = doc.SelectSingleNode("/result/page_no");
                    XmlNode totPageNode = doc.SelectSingleNode("/result/total_page");
                    int pageNum = int.Parse(pageNumNode.InnerText);
                    int totPage = int.Parse(totPageNode.InnerText);
                    bNext = pageNum < totPage;

                    // 페이지 내용 저장
                    XmlNodeList nodes = doc.SelectNodes("/result/list");
                    foreach (XmlNode item in nodes)
                    {
                        DisclosureInfo entity = new DisclosureInfo
                        {
                            Title = item.SelectSingleNode("report_nm").InnerText,
                            RCeptNum = item.SelectSingleNode("rcept_no").InnerText,
                            CorpCode = item.SelectSingleNode("corp_code").InnerText,
                            Date = item.SelectSingleNode("rcept_dt").InnerText
                        };
                        disclosureInfos.Add(entity);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return bNext;
        }
    }
}
