using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTax_Bill
{ 
    public class CalTax_Bill
    {/// <summary>
    /// 計算含稅金的總金額
    /// </summary>
    /// <param name="price">購買金額</param>
    /// <param name="tax">稅金0.5%</param>
    /// <returns>回傳含稅金的總金額</returns>
        public static int CalTax(int price, double tax = 0.05)
        {
            int tax_cal = (int)Math.Round((double)price * tax, MidpointRounding.AwayFromZero);
            int inclusive = price + tax_cal;
            return inclusive;
        }
    }
}
