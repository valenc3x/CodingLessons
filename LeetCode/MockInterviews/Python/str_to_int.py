
def atoi(string):
    if len (string) == 0:
        return 0
    string = string.strip()
    has_sign = True if string[0] == '-' or string[0] == '+' else False
    is_negative = True if has_sign and string[0] == '-' else False
    num = 0
    first = 1 if has_sign else 0
    for x in range(first,len(string)):
        if ord(string[x]) >= ord('0') and ord(string[x]) <= ord('9'):
            num *= 10
            num += ord(string[x]) - ord('0')
        else:
            return num if not is_negative else num * -1
    return num if not is_negative else num * -1

if __name__ == '__main__':
    print(atoi("123"))
    print(atoi("   123    "))
    print(atoi("-123"))
    print(atoi("+123"))
    print(atoi("1234as5"))
