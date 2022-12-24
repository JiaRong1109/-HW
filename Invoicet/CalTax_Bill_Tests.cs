
namespace CalTax_Bill_Tests
{
    public class Tests
    {
        [TestCase(100, 105)]
        [TestCase(200, 210)]
        [TestCase(109, 114)]
        public void CalTac_Bill_Tests_Á`ª÷ÃB(int price, int expected)
        {
            int actual = CalTax_Bill.CalTax_Bill.CalTax(price);

            Assert.AreEqual(expected, actual);
        }
    }
}