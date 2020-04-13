using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxKHOpenAPILib;

namespace AutoTrader
{
    public class NewsInfo
    {
        public string Date { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Desc { get; set; }

        public override string ToString()
        {
            return "일자=" + Date + "\n제목=" + Title + "\n링크 =" + Link+ "\n요약=" + Desc;
        }
    }

    public class PriceInfo
    {
        public string Date { get; set; }
        public int Start { get; set; }
        public int Highest { get; set; }
        public int Lowest { get; set; }
        public int End { get; set; }
        public int Volume { get; set; }

        public override string ToString()
        {
            return "일자=" + Date + "시가=" + Start + "고가=" + Highest + "저가=" + Lowest + "종가=" + End + "거래량=" + Volume;
        }
    }

    public class BidAskSpread
    {
        public int Price { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
            return "호가 =" + Price + "잔량 =" + Amount;
        }
    }
}
