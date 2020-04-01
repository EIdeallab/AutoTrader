using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using AxKHOpenAPILib;

namespace AutoTrader
{
    public class APIExtention : AxKHOpenAPI
    {
        private string m_trCode;
        private string m_rqName;

        public APIExtention()
        {
            m_trCode = "";
            m_rqName = "";
        }

        public void SetRequestType(string trCode, string rqName)
        {
            m_trCode = trCode;
            m_rqName = rqName;
        }

        public void SetRealType(string trCode)
        {
            m_trCode = trCode;
        }

        public T GetRequestValue<T>(string itemName, int index = 0)
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    // Cast ConvertFromString(string text) : object to (T)
                    string strValue = GetCommData(m_trCode, m_rqName, index, itemName).Trim();
                    if (!String.IsNullOrEmpty(strValue))
                        return (T)converter.ConvertFromString(strValue);
                }
                return default(T);
            }
            catch (NotSupportedException)
            {
                return default(T);
            }
        }

        public T GetRealtimeValue<T>(int index = 0)
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    // Cast ConvertFromString(string text) : object to (T)
                    string strValue = GetCommRealData(m_trCode, index).Trim();

                    return (T)converter.ConvertFromString(strValue);
                }
                return default(T);
            }
            catch (NotSupportedException)
            {
                return default(T);
            }
        }
    }
}
