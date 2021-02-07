# Vladimir Kirilkin PI18-2

#task 1
# Операции с многомерными элементамиv (используем набор данных mtcars)
mtcars[ncol(mtcars):1]
mtcars[1:3]
mtcars[with(mtcars, order(mpg)),]
mtcars[mtcars$mpg > 20 & mtcars$carb == 2,]

#task 2
library(rootSolve)
func1 <- function(x) 2 * x - x^2;
func2 <- function(x) -x;
(roots <- uniroot.all(func1, c(-10, 10)))
abs(as.numeric(integrate(func2, lower = roots[1], upper = roots[2])$value)) -
  abs(as.numeric(integrate(func1, lower = roots[1], upper = roots[2])$value))

#task 3
func1 <- function(x) x / (x^2 + 4)
curve(func1, -6, 6)
abline(v = 0, lty = 3)
abline(h = 0, lty = 3)
optimize(func1, c(-6, 6))
optimize(func1, c(-6, 6), maximum = T)

func2 <- function(x) (x^3) * sqrt(x - 1)
curve(func2, 0, 15)
abline(v = 0, lty = 3)
abline(h = 0, lty = 3)
optimize(func2, c(0, 15))
optimize(func2, c(0, 15), maximum = T)

#task 4
head(airquality)
boxplot(airquality$Ozone)
pairs(airquality)
# Температура имеет корреляцию с ветром и с месяцем
cor(airquality)
summary(lm(Ozone ~ Wind + Temp + Solar.R, airquality))
# Содержание озона зависит в большей степини от температуты, затем от ветра и от радиации

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