using NUnit.Framework.Constraints;
using StringChange;
namespace StringChange_Tests
{
    public class Tests
    {
        

        [TestCase("bILl","b_i_ll")]
        [TestCase("sTring", "s_tring")]
        [TestCase("cHANg", "c_h_a_ng")]
        public void StringChange_�j�g�ഫ(string upper,string expected)
        {
            string actual = StringChange.StringChange.Change_Font(upper); 
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase("BILl", "b_i_ll")]
        [TestCase("STring", "s_tring")]
        [TestCase("CHAng", "c_h_ang")]
        public void StringChange_�}�Y�j�g�ഫ(string upper, string expected)
        {
            string actual = StringChange.StringChange.Change_Font(upper);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(null, "null")]
        [TestCase("", "null")]
        
        public void StringChange_null�ഫ(string upper, string expected)
        {
            string actual = StringChange.StringChange.Change_Font(upper);
            Assert.AreEqual(expected, actual);
        }
    }
}