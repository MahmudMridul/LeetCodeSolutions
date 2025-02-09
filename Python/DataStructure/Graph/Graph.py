class Edge:
    def __init__(self, neighbour, weight = 0):
        self.neighbour = neighbour
        self.weight = weight

class Graph:
    def __init__(self, directed = False):
        self.graph = {}
        self.directed = directed

    def add_vertex(self, v):
        if v not in self.graph:
            self.graph[v] = []

    def add_edge(self, v1, v2, w = 0):
        self.add_vertex(v1)
        self.add_vertex(v2)

        self.graph[v1].append(Edge(v2, w))
        if not self.directed:
            self.graph[v2].append(Edge(v1, w))

    def update_edge_weight(self, v1, v2, new_w):
        if v1 in self.graph and v2 in self.graph:
            for edge in self.graph[v1]:
                if edge.neighbour == v2:
                    edge.weight = new_w
                    break
            if not self.directed:
                for edge in self.graph[v2]:
                    if edge.neighbour == v1:
                        edge.weight = new_w
                        break

    def remove_vertex(self, v):
        if v in self.graph:
            for v in self.graph:
                self.graph[v] = [edge for edge in self.graph[v] if edge.neighbour != v]
            del self.graph[v]

    def remove_edge(self, v1, v2):
        if v1 in self.graph and v2 in self.graph:
            for v1 in self.graph:
                self.graph[v1] = [edge for edge in self.graph[v1] if edge.neighbour != v2]

            if not self.directed:
                self.graph[v2] = [edge for edge in self.graph[v2] if edge.neighbour != v1]

    def get_neighbours(self, v):
        return self.graph.get(v, [])

    def display(self):
        for v in self.graph:
            neighbours = []
            for edge in self.graph[v]:
                neighbours.append(f"({edge.neighbour}, {edge.weight})")
            print(f"{v} --> {" ".join(neighbours)}")