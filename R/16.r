library(ggplot2)

# 1
# 1)
df = mtcars
df
cor.test(x = df$mpg, y = df$hp)
#2)
ggplot(df, aes(x = mpg, y = hp)) +
    geom_jitter(size = 3) +
    geom_smooth()
#3)
ggplot(df, aes(x = hp, y = mpg, color = factor(am))) +
    geom_jitter(size = 2) +
    geom_smooth(method = lm)
#4)
dfn = df[, c(1, 3:7)]
dfn
df_lm = lm(mpg ~ hp, dfn)
df_lm
df_result = data.frame(mpg = dfn$mpg, fitted <- df_lm$fitted.values)
df_result

df_new = data.frame(hp = c(100, 150, 200, 300))
predict(df_lm, df_new)
df_new$mpg_new = predict(df_lm, df_new)
df_new

#__________________________________________________
#1
#1)
cor.test(x = df$wt, y = df$hp)
#2)
ggplot(df, aes(wt, hp)) +
    geom_point() +
    geom_smooth()
#3)
ggplot(df, aes(wt, hp, color = factor(vs))) +
    geom_point() +
    geom_smooth()
#4)
dfn = df[, c(1:7)]
dfn
df_lm = lm(wt ~ hp, dfn)
df_lm
result = data.frame(wt = dfn$wt, fitted_wt = df_lm$fitted.values)
result
new_df = data.frame(hp = c(100,200,300,400))
predict(df_lm, new_df)
new_df$predicted_wt = predict(df_lm, new_df)
new_df

#2
df_lm <- lm(hp ~ wt, df)
summary(df_lm)

ggplot(df, aes(hp, wt)) +
    geom_point() +
    geom_smooth(method = lm)
#3
pairs(mtcars)
pairs(dfn)
#4
df <- swiss
View(df)
str(df)

test <- lm(Agriculture ~ Education + Infant.Mortality, data = df)
summary(test)
#Так до конца и не понял, но вроде, если анализирую правильно- то
#чем выше процент получивших образование, тем меньше людей в сель-хозе.

test <- lm(Agriculture ~ Education * Infant.Mortality, data = df)
summary(test)

confint(test)

df$mortality <- ifelse(df$Infant.Mortality > 20, "Lots", "Few")
df$mortality <- factor(df$mortality)
str(df)

test <- lm(Agriculture ~ Examination + mortality, data = df)
summary(test)

test <- lm(Agriculture ~ Examination * mortality, data = df)
summary(test)

ggplot(df, aes(x = Agriculture, y = Examination, col = mortality)) +
    geom_point() +
    geom_smooth()

ggplot(df, aes(x = Agriculture, y = Examination, col = mortality)) +
    geom_point() +
    geom_smooth(method = lm)


#5
df <- read.csv2("evals.csv", sep = ",")
df$score <- as.double(df$score)
df$cls_perc_eval <- as.double(df$cls_perc_eval)
View(df)
str(df)


test <- lm(score ~ age + gender, data = df)
summary(test)

ggplot(df, aes(x = age, y = score, col = gender)) +
    geom_point() +
    geom_smooth(method = lm)

# С возрастом score у женщин падает быстрее, чем у мужчин