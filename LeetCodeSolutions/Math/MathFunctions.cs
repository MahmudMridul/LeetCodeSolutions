
namespace LeetCodeSolutions.Math
{
    public static class MathFunctions
    {
        public static int Gcd(int a , int b)
        {
            if (a == b) return 0;
            return Gcd(b % a, a);
        }
    }

}
