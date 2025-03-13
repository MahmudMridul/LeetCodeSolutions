from typing import List


class NumMatrix:
    def __init__(self, matrix: List[List[int]]):
        rows, cols = len(matrix), len(matrix[0])
        self.pre = [[0] * (cols + 1) for r in range(rows + 1)]

        for r in range(rows):
            prefix = 0
            for c in range(cols):
                prefix += matrix[r][c]
                above = self.pre[r][c + 1]
                self.pre[r + 1][c + 1] = prefix + above
        self.print()

    def print(self):
        rows, cols = len(self.pre), len(self.pre[0])
        for row in range(rows):
            r = []
            for col in range(cols):
                r.append(self.pre[row][col])
            print(r)

    def sumRegion(self, row1: int, col1: int, row2: int, col2: int) -> int:
        row1, col1, row2, col2 = row1 + 1, col1 + 1, row2 + 1, col2 + 1
        lower_right = self.pre[row2][col2]
        above = self.pre[row1 - 1][col2]
        left = self.pre[row2][col1 - 1]
        top_left = self.pre[row1 - 1][col1 - 1]
        print(lower_right - above - left + top_left)
        return lower_right - above - left + top_left


matrix = [[3, 0, 1, 4, 2],
          [5, 6, 3, 2, 1],
          [1, 2, 0, 1, 5],
          [4, 1, 0, 1, 7],
          [1, 0, 3, 0, 5]]

obj = NumMatrix(matrix)
obj.sumRegion(0, 0, 0, 0)
