__author__ = 'valenc3x'

from pprint import pprint

def unique_chars(word=None):
    letters = dict()
    for char in word:
        if char in letters:
            return False
        else:
            letters[char] = True
    return True



if __name__ == '__main__':
    print(unique_chars('murcielago'))
    print(unique_chars('palabra'))
    print(unique_chars('abcdefghijklmnopqrstuvwxyz'))
    print(unique_chars('this car'))
    print(unique_chars('  murcielago'))

