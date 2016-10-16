
def is_palindrome(number):
    flip = number
    res = 0
    pal = 0
    while flip > 0:
        res = flip % 10
        flip -= res
        flip /= 10
        pal *= 10
        pal += res
    return pal == number

if __name__ == '__main__':
    print(is_palindrome(123321))
    print(is_palindrome(12321))
    print(is_palindrome(12345))
