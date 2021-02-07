install.packages("nycflights13")
library(nycflights13)
library(dplyr)
flights

#1
#1.1
filter(flights, flights$arr_delay >= 120)

#1.2
filter(flights, flights$dest %in% c('IAH', 'HOU'))

#1.3
filter(flights, flights$carrier %in% c('United', 'American', 'Delta'))
flights$carrier
#тут нет такого столбца

#1.4
filter(flights, flights$month %in% c(6:8))

#1.5
filter(flights, flights$arr_delay >= 120 & flights$dep_delay <= 0)

#1.6
filter(flights, (flights$dep_delay - flights$arr_delay) != 30 & flights$dep_delay >= 60)
#можно сделать >=, но по условию- НЕ НАВЕРСТАЛИ ИМЕННО 30 МИНУТ, про больше или меньше- ни слова.
#1.7
filter(flights, flights$dep_time >= 0 & flights$dep_time <= 600)

#2
filter(flights, between(flights$month, 6, 8))

#3
count(filter(flights, is.na(flights$dep_time)))

#4
#4.1
df = arrange(flights, dep_time)
tail(df)

#4.2
arrange(flights, desc(flights$dep_delay, flights$arr_delay))

#4.3
arrange(flights, desc(flights$hour*60 + flights$minute)

#4.4
arrange(flights, desc(flights$hour*60 + flights$minute))

#5
#5.1
select(flights, arr_time, arr_time, arr_time, arr_time)
#то же самое, что и 1 раз

#5.2
select(flights, one_of("dep_time", "arr_time"))
#нужно для того, чтобы можно было передать столбцы вектором, а не по одному.

#5.3
select(flights, contains(("TIME")))
#Вывел все столбцы, в названии которых есть слово TIME

#6
#6.1
df_1 = mutate(flights, lel = flights$dep_time%/%100 * 60 + flights$dep_time%%100)
df_1
df_12 = mutate(flights, kek = flights$arr_time%/%100 * 60 + flights$arr_time%%100)
df_12

#6.2
filter(flights, flights$dep_delay != 'NA')
max(filter(flights, flights$dep_delay != 'NA'))
df <- filter(flights, dep_delay == max(filter(flights, !is.na(dep_delay))$dep_delay))
df
meme = arrange(flights, desc(flights$dep_delay, flights$arr_delay))
meme[1:10]
#последний- более адекватный и рациональный способ)

#7.2
df <- filter(flights, dep_delay>0) %>% group_by(carrier) %>% summarize(n = n())
df
arrange(df, desc(df$n))
