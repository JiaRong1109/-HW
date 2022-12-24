using DrawTriangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Triangle.Triangle.Triangle_pic();
            Console.WriteLine(DrawTriangle.DrawTriangle.Draw(5,DrawTriangle.DrawTriangle.Left));
            Console.WriteLine(DrawTriangle.DrawTriangle.Draw(6, DrawTriangle.DrawTriangle.Right));
            Console.WriteLine(DrawTriangle.DrawTriangle.Draw(8, DrawTriangle.DrawTriangle.Center));
        }
    }
}
