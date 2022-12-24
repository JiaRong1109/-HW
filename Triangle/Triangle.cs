using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    //原版
    public class Triangle
    {
        public static void Triangle_pic()
        {
            string result = "";
            string left = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    result += "*";
                    left = result.PadLeft(5, ' ');
                }
                Console.Write(left);
                Console.WriteLine();
                result = "";
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int count = 4;
            for (int j = 1; j <= 5; j++)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;
                for (int i = 1; i <= 2 * j - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
