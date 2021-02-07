# Kirilkin Vladimir PI18-2
library(ggplot2)

#Используя набор данных Цены на продовольственные товары и Цены на непродовольственные товары:
#1.1. Преобразовать два набора данных в один data.frame с добавлением нового фактора – Тип
#товара (продовольственные, непродовольственные).
nms <- c("cat", "name", "X2014", "X2015", "X2016", "X2017", "prod")
prod <- read.csv("Цены на продовольственные товары.csv", sep = ";", dec = ",")
prod$prod <- "prod"
names(prod) <- nms
nonprod <- read.csv("Цены на непродовольственные товары.csv", sep = ";", dec = ",")
nonprod$prod <- "nonprod"
names(nonprod) <- nms
df <- rbind(prod, nonprod)
df$prod <- factor(df$prod)

#1.2. Провести анализ (диаграмма+расчет) с выводом: зависимость цены товара от типа товара
#для 2017 года.
ggplot(df, aes(prod, X2017)) +
  geom_boxplot()

summary(aov(X2017 ~ prod, data = df))
# p-value > 0.05 => зависимостей нет

#1.3. Провести анализ (диаграмма+расчет) с выводом: зависимость цены товара от категории
#товара для 2017 года
ggplot(df, aes(X2017, cat)) +
  geom_boxplot()

summary(aov(X2017 ~ cat, data = df))
# p-value < 0.05 => зависимости обнаружены

#1.4. Провести анализ (диаграмма+расчет) с выводом: зависимость цены товара от типа и
#категории товара для 2017 года.
pd <- position_dodge(0.1)
ggplot(df, aes(X2017, cat, color = prod, group = prod)) +
  stat_summary(fun.data = mean_cl_boot, geom = 'errorbar', width = 0.2, lwd = 0.8, position = pd) +
  stat_summary(fun.data = mean_cl_boot, geom = 'line', size = 1.5, position = pd) +
  stat_summary(fun.data = mean_cl_boot, geom = 'point', size = 5, position = pd, pch = 15) +
  theme_bw()
summary(aov(X2017 ~ cat * prod, data = df))
# p-value < 0.05 => зависимости обнаружены

#Используя встроенный набор данных ChickWeight
#2.1. Сделайте вывод об эффективности диеты
head(ChickWeight)

summary(aov(weight ~ (Time * Diet) + Error(Chick / Time) + (Diet), data = ChickWeight))

#3. Используя набор данных Titanic
#3.1. Проведите максимально полный анализ данных между зависимой переменной и
#независимыми, а также возможном взаимодействии независимых параметров
titanic <- read.csv("titanic.csv")

library(ggplot2)
library(gridExtra)
library(dplyr)
ggplot(titanic, aes(
  x = factor(Survived, labels = c("Погиб", "Выжил")),
  y = Age,
  fill = factor(Survived, labels = c("Погиб", "Выжил")))
) +
  geom_boxplot() +
  guides(fill = guide_legend(title = NULL)) +
  xlab(NULL)

tbl <- data.frame(table(titanic$Pclass, titanic$Sex, titanic$Survived))

# Не выжили
ggplot(tbl[tbl$Var3 == 0,], aes(Var1, Var2, fill = Freq)) +
  geom_tile() +
  xlab("Класс") +
  ylab("Пол")

# Выжили
ggplot(tbl[tbl$Var3 == 1,], aes(Var1, Var2, fill = Freq)) +
  geom_tile() +
  xlab("Класс") +
  ylab("Пол")
