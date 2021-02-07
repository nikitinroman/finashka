data <- read.table("data.txt", dec = ",", header = TRUE)
m <- lm(y ~ x, data = data)
s <- summary(m)
install.packages('lmtest')
library(lmtest)
dw <- dwtest(m)
dw

bg1<-bgtest(m, order =1);bg1
#При альфа 1,5,10%  процентов - Н0 принимаем - автокорреляция 1 порядка отсутствует
bg2 <-bgtest(m, order =2);bg2
#При альфа 1,- атвокор нет
#5,10%  процентов - Н1 принимаем - автокорреляция 2 порядка  есть
bg3 <-bgtest(m, order =3);bg3
#При альфа 1 процентов - Н0 принимаем - автокорреляция 3 порядка отсутствует
#При альфа 5,10 процентов - Н1 принимаем - автокорреляция 3 порядка  есть

# Гетероскедонтичность
gq <- gqtest(m, order.by = ~x, fraction = 0.25, data = data); gq
# При всех альфа принимаем - гипотезу H1 - гетероскедастичность есть

bp <- bptest(m, data = data, varformula = ~x+I(x^2), studentize = TRUE);bp
# При альфа 1,5,10%  принимаем Н1 гетероскедастичность

#Доверительные интервалы:
int_1 <- confint(m, level=0.95); int_1

#бета коэффициент
beta_coeff <- s$coefficients[2]*(sd(data$Yd)/sd(data$S)); beta_coeff

#дельта коэффициент
delta_coeff <- cor(data$S, data$Yd)*(s$coefficients[2]/s$r.squared); delta_coeff

#эластичность
el <- s$coefficients[2]*(mean(data$Yd)/mean(data$S)); el