namespace Csharp.Medium
{
    public class FindOriginalArrayOfPrefixXOR_2433
    {
        public int[] FindArray(int[] pref)
        {
            if (pref.Length == 1) return pref;
            int[] result = new int[pref.Length];
            result[0] = pref[0];
            int xor = pref[0];

            for (int i = 1; i < pref.Length; ++i)
            {
                result[i] = xor ^ pref[i];
                xor = xor ^ result[i];
            }
            return result;
        }
    }
}
