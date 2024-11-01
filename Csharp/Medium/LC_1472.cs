namespace Csharp.Medium
{
    public class DesignBrowserHistory_1472
    {

    }

    public class BrowserHistory
    {
        public List<string> history;
        public int current = 0;

        public BrowserHistory(string homepage)
        {
            history = new List<string>();
            history.Add(homepage);
            current = 0;
        }

        public void Visit(string url)
        {
            if (current == history.Count - 1)
            {
                history.Add(url);
                ++current;
                return;
            }
            int itemToDelete = history.Count - 1 - current;
            history.RemoveRange(current + 1, itemToDelete);
            history.Add(url);
            ++current;
        }

        public string Back(int steps)
        {
            current = current - steps < 0 ? 0 : current - steps;
            return history[current];
        }

        public string Forward(int steps)
        {
            current = current + steps >= history.Count - 1 ? history.Count - 1 : current + steps;
            return history[current];
        }
    }
}
