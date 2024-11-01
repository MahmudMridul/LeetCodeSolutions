namespace Csharp.Easy
{
    public class TwoStringsAreEquivalent_1662
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string first = string.Join(string.Empty, word1);
            string second = string.Join(string.Empty, word2);
            return first.Equals(second);
        }
    }
}
