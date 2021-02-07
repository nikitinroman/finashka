data <- read.csv("data.econ.csv")
model <- lm(vvp ~ odn + scn + gpn, data = data)
model
summary(model)
library(lmtest)

# Гетероскедатичность

bptest(model,
       data = data,
       studentize = TRUE)

# Автокорреляция

bgtest(model, order = 1)
bgtest(model, order = 2)
bgtest(model, order = 3)

new_year <- data[24,]
new_year$odn <- new_year$odn * 0.91
new_year$scn <- 44.46
new_year$gpn <- 92
new_year
predict(model, new_year)
