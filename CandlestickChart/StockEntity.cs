using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrader
{
    class PriceInfoEntityObject
    {
        public String 일자 { get; set; }
        public int 시가 { get; set; }
        public int 고가 { get; set; }
        public int 저가 { get; set; }
        public int 종가 { get; set; }
        public int 거래량 { get; set; }

        public override string ToString()
        {
            return "일자=" + 일자 + "시가 =" + 시가 + "고가 =" + 고가 + "저가 =" + 저가 + "종가 =" + 종가 + "거래량 =" + 거래량;
        }
    }

    class BidAskSpread
    {
        public int 호가 { get; set; }
        public int 잔량 { get; set; }

        public override string ToString()
        {
            return "호가 =" + 호가 + "잔량 =" + 잔량;
        }
    }
}
