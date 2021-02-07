library(ggplot2)
library(gridExtra)
library(dplyr)
library(psych)

#1.1

nemas <- c("type", "name", "X2014", "X2015", "X2016", "X2017", "products")

products <- read.csv("Цены на продовольственные товары.csv", sep = ";", dec = ",", encoding = "UTF-8")
products$products <- "product"
names(products) <- nemas; products

nonproducts <- read.csv("Цены на непродовольственные товары.csv", sep = ";", dec = ",", encoding = "UTF-8")
nonproducts$products <- "nonproduct"
names(nonproducts) <- nemas; nonproducts

df <- rbind(products, nonproducts)
df$products <- factor(df$products)
str(df)

#1.2

ggplot(df, aes(products, X2017)) +
  geom_boxplot()

summary(aov(X2017 ~ products, data = df))
# p-value > 0.05 => зависимостей нет

#1.3

ggplot(df, aes(X2017, type)) +
  geom_boxplot()

summary(aov(X2017 ~ type, data = df))
# p-value < 0.05 => зависимости есть

#1.4

pd <- position_dodge(0.1)
ggplot(df, aes(X2017, type, color = products, group = products)) +
  stat_summary(fun.data = mean_cl_boot, geom = 'point', size = 5, position = pd, pch = 15) +
  theme_bw()
summary(aov(X2017 ~ type * products *, data = df))
# p-value < 0.05 => зависимости есть
df
#2.1

ChickWeight
summary(aov(weight ~ (Time * Diet) + Error(Chick / Time*Diet) + (Diet), data = ChickWeight))

#3.1

titanic <- read.csv("titanic.csv")

ggplot(titanic, aes(
  x = factor(Survived, labels = c("Умер", "Выжил")),
  y = Age,
  fill = factor(Survived, labels = c("Умер", "Выжил")))
) +
  geom_boxplot() +
  guides(fill = guide_legend(title = NULL)) +
  xlab(NULL)
