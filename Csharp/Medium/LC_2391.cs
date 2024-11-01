namespace Csharp.Medium
{
    public class MinimumTimeToCollectGarbage_2391
    {
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            int totalTime = 0;
            totalTime += CountTime(garbage, travel, 'P');
            totalTime += CountTime(garbage, travel, 'G');
            totalTime += CountTime(garbage, travel, 'M');
            return totalTime;
        }

        private int CountTime(string[] garbage, int[] travel, char garbageType)
        {
            int time = 0;
            bool garbageFound = false;
            for (int i = garbage.Length - 1; i >= 0; --i)
            {
                string home = garbage[i];
                for (int j = 0; j < home.Length; ++j)
                {
                    if (garbageType == home[j])
                    {
                        ++time;
                        garbageFound = true;
                    }
                }
                if (garbageFound)
                {
                    time += i == 0 ? 0 : travel[i - 1];
                }
            }
            return time;
        }
    }
}
