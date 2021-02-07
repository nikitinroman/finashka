library(stringr)
library(readxl)
library(tidyverse)
library(dplyr)
library(ggplot2)
library(rootSolve)
library(psych)
library(corrgram)


df = mtcars
df
#1
#1.1
cloned_1 = df[c(11:1)]
cloned_1
#1.2
cloned_2 = df[c(1:3)]
cloned_2
#1.3
cloned_3 = sort(df)
cloned_3
#1.4
cloned_4 = filter(df, mpg > 20, carb == 2)
cloned_4

#2
#2.1
func1 <- function(x) 2 * x - x^2;
func2 <- function(x) -x;
(roots <- uniroot.all(func1, c(-10, 10)))
#0 2
abs(as.numeric(integrate(func2, lower = roots[1], upper = roots[2])$value)) -
abs(as.numeric(integrate(func1, lower = roots[1], upper = roots[2])$value))
#0.6666667
#3
#3.1
func3_1 <- function(x)x/(x^2+4)
a = 0
plot(func3_1, from=-10, to=10)
abline(v = a)
solve3_1 <- uniroot.all(func3_1,interval = c(-10,10))
answer3_1 <- integrate(func3_1,lower = solve3_1[2],upper = solve3_1[1]) 
#3.2
func3_2 <- function(x) x^3 * sqrt(x-1)
a = 10
plot(func3_2, from=-10, to=10)
abline(v = a)
solve3_2 <- uniroot.all(func3_2,interval = c(-10,10))
answer3_2 <- integrate(func3_2,lower = solve3_2[2],upper = solve3_2[1])

#4
#4.1 Данные изучены
#4.2
df = airquality
ggplot(df, aes(df$Ozone)) + geom_boxplot()
#4.3
pairs(df)
#4.3.2
corrgram(df)
#4.3.3
fit = lm(Ozone ~ ., df)
f1 = step(fit, direction = "backward")
summary(step(fit, direction = "backward"))
#Наибольшим образом зависит от солнечного света, ветра и температуры, исходя из результатов анализа по Р-валуе.
#5.1
df_1 = read.csv('C:\\Users\\User\\Desktop\\Настя\\nassCDS.csv')
df_1
#5.3
pairs(df_1)
corrgram(df_1)
#на графике цветом отмечены степени влияния факторов друг на друга
#5.4
df_1
fit = lm(weight ~ ., df_1)
f2 = step(fit, direction = "backward")
summary(step(fit, direction = "backward"))
#5.2
df_1 <- factor(df$frontal)
#5.3
fit = lm(dead ~ ., df_1)
f2 = step(fit, direction = "backward")
summary(step(fit, direction = "backward"))
#6.1
m = matrix(data = 1:25, nrow = 5, ncol = 5)
