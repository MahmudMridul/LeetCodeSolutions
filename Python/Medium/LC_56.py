from typing import List
def merge(intervals: List[List[int]]) -> List[List[int]]:
    if len(intervals) == 1:
        return intervals

    intervals.sort(key=lambda x : x[0])
    merged = []

    for interval in intervals:
        if not merged or not overlaps(merged[-1][0], merged[-1][1], interval[0]):
            merged.append(interval)
        else:
            merged[-1][1] = max(merged[-1][1], interval[1])
    return merged

def overlaps(f_start, f_end, s_start):
    return f_start <= s_start <= f_end

intervals = [[1,3], [8,10], [15,18], [2,6]]
intervals_2 = [[1,4],[4,5]]
merged = merge(intervals_2)
print(merged)