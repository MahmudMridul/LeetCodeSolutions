class MedianFinder:

    def __init__(self):
        self.stream = []

    def addNum(self, num: int) -> None:
        self.stream.append(num)
        size = len(self.stream)

        if size == 1:
            return

        right = size - 1
        left = size - 2

        while left >= 0:
            swapped = False
            if self.stream[left] > self.stream[right]:
                temp = self.stream[left]
                self.stream[left] = self.stream[right]
                self.stream[right] = temp
                swapped = True

            if not swapped:
                break

            left -= 1
            right -= 1

    def findMedian(self) -> float:
        size = len(self.stream)
        if size % 2 == 1:
            return self.stream[size//2]*1.0
        else:
            right = size//2
            left = right - 1
            return (self.stream[right] + self.stream[left]) / 2



if __name__ == '__main__':
    finder = MedianFinder()
    finder.addNum(3)
    finder.addNum(2)
    finder.addNum(6)
    finder.addNum(1)


    print(finder.findMedian())
    print(finder.stream)

