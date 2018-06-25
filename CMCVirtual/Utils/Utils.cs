using CMCVirtual.Extensions;

namespace CMCVirtual.Utils
{
    internal static class Utils
    {
        public static string Decrypt(string cValue)
        {
            var Result = string.Empty;
            var cTmp   = string.Empty;

            for (int i = 0; i < cValue.Length/4; i++)
            {
                var cSub = cValue.Substring((i - 1) * 4 + 1, 2);
                var iTmp = cSub.ToInteger();
                cTmp    += ((iTmp % 2) == 0) ? cSub : "00";
            }

            var iLen = cTmp.Substring(1, 3).ToInteger();
            cTmp     = cTmp.Substring(4, iLen);
            
            for (int i = 0; i < iLen/3; i++)
            {
                var iTmp = cTmp.Substring((i - 1) * 3 + 1, 3);
                Result  += iTmp.ToChar();
            }
            return Result;
        }

        public static string PadL(string cText, int iLen, string cSubStr = " ")
        {
            return string.Empty;
        }

        public static string PadR(string cText, int iLen, string cSubStr = " ")
        {
            return string.Empty;
        }
    }
}