using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bill = CalTax_Bill.CalTax_Bill.CalTax(170);
            Console.WriteLine(bill);
        }
    }
}
