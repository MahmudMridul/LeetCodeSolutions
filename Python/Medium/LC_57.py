from typing import List
def insert(intervals: List[List[int]], newInterval: List[int]) -> List[List[int]]:
    intervals.append(newInterval)
    if len(intervals) < 2:
        return intervals
    intervals.sort(key=lambda x : x[0])
    merged = []

    for interval in intervals:
        if not merged or merged[-1][1] < interval[0]:
            merged.append(interval)
        else:
            merged[-1][1] = max(merged[-1][1], interval[1])
    return merged

intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]]
new_interval = [4,8]
result = insert(intervals, new_interval)
print(result)
