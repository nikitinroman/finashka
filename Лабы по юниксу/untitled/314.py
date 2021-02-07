from random import randint

a = [randint(1,10) for _ in range(30)]
b = [randint(1,10) for _ in range(30)]
a_u = len(set(a))
b_u = len(set(b))

print(f'Спосок <{a}>, уникальных {a_u}\nСпосок <{b}>, уникальных {b_u}')