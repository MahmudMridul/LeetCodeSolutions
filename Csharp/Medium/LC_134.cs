namespace Csharp.Medium
{
    public class GasStation_134
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int total_diff = 0, tank = 0, start = 0;
            for (int i = 0; i < gas.Length; ++i)
            {
                total_diff += gas[i] - cost[i];
                tank += gas[i] - cost[i];
                if (tank < 0)
                {
                    tank = 0;
                    start = i + 1;
                }
            }
            return total_diff < 0 ? -1 : start;
        }
    }
}
