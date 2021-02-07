#INSERT INTO seans VALUES (40, 4, 9, 300, TO_DATE('12-Mar-2020 4:30', 'dd-mon-yyyy hh24:mi'));
import random


lst2 = [[12, 17], [10, 10], [20, 10], [15, 15], [12, 20], [10, 3], [12, 10], [12, 20], [12, 20], [10, 10], [8, 12]]
c = 0
# for j in range(1,12):
#     time = 8
#     film = random.randint(1, 18)
#     price = (random.randint(200, 500) // 10) * 10
#     for k in range(8):
#         c += 1
#         print(f"INSERT INTO seans VALUES ({c}, {film}, {j}, {price}, TO_DATE('04-May-2020 {time}:30', 'dd-mon-yyyy hh24:mi'));")
#         time += 2

id = 1
lst2 = [[12, 17], [10, 10], [20, 10], [15, 15], [12, 20], [10, 3], [12, 10], [12, 20], [12, 20], [10, 10], [8, 12]]
seans_id = 0


# def kek(rand4, rand5):
#     if (((lst2[j][0] - rand5) * lst2[j][0] - rand4) < (rand2 - rand1)):
#         rand5 -= 1
#         kek(rand4, rand5)
#     return rand4, rand5


for j in range(11):
    for k in range(8):
        seans_id += 1
        mesto = 1
        ryad = 1
        rand1 = random.randint(1, lst2[j][0] * lst2[j][1])
        rand2 = random.randint(1, lst2[j][0] * lst2[j][1])
        rand4 = random.randint(1, lst2[j][0])
        rand5 = random.randint(1, lst2[j][1])
        if rand1 > rand2:
            rand3 = rand2
            rand2 = rand1
            rand1 = rand3
        mesto = rand4
        ryad = rand5
        for i in range(rand1, rand2 + 1):
            if mesto > lst2[j][0]:
                mesto = 1
                ryad += 1
            if mesto <= lst2[j][0]:
                print(f"INSERT INTO tickets VALUES ({id}, {seans_id}, {ryad}, {mesto});")
                mesto += 1
                id += 1