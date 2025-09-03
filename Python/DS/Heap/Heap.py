class Heap:
    def __init__(self, is_min_heap = True):
        self.heap = []
        self.is_min_heap = is_min_heap

    def parent(self, index):
        return (index - 1) // 2

    def left_child(self, index):
        return 2 * index + 1

    def right_child(self, index):
        return 2 * index + 2

    def swap(self, i, j):
        self.heap[i], self.heap[j] = self.heap[j], self.heap[i]

    def _should_swap(self, parent_index, child_index):
        if self.is_min_heap:
            return self.heap[child_index] < self.heap[parent_index]
        else:
            return self.heap[child_index] > self.heap[parent_index]

    def size(self):
        return len(self.heap)

    def peek(self):
        if self.size() == 0:
            return None
        return self.heap[0]

    def is_empty(self):
        return self.size() == 0

    def display(self):
        print(self.heap)

    def _bubble_up(self, index):
        while index > 0:
            parent_index = self.parent(index)

            if self._should_swap(parent_index, index):
                self.swap(index, parent_index)
                index = parent_index
            else:
                break

    def _bubble_down(self, index):
        while True:
            left = self.left_child(index)
            right = self.right_child(index)
            target = index

            if self.is_min_heap:
                if left < self.size() and self.heap[left] < self.heap[target]:
                    target = left
                if right < self.size() and self.heap[right] < self.heap[target]:
                    target = right
            else:
                if left < self.size() and self.heap[left] > self.heap[target]:
                    target = left
                if right < self.size() and self.heap[right] > self.heap[target]:
                    target = right

            if target == index:
                break
            self.swap(target, index)
            index = target

    def push(self, value):
        self.heap.append(value)
        self._bubble_up(self.size() - 1)

    def pop(self):
        if self.size() == 0:
            return None
        if self.size() == 1:
            return self.heap.pop()

        value = self.heap[0]
        self.heap[0] = self.heap.pop()
        self._bubble_down(0)
        return value

if __name__ == "__main__":
    min_heap = Heap(False)
    min_heap.push(10)
    min_heap.push(8)
    min_heap.push(13)
    min_heap.push(3)
    min_heap.push(21)

    min_heap.display()
    print(min_heap.pop())
    min_heap.display()
    print(min_heap.peek())