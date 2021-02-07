library(lmtest)
library(orcutt)
#Никитин Роман ПИ18-2
df <- read.csv2(file = "data21112020.csv", header = TRUE, dec=',')
vvp = df$VVP
scn = df$SCN
gpn = df$GPN
odn = df$ODN
Y = log(gdp)
head(df)
df
lm1 <- lm(vvp ~ odn + scn + gpn)

s1 <- summary(lm1); s1
# scn не значим для качества модели (не приносит в нее значительных изменений.)
# gpn и odn значимы на уровне значимости 0.01
# Модель значима

#ѕроверка на гетероскедастичность
lm1_gq <- gqtest(lm1); lm1_gq;
#Гетероскедастичности нет (при альфа = 0.1)
lm1_bp <- bptest(lm1); lm1_bp;
#Гетероскедастичность есть (при альфа = 0.05)
fitted = lm1$fitted.values
qqplot(fitted, vvp)
#Гетероскедастичность есть, пятипроцентненькая)

lm1_2 = confint(lm1, level=0.95)

coch = cochrane.orcutt(lm1); coch

sum_coch = summary(coch); sum_coch

lm1_dw = dwtest(lm1); lm1_dw
#Есть автокорреляция первого порядка

lm1_coch_dw = dwtest(coch); lm1_coch_dw
#Нет автокорреляции первого порядка

lm1_bg = bgtest(lm1, order = 1); lm1_bg
#Есть автокорреляция первого порядка

lm1_coch_bg = bgtest(coch, order = 1); lm1_coch_bg
#Нет автокорреляции первого порядка

lm1_bg_o2 = bgtest(lm1, order = 2); lm1_bg_o2
#Есть автокорреляция второго порядка

lm1_coch_bg_o2 = bgtest(coch, order = 2); lm1_coch_bg_o2
#Есть автокорреляция второго порядка на увроне значимости 0.1

lm1_bg_o3 = bgtest(lm1, order = 3); lm1_bg_o3
#Есть автокорреляция второго порядка

lm1_coch_bg_o3 = bgtest(coch, order = 3); lm1_coch_bg_o3
#Есть автокорреляция второго порядка на увроне значимости 0.1


new_year <- df[24,]
new_year$ODN <- new_year$ODN * 0.91
new_year$SCN <- 44.46
new_year$GPN <- 92
new_year
answ = predict(lm1, new_year)[24]
#Предсказание на 2020 год.
answ