__author__ = 'valenc3x'

def string_compress(word=None):
    compressed = str()
    current = str()
    for i, letter in enumerate(word):
        if current != letter:
            count = 0
            current = letter
        count += 1
        if i < len(word)-1 and letter != word[i+1] or i == len(word) -1:
            compressed = '%s%s%d' % (compressed, letter, count)

    return compressed if len(compressed) < len(word) else word


if __name__ == '__main__':
    print(string_compress('aaabcccdeee'))
    print(string_compress('ab'))
    print(string_compress('abcdeeeeeee'))
    print(string_compress('aaabbbc'))
