using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandlestickChart
{
    class PriceInfoEntityObject
    {
        public String 일자 { get; set; }
        public int 시가 { get; set; }
        public int 고가 { get; set; }
        public int 저가 { get; set; }
        public int 종가 { get; set; }
        public int 거래량 { get; set; }
    }


}
