library(ggplot2)
library(dplyr)
library(psych)

df = mtcars

#1

fit = lm(mpg ~ ., df)
f1 = step(fit, direction = "backward")
summary(step(fit, direction = "backward"))

#Выяснилось, что наибольшее влияние на расход топлива оказывают такие параметры, как 
#Скорость разгона, тип коробки передач, вес автомобиля

#2
pairs(df)
ggplot(df, aes(mpg, wt)) + geom_point() + geom_smooth()
ggplot(df, aes(mpg)) + geom_histogram()
ggplot(df, aes(wt)) + geom_histogram()
f2 = lm(mpg~wt + am + qsec, df)
summary(lm(mpg~wt + am + qsec, df))

anova(f1,f2)     

#Можно было бы сделать вывод, что модели значимо отличаются, но вроде как не отличаются.
#Такой ответ из anova() получается, видимо, из за того, что я не до конца
#понял, что получил из step()

df$lm1_fitted = f1$fitted
df$lm1_resid = f1$residuals
ggplot(df, aes(mpg, wt)) + geom_point() + geom_line(aes(x = lm1_fitted, y = wt), col = "blue") + geom_line(aes(x = mpg, y = wt), col = "red") + geom_smooth()
#Предсказанные значения более лаконично вписываются в график, если так можно выразиться)))

#3
ggplot(df, aes(lm1_fitted, lm1_resid)) + geom_point() + geom_smooth()
#Остатки, как видно. распределены более менее равномерно.
hist(df$lm1_resid)
#Распределение немного скошено влево, но в целом близко к нормальному
