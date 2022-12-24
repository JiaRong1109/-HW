using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringChange
{
    public class StringChange
    {/// <summary>
    /// 改變輸入字串
    /// </summary>
    /// <param name="Values">輸入字串</param>
    /// <returns>傳回改變後字串</returns>
        public static string Change_Font(string Values)
        {
            string result = string.Empty;
            if(string.IsNullOrEmpty(Values))
            {
                result += "null";
            }
            else
            {
                char[] chars = Values.ToCharArray();
                string first = chars[0].ToString();
                if (Regex.IsMatch(first, @"^[A-Z]"))
                {
                    result += first.ToLower();
                }
                else
                {
                    result += first;
                }
                for (int i = 1; i < chars.Length; i++)
                {
                    string str = chars[i].ToString();
                    if (Regex.IsMatch(str, @"^[A-Z]"))
                    {
                        result += "_" + str.ToLower();
                    }
                    else
                    {
                        result += str;
                    }
                }
            }
            return result;
        }
    }
}
