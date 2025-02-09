from typing import List

def floodFill(image: List[List[int]], sr: int, sc: int, color: int) -> List[List[int]]:
    if image[sr][sc] == color:
        return image
    original = image[sr][sc]
    traverse(image, sr, sc, color, original)
    return image


def traverse(image, sr, sc, color, original):
    if sr < 0 or sr >= len(image) or sc < 0 or sc >= len(image[sr]):
        return
    if image[sr][sc] != original:
        return
    image[sr][sc] = color
    traverse(image, sr - 1, sc, color, original)
    traverse(image, sr + 1, sc, color, original)
    traverse(image, sr, sc - 1, color, original)
    traverse(image, sr, sc + 1, color, original)

image = [[1,1,1],[1,1,0],[1,0,1]]
m_image = floodFill(image, 1, 1, 2)
print(m_image)
