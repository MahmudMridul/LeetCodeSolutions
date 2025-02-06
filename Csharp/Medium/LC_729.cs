using EventTime = (int start, int end);

namespace Leetcode.Medium
{
    public class LC_729
    {

    }

    public class MyCalendar
    {
        public List<EventTime> events;
        public MyCalendar()
        {
            events = new List<EventTime>(1000);
        }

        public bool Book(int startTime, int endTime)
        {
            if (events.Count == 0)
            {
                events.Add(new EventTime(startTime, endTime));
                return true;
            }
            else if (CanAdd(startTime, endTime))
            {
                events.Add(new EventTime(startTime, endTime));
                return true;
            }
            return false;
        }

        private bool CanAdd(int start, int end)
        {
            for (int i = 0; i < events.Count; ++i)
            {
                EventTime eventTime = events[i];
                bool endOverlap = end > eventTime.start && end <= eventTime.end;
                bool startOverlap = start >= eventTime.start && start < eventTime.end;
                bool fullOverlap = start <= eventTime.start && end >= eventTime.end;

                if (endOverlap || startOverlap || fullOverlap)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
