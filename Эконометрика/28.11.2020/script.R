library(lmtest)
#Никитин Роман ПИ18-2
#4 подзадание

df <- read.csv2(file = "data.csv", header = TRUE, dec=',')
df

#df_for_predict = data.frame(c(8,16,6), 
#                col.names = c("x1","x2","x3"))
#df_for_predict

new_data <- data.frame(c(8.0), c(16.0), c(6.0))
colnames(new_data) <- c('x1', 'x2', 'x3')

lm1 <- lm(df$yt~df$п.їx1t+df$x2t+df$x3t)
summary(lm1)

#for_predict = df(c(8,16,6), colnames = c("x1","x2","x3"))

answ1 = predict(lm1, new_data)

answ1
#       1        2        3        4        5 
#40.67424 80.55092 54.28832 57.77968 69.70683 


lm2 <- lm(df$yt~df$п.їx1t+df$x3t)
summary(lm2)

answ2 = predict(lm2, new_data)

answ2
#       1        2        3        4        5 
#40.68620 80.46450 54.15390 57.84996 69.84544 


lm3 <- lm(df$yt~1.5*(df$x2t)+df$x2t+df$x3t)
summary(lm3)

answ3 = predict(lm3, new_data)

answ3
#       1        2        3        4        5 
#40.66703 80.63598 54.42886 57.69729 69.57084 

#Все модели получились значимыми на уровне 0.05, Первая модель не значима на уровне 0.01
#Так же приложу вычисления в Python