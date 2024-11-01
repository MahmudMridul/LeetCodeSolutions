namespace Csharp.Medium
{
    public class BuildArrayWithStack_1441
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            IList<string> operations = new List<string>();
            int num = 1, index = 0;

            while (num <= n)
            {
                if (num == target[index])
                {
                    operations.Add("Push");
                    ++index;
                }
                else
                {
                    operations.Add("Push");
                    operations.Add("Pop");
                }
                ++num;

                if (index == target.Length) break;
            }
            return operations;
        }
    }
}
