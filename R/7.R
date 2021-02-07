library(datasets)
quakes
hist(quakes$mag)
hist(quakes$depth)
plot.default(quakes$depth)
plot.default(quakes$mag)
hist(quakes$mag*quakes$depth)

data1 = data.frame(read.csv("data.csv",encoding = "UTF-8", sep = ";"))
colnames(data1)
barplot(c(data1$znachenie_pokazatelya), col = c("orange","blue","red","green"), xlab = "barplot", horiz = TRUE)
library(dplyr)
storms
Amy = c(storms[storms$name == "Amy"]); Amy
Amy = filter(storms, storms$name == "Amy"); Amy
plot(Amy$long, Amy$lat)
points(Amy$long, Amy$lat, cex=Amy$wind)
grid()


data2 = data.frame(read.csv("okruga.csv",encoding = "UTF-8", sep = ",", header = TRUE ))
(data2)
{
  graphics.off()
  columns = 3
  for (i in data2$Регион){
    plot(x = c(2005,2010,2011,2012,2013), y = data2[data2$Регион == i,3:7], ylim = c(0,5000),type="l",col=col)
    par(new=TRUE)
    col = col + 1
  }
  legend("top",title="Regions", legend = unlist(data2$Регион), fill = 3:11)
}
pie(data2$X2005,labels = unlist(data2$Регион),col = 3:11)