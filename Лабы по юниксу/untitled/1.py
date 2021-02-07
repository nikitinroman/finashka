from random import randint


def pretty_look(mat):
    s = ''
    for i in mat:
        for j in i:
            s += f'{j} '
        s += '\n'
    return s


matrix_size = int(input())
matrix = [[randint(-15, 15) for _ in range(matrix_size)] for __ in range(matrix_size)]
print(f'Начальная матрица:\n{pretty_look(matrix)}')
for i in matrix:
    i[matrix_size - 1] = sum(i[:-1])
print(f'Новая матрица:\n{pretty_look(matrix)}')
