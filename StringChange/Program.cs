using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringChange.StringChange.Change_Font(null));
            Console.WriteLine(StringChange.StringChange.Change_Font("AppleCat"));
        }
    }
}
