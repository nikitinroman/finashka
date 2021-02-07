# 1 jun 1901 - 31 dec 2000
year_start, year_stop = 1901,2001
first_year_monday = 1
is_leap = lambda year: True if year % 4 == 0 and year % 100 != 0 else False
days = sum([366 if is_leap(year) else 365 for year in range(year_start, year_stop)])
print(int((days - first_year_monday) / 7))

