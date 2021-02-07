library(dplyr)
library(nycflights13)
library(Lahman)
library(babynames)
library(nasaweather)
library(fueleconomy)
library(ggplot2)

#1
df <- flights %>% mutate(flight_id = row_number())

#2
#2.1
Batting %>% count(playerID, yearID, stint) %>% filter(n > 1)

#2.2
babynames %>% count(year, sex, name) %>% filter(n > 1)

#2.3
df <- atmos
atmos %>% count(lat, long, year, month) %>% filter(n > 1)

#2.4
vehicles %>% count(id) %>% filter(n > 1)

#2.5
df <- diamonds
diamonds %>% count(carat, cut, color, clarity, depth, table, price, x, y) %>% filter(n > 1)

#3
df <- flights %>% count(tailnum) %>% filter(n >= 100) %>% inner_join(flights, by = "tailnum")

#4
df <- flights %>% group_by(year, month, day) %>% summarize(delay = mean(dep_delay, na.rm = TRUE)) %>% arrange(year, month, day)
df <- df[2:4] %>% mutate(id = row_number()-1)
df <- df %>% mutate(id = id + 1) %>% inner_join(df, by = "id") %>% mutate(year = 2013, delay = delay.x + delay.y) %>% select(year, month.x, day.x, month.y, day.y, delay) %>% arrange(desc(delay)) %>% head(1)


df <- weather %>% semi_join(df, by = c("year", "month" = "month.x", "day" = "day.x")) %>% 
  rbind(weather %>% semi_join(df, by = c("year", "month" = "month.y", "day" = "day.y"))) %>%
  arrange(year, month, day, hour, origin)