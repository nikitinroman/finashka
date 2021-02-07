library("readxl")
library('psych')
library("corrgram")
library("ggplot2")

#1
my_data <- read_excel("Занятие 18 (1).xlsx", sheet = 1)
cor(my_data[2], my_data[3])

#2 
#Линейная
my_data = data.frame(read_excel("Занятие 18 (1).xlsx", sheet = '2'))
my_data
lm_dat = lm(indroscen ~ indprompros, my_data); lm_dat
df = my_data[, c(2, 3)]
df
df_lm = lm(indroscen ~ indprompros, df)
df_lm

#Cтепенная
lm_dat = lm(indroscen ~ (indprompros)^2, my_data); lm_dat

#3
my_data = data.frame(read_excel("Занятие 18 (1).xlsx", sheet = '3'))
my_data
print(corr.test(my_data), short=FALSE)
lm_dat = lm(projmin ~ sredplat, my_data); lm_dat
#y = 0.5648x - 2.3873

#4
my_data = read_excel("Занятие 18 (1).xlsx", sheet = '4')
#my_data$group = ifelse(my_data$group == "A", 0, 1)
corr.test(my_data[, c(2,3)])
lm(y ~ x, my_data)
new_df = my_data[my_data$group == "Б",]
corr.test(new_df[, c(2,3)])
lm(y ~ x, new_df)

new_df = my_data[my_data$group == "А",]
corr.test(new_df[, c(2,3)])
lm(y ~ x, new_df)
# Группа действительно влияет на коэфф корреляции, результаты в группах отличаются.

#5
my_data = read_excel("Занятие 18 (1).xlsx", sheet = '5')
new_df = my_data[my_data$city == "NYC",]
new_df_1 = my_data[my_data$city != "NYC",]

print(describeBy(my_data, group = "city"))
print(summary(subset(my_data, city == "NYC")))
summary(subset(my_data, city == "LI"))

corrgram(my_data, lower.panel = panel.pie)
