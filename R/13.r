library(datasets)
library(ggplot2)
library(nasapower)
library(dplyr)
library(eurostat)
library(tidyr)

#1
ggplot(data = quakes) + geom_point(aes(y = lat, x = long, color = depth, size = mag, alpha = 0.5)) +
  ggtitle("Землетрясения") + labs(x = "Долгота", y = "Широта") +
  scale_size_continuous("Магнитуда") + scale_alpha_continuous("Прозрачность") + scale_color_continuous("Глубина")

#2
daily <- get_power(
  community = "AG",
  lonlat = c(60.59, 56.84),
  pars = c("RH2M", "T2M", "PRECTOT"),
  dates = c("2020-04-01","2020-04-30"),
  temporal_average = "DAILY"
)

ggplot(data = daily) +
  geom_line(aes(x = DD, y = T2M, color = "Температура")) + 
  geom_line(aes(x = DD, y = RH2M, color = "Относительная влажность")) +
  geom_line(aes(x = DD, y = PRECTOT, color = "Осадки")) +
  labs(x = "Дата", y = "Данные") +
  ggtitle("Данные о погоде в Екатеринбурге") +
  scale_colour_discrete("Наблюдения")

mountly <- get_power(
  community = "AG",
  lonlat = c(60.59, 56.84),
  pars = c("RH2M", "T2M", "PRECTOT"),
  dates = c("2019-01-01","2019-12-31"),
  temporal_average = "DAILY"
)

mountly <- mountly %>% select(MM, RH2M, T2M, PRECTOT) %>% group_by(MM) %>% summarise(RH2M = mean(RH2M), T2M = mean(T2M), PRECTOT = mean(PRECTOT))

ggplot(mountly) + geom_col(aes(x = MM, y = T2M), fill = "blue") +
  labs(x = "Месяцы", y = "Температура") + scale_x_continuous(labels = c(1:12), breaks = c(1:12)) + ggtitle("Средние значния температуры")

ggplot(mountly) + geom_col(aes(x = MM, y = RH2M), fill = "gold") +
  labs(x = "Месяцы", y = "Относительная влажность") + scale_x_continuous(labels = c(1:12), breaks = c(1:12)) + ggtitle("Средние значения влажности")

ggplot(mountly) + geom_col(aes(x = MM, y = PRECTOT), fill = "black") +
  labs(x = "Месяцы", y = "Осадки") + scale_x_continuous(labels = c(1:12), breaks = c(1:12)) + ggtitle("Средние значения осадков")

#По хорошему тут можно было бы как-нибудь сделать столбчатую диаграмму, объединяющую в себе сразу все, но я не сумел(

#3
storm_mitch <- storms[storms$name == "Mitch",]

ggplot(storm_mitch) + geom_point(aes(x = pressure, y = wind, color = status))
