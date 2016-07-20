__author__ = 'valenc3x'

from pprint import pprint

def to_zero(matrix=None):
    assert matrix is not None
    rows_to_zero = [False for i in range(len(matrix))]
    cols_to_zero = [False for i in range(len(matrix[0]))]
    for i, row in enumerate(matrix):
        for j, col in enumerate(row):
            if matrix[i][j] == 0:
                rows_to_zero[i] = True
                cols_to_zero[j] = True
    for i, row in enumerate(matrix):
        for j, col in enumerate(row):
            if rows_to_zero[i] or cols_to_zero[j]:
                matrix[i][j] = 0
    pprint(matrix)

if __name__ == '__main__':
    matrix = [
        [1, 1, 1, 1],
        [1, 0, 1, 1],
        [1, 1, 1, 0],
        [1, 1, 1, 1],
    ]

    to_zero(matrix)
