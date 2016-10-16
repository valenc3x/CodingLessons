from pprint import pprint

def print_vars(**kwargs):
    pprint(kwargs)

def spiral_matrix(size):
    matrix = [[0 for _ in range(size)] for _ in range(size)]

    # first full row
    num = 1
    for x in range(size):
        matrix[0][x] = num
        num += 1
    corner = size-1
    i = 0
    j = size-1
    while corner > 0:
        for _ in range(corner):
            i += 1
            matrix[i][j] = num
            num += 1
        for _ in range(corner):
            j -= 1
            matrix[i][j] = num
            num += 1
        corner -= 1
        for _ in range(corner):
            i -= 1
            matrix[i][j] = num
            num += 1
        for _ in range(corner):
            j += 1
            matrix[i][j] = num
            num += 1
        corner -= 1
    pprint(matrix, indent=4)


if __name__ == '__main__':
    spiral_matrix(4)
