using CMCVirtual.Core.TO;
using System;

namespace CMCVirtual.Extensions
{
    internal static class TypeExtensions
    {
        public static short ToShort(this object obj)    
        {
            return Convert.ToInt16(obj);
        }

        public static int ToInteger(this object obj)    
        {
            return Convert.ToInt32(obj);
        }

        public static long ToLong(this object obj)      
        {
            return Convert.ToInt64(obj);
        }

        public static bool ToBoolean(this object obj)   
        {
            return ((string)obj == "1");
        }

        public static char ToChar(this object obj)      
        {
            return Convert.ToChar(obj);
        }

        public static bool CompareLogin(this LoginTO oneTO, LoginTO twoTO)
        {
            return (oneTO.StationName == twoTO.StationName && 
                    oneTO.StationNumber == twoTO.StationNumber &&
                    oneTO.MacAddress == twoTO.MacAddress);
        }
    }
}
