

namespace LeetCodeSolutionsTests.Medium
{
    [TestFixture]
    internal class IntegerToRoman_12_Tests
    {
        [TestCase(3, "III")]
        [TestCase(58, "LVIII")]
        [TestCase(1994, "MCMXCIV")]
        [TestCase(3999, "MMMCMXCIX")]
        public void IntToRoman_Tests(int input, string expected)
        {
            var obj = new IntegerToRoman_12();
            string result = obj.IntToRoman(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
