from collections import OrderedDict


def pretty_print(dict):
    s = ''
    for k, v in dict.items():
        s += f'{k}: {v}, '
    return s


year_start, year_end = 1900, 2018
months = OrderedDict({
    'Январь': 31,
    'Февраль': 28,
    'Март': 31,
    'Апрель': 30,
    'Май': 31,
    'Июнь': 30,
    'Июль': 31,
    'Август': 31,
    'Сентябрь': 30,
    'Октябрь': 31,
    'Ноябрь': 30,
    'Декабрь': 31})
months_leap = months.copy()
months_leap.update({'Февраль': 29})
print(months)
is_leap = lambda year: True if year % 4 == 0 and year % 100 != 0 else False
for i in range(year_start, year_end + 1):
    if is_leap(i):
        print(f'{i} :: {pretty_print(months_leap)}')
    else:
        print(f'{i} :: {pretty_print(months)}')
