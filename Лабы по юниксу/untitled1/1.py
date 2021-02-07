from multiprocessing import Process, Queue, Pool

matrix1 = ((1, 2, 3, 4),
           (5, 6, 7, 8))
matrix2 = ((1, 3),
           (4, 6),
           (7, 9),
           (11, 13))

def multipl(q_main, q_res):
    while q_main.qsize():
        row, line, plase = q_main.get()
        if len(row) - len(line):
            raise ValueError
        else:
            q_res.put([place, row[i] * line[i]] for i in range(len(matrix2)))


if __name__ == '__main__':

    q_main = Queue()
    q_res = Queue()

    for i in range(len(matrix1)):
        for j in range(len(matrix2[0])):
            q_main.put((matrix1[i], [matrix2[x][j] for x in range(len(matrix2))], (i, j)))

    result = [[[] for i in range(len(matrix1))] for j in range(len(matrix1))]

    processes = [Process(target = multipl, args = (q_main, q_res)) for i in range(2)]
    [i.start() for i in processes]
    [i.join() for i in processes]

    for i in range(q_res.qsize()):
            place, prom_res = q_res.get()
            result[place[0]][place[1]] = prom_res

    print(result)
