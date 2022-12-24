using NUnit.Framework.Constraints;
using StringChange;
namespace StringChange_Tests
{
    public class Tests
    {
        

        [TestCase("bILl","b_i_ll")]
        [TestCase("sTring", "s_tring")]
        [TestCase("cHANg", "c_h_a_ng")]
        public void StringChange_大寫轉換(string upper,string expected)
        {
            string actual = StringChange.StringChange.Change_Font(upper); 
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase("BILl", "b_i_ll")]
        [TestCase("STring", "s_tring")]
        [TestCase("CHAng", "c_h_ang")]
        public void StringChange_開頭大寫轉換(string upper, string expected)
        {
            string actual = StringChange.StringChange.Change_Font(upper);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(null, "null")]
        [TestCase("", "null")]
        
        public void StringChange_null轉換(string upper, string expected)
        {
            string actual = StringChange.StringChange.Change_Font(upper);
            Assert.AreEqual(expected, actual);
        }
    }
}