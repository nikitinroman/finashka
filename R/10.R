library(ggplot2)

#task 2
ggplot(mtcars, aes(hp, drat)) + geom_point() + scale_x_continuous(quote(a^2))
scale_x_continuous(quote(a ^ 2))
scale_x_continuous(quote(b[2]))
scale_x_continuous(quote(a != b))
scale_x_continuous(quote(a %==% b))
scale_x_continuous(quote(a <= b))
scale_x_continuous(quote(a >= b))
scale_x_continuous(quote(paste(a*degree,b)))
scale_x_continuous(quote(paste(a,infinity,b)))

#task 3
ggplot(mtcars, aes(hp, drat)) + geom_point() + labs(x=NULL, y=NULL)

#task 4
ggplot(mtcars, aes(hp, drat)) + geom_point() + scale_x_log10(minor_breaks = 100)

#task 5
ggplot(mtcars, aes(hp, drat)) + geom_point() + scale_x_log10() + scale_x_continuous(breaks = 100,labels = "Я тут!")

#task 6
ggplot(mtcars, aes(hp, drat, fill=hp)) + geom_tile() + scale_fill_continuous(name="лошадки", labels=scales::unit_format(unit="лошадок"))

#task 7
ggplot(mtcars, aes(hp, drat, fill=drat)) + geom_tile() + labs(x=NULL, y=NULL) + scale_fill_continuous(name="расход на 100км", labels=scales::unit_format(unit="кушает"))
ggplot(mtcars, aes(hp, drat, fill=drat)) + geom_tile() + labs(x=NULL, y=NULL) + scale_fill_continuous(name="расход на 100км", labels=scales::unit_format(unit="кушает")) + theme(legend.position = "bottom")
ggplot(mtcars, aes(hp, drat, fill=drat)) + geom_tile() + labs(x=NULL, y=NULL) + scale_fill_continuous(name="расход на 100км", labels=scales::unit_format(unit="кушает")) + theme(legend.position = "left")
ggplot(mtcars, aes(hp, drat, fill=drat)) + geom_tile() + labs(x=NULL, y=NULL) + scale_fill_continuous(name="расход на 100км", labels=scales::unit_format(unit="кушает")) + theme(legend.position = c(0.4, 0.2))

#task 8
ggplot(mtcars, aes(hp, drat, fill=drat)) + geom_tile() + labs(x=NULL, y=NULL) + scale_fill_continuous(labels = NULL, name="расход на 100км")

#task 9
ggplot(mtcars, aes(hp, drat, fill=drat)) + geom_tile() + labs(x=NULL, y=NULL) + scale_fill_continuous(labels=scales::unit_format(unit="тысяч гривен на бензин"), name="расход на 100км")
# а если без шуток, то так
ggplot(mtcars, aes(hp, drat, fill=drat)) + geom_tile() + labs(x=NULL, y=NULL) + scale_fill_continuous(labels=scales::unit_format(unit="$"), name="расход на 100км")

#task 10
ggplot(mtcars, aes(hp, drat)) + geom_point() + scale_x_continuous(minor_breaks = mtcars$hp) + scale_y_continuous(minor_breaks = mtcars$drat)

#task 11
mtcars$gear <- as.factor(mtcars$gear)
ggplot(mtcars, aes(hp, drat, colour=qsec, shape=gear)) + geom_point()
ggplot(mtcars, aes(hp, drat, colour=qsec, shape=gear)) + geom_point() + geom_smooth()

#task 12
(g <- ggplot(mtcars, aes(hp,drat)) + geom_point(aes(colour = qsec)))
g + theme_dark()
g + theme_linedraw()
g + theme(panel.background = element_rect(fill = "#FFFF0F", colour = "grey40"))

#task 13
ggplot(mtcars, aes(hp,drat)) + geom_point() + coord_flip()
ggplot(mtcars, aes(hp,drat)) + geom_point() + coord_cartesian()
ggplot(mtcars, aes(hp,drat)) + geom_point() + coord_fixed(1 * max(mtcars$hp) / max(mtcars$drat))
