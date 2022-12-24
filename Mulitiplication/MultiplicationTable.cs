using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulitiplicationTableUtility
{
    public class MultiplicationTable
    {/// <summary>
    /// 九九乘法表
    /// </summary>
    /// <returns></returns>
        public static string Multiplication()
        {
            string ans = string.Empty;
            string result = string.Empty;
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    ans = $"{j * i}".PadLeft(2,' ');
                    //string num = ans.PadLeft(2, ' ');
                    result +=$"{i} * {j} =" + ans+"\n";

                }
                result +="\n";
            }
            return result;
        }
    }
}
