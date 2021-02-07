library(readxl)
library(lmtest)
data <- read_excel("data.xlsx")
data
x = data$x
y = data$y
x
y

#???????? ??????
reg = lm(y~x)

m_s = summary(reg)
m_s
m_s_e = m_s$residuals
m_s_se = m_s$sigma
m_s_rsq = m_s$r.squared
a = sum(abs(m_s_e/y))*100/length(y); a

#????????????? ??????
Y = log(y)

reg_2 = lm(Y~x)
m_s_2 = summary(reg_2)
m_s_e2 = m_s_2$residuals
m_s_se2 = m_s_2$sigma
m_s_rsq2 = m_s_2$r.squared
a2 = sum(abs(m_s_e2/log(y)))*100/length(y); a2

exp(summary(reg_2)$coefficient[1,1]) #? ?????
exp(summary(reg_2)$coefficient[2,1]) 

Y = log(y)
Y
X = log(x)
reg_3 = lm(Y~X)
m_s_3 = summary(reg_3);m_s_3
m_s_e3 = m_s_3$residuals;m_s_e3
m_s_se3 = m_s_3$sigma;m_s_se3
m_s_rsq3 = m_s_3$r.squared;m_s_rsq3
a3 = sum(abs(m_s_e3/log(y)))*100/length(y); a3

X2 = 1/x
reg_4 = lm(y~X2)
m_s_4  = summary(reg_4);m_s_4
m_s_e4 = m_s_4$residuals;m_s_e4
m_s_se4  = m_s_4$sigma;m_s_se4
m_s_rsq4 = m_s_4$r.squared;m_s_rsq4
a4 = sum(abs(m_s_e4/y))*100/length(y); a4

df = data.frame(c(m_s_se,exp(m_s_se2),exp(m_s_se3),m_s_se4),
                c(m_s_rsq,m_s_rsq2,m_s_rsq3,m_s_rsq4), c(a,a2,a3,a4), 
                row.names = c('????????', "?????????????", "?????????", "???????????????"))
show(df)

colnames(df) = c('sigma','r-squared', 'Approximation error'); df

m_s_2


































