library(lmtest)
library(orcutt)

df <- read.table(file = "task1.txt", header = TRUE, dec=',')

lm1 <- lm(as.numeric(df$Y) ~ as.numeric(df$X))
s1 <- summary(lm1)
s1

coch = cochrane.orcutt(lm1); coch
coch_coef = coch$coefficients 

