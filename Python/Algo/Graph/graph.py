from collections import deque
from pydoc import visiblename


def bfs(graph, source):
    visited = set()
    result = []
    queue = deque([source])
    visited.add(source)

    while queue:
        v = queue.popleft()
        result.append(v)

        for edge in graph[v]:
            neighbour = edge.neighbour
            if neighbour not in visited:
                visited.add(neighbour)
                queue.append(neighbour)
    return result

def dfs(graph, source):
    visited = set()
    result = []
    traverse(graph, source, visited, result)
    return result

def traverse(graph, v, visited, result):
    visited.add(v)
    result.append(v)

    for edge in graph[v]:
        neighbour = edge.neighbour
        if neighbour not in visited:
            traverse(graph, neighbour, visited, result)