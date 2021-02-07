install.packages("ggplot2")
library(datasets)
library(ggplot2)
library(tibble)
library(psych)
library(dplyr)
#task 1
data(mtcars)
head(mtcars)
boxplot(mtcars$hp)
boxplot(mtcars$cyl)
boxplot(mtcars$drat)
boxplot(mtcars$disp)
ggplot(data=mtcars, aes(x = "", y = hp)) + geom_boxplot()
ggplot(data=mtcars, aes(x = "", y = cyl)) + geom_boxplot()
ggplot(data=mtcars, aes(x = "", y = drat)) + geom_boxplot()
ggplot(data=mtcars, aes(x = "", y = disp)) + geom_boxplot()
mtcars
#1_2
kek = factor(mtcars$cyl)
ggplot(data=mtcars, aes(x=kek, y=wt)) + geom_point()
data1 <- mtcars
head(data1)
what_is_type = c()
for (i in 1:nrow(data1)){if (data1$wt[i]>3.7) {what_is_type[i] = "Hight"} else if (3 <data1$wt[i] &data1$wt[i] < 3.7)  {what_is_type[i] = "Middle"}  else {what_is_type[i] = "Low"}}
what_is_type
data1 = add_column(data1, what_is_type, .after = "wt")
head(data1)

what_is_type_1 = c()
for (i in 1:nrow(data1)){if (data1$gear[i]>4) {what_is_type_1[i] = "Много"} else if (3 <data1$gear[i] &data1$wt[i] < 4)  {what_is_type_1[i] = "Средне"}  else {what_is_type_1[i] = "Мало"}}
what_is_type_1
data1 = add_column(data1, what_is_type_1, .after = "what_is_type")
head(data1)

kek = factor(data1$what_is_type)
ggplot(data=mtcars, aes(x=kek, y=wt)) + geom_point()

kek = factor(data1$what_is_type_1)
ggplot(data=data1, aes(x=kek, y=wt)) + geom_point()

mtcars_1 = mtcars
mpg_class = c()
for (i in 1:nrow(mtcars_1)){if (mtcars_1$mpg[i]>30) {mpg_class[i] = "High_mpg"} else if (mtcars_1$wt[i] < 20) {mpg_class[i] = "Low_mpg"} else {mpg_class[i] = "Middle_mpg"}}
mpg_class
mtcars_1 = add_column(mtcars_1, mpg_class, .after = "mpg")
head(mtcars_1)

kek = factor(mtcars_1$mpg_class)
ggplot(data=mtcars_1, aes(x=kek, y=wt)) + geom_point()

#task 2
# То же самое, что и выше, слишком долго делать, но честное слово, 1 раза хватило, чтобы разобраться.

#task 3
#1
ggplot(data=mtcars, aes(x=hp, y=wt)) + geom_point()
#2
ggplot(data=mtcars, aes(x=hp, y=wt)) + geom_point() + xlab("Мощность, Л.С.") +ylab("Вес") + ggtitle("Соотношение мощности автомобиля к весу.")
#3
ggplot(data=mtcars, aes(x=hp, y=wt, color=hp)) + geom_point() + xlab("Мощность, Л.С.") +ylab("Вес") + ggtitle("Соотношение мощности автомобиля к весу.")
#4
ggplot(data=mtcars, aes(x=hp, y=wt, color=hp, size=wt)) + geom_point() + xlab("Мощность, Л.С.") +ylab("Вес") + ggtitle("Соотношение мощности автомобиля к весу.")
#5
ggplot(data=mtcars, aes(x=hp, y=wt, color=hp, size=wt, alpha=wt)) + geom_point() + xlab("Мощность, Л.С.") +ylab("Вес") + ggtitle("Соотношение мощности автомобиля к весу.")
#6
ggplot(mtcars, aes(qsec, mpg)) + geom_point() + geom_abline()
#7
ggplot(data=mtcars, aes(hp, wt))+ geom_point() + geom_area() 
#8
#можно регулировать при помощи смены порядка добавления условных  geom_point(), geom_area() и тд

#4
evals = data.frame(read.csv("evals.csv",encoding = "UTF-8", sep = ",", header = TRUE))

ggplot(data=evals,aes(rank, score)) + geom_boxplot()

#если посмотреть на меньшинство
ggplot(data=evals,aes(ethnicity, score)) + geom_boxplot()

#пол
ggplot(data=evals,aes(gender, score)) + geom_boxplot()

#язык
ggplot(data=evals,aes(language, score)) + geom_boxplot()

#cls_perc_eval
ggplot(data=evals,aes(cls_perc_eval, score)) + geom_point()
#От перк эвал есть небольшая коррелация- чем больше перк эвалс, тем больше оценка студента
#cls_did_eval
ggplot(data=evals,aes(cls_did_eval, score)) + geom_point()

#cls_students
ggplot(data=evals,aes(cls_students, score)) + geom_point()

#cls_level
ggplot(data=evals,aes(cls_level, score)) + geom_boxplot()

#cls_profs
ggplot(data=evals,aes(cls_profs, score)) + geom_boxplot()
#От cls_profit не зависит.
#У мужчин оценка выше, что связано, как я полагаю, с подсознательным уважением либо страхом.
#У англоговорящих учителей оценка выше, что связано, возможно, с наиболее высоким уровнем квалификации

