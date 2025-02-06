from DataStructure.Trie.Trie import Trie
if __name__ == '__main__':
    trie = Trie()
    trie.insert("fall")
    trie.insert("fallen")
    trie.insert("falling")
    trie.insert("falt")

    print(trie.search("fall"))
    print(trie.search("fal"))
    print(trie.starts_with("fa"))
    print(trie.starts_with("fe"))