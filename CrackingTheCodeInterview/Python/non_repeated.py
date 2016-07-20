# Write a method that for a given string as input, returns the first non repeated letter

def non_repeated(phrase=None):
    assert phrase is not None
    unique = dict()
    for char in phrase:
        if char in unique:
            unique[char] += 1
        else:
            unique[char] = 1
    for char in phrase:
        if unique[char] == 1:
            return char
    return False

if __name__ == '__main__':
    print(non_repeated(''))
    print(non_repeated('abb')) # a
    print(non_repeated('ab'))  # a
    print(non_repeated('aabb')) # b
    print(non_repeated('aabbc'))
    print(non_repeated('bbbbbaca')) # c
    print(non_repeated('murcielagom')) # u

