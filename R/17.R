library(ggplot2)

#1
#1)
df = read.csv("evals.csv")
df$score_new = ifelse(df$score>3.5, "high", "low")
df$score_new = factor(df$score_new)
#2)
t1 = table(df$score_new)
t1

#2
df = mtcars
df$new = ifelse(df$wt > 3, "Тяжко", "Нормально")
df$new = factor(df$new)
t2 = table(df$new, df$cyl)
prop.table(t2)
prop.table(t2, 1)
df
barplot(t2)

#3
df = iris
df
df = subset(df, Species!="versicolor")
df
t3 = table(df$Species); t3
hist(t3)

ggplot(df, aes(df$Petal.Length)) + geom_histogram(fill="white", col = "gray", binwidth = 0.5) +
  facet_grid(df$Species)

ggplot(df, aes(df$Petal.Length, col = df$Species, fill = df$Species, alpha = 0.5)) + geom_density()

ggplot(df, aes(df$Species, df$Petal.Length)) + geom_boxplot()
