#1
library(ggplot2)
mt <- mtcars
mt
mt$vs <- factor(mt$vs)
mt$gear <- factor(mt$gear)
mt$cyl <- factor(mt$cyl)

#2
#1
qplot(log(mpg), log(hp), geom = "point", data=mt)
#2
qplot(log(mpg), log(hp), geom = c("point"), data=mt, colour = qsec)
#3
qplot(log(mpg), log(hp), geom = c("point","smooth"), data=mt, colour = qsec)

#3
qplot(vs, log(wt),data=mt, geom="jitter")
qplot(gear, log(wt),data=mt, geom="jitter")

#4
qplot(vs, log(wt),data=mt, geom="boxplot")
qplot(gear, log(wt),data=mt, geom="boxplot", fill="blue" )

#5
qplot(hp, data=mt, geom="histogram")
qplot(hp, data=mt, geom="histogram", binwidth=10)
qplot(carb, data=mt, geom="histogram")

#6
qplot(cyl, data = mt, geom="bar")
qplot(cyl, data = mt, geom="bar", weight = mpg)

#7
qplot(log(drat), data = mt, geom = "freqpoly")
qplot(log(drat), data = mt, geom = "freqpoly", binwidth=0.1)
qplot(log(drat), data = mt, geom = "freqpoly", binwidth=0.1, colour = cyl)

#8
qplot(drat, data = mt, geom = "density", colour=cyl)

#9
qplot(cyl, data=mt, geom="bar", fill=cyl)

#10
qplot(cyl, data=mt, geom="bar", fill=cyl, facets=vs ~ .)
qplot(gear, wt, data=mt, geom="boxplot", fill="red", facets=cyl ~ .)
