library(rootSolve)

#TASK 1
func1 <- function(x)sin(x + pi/4)
(answer1 <- uniroot.all(func1,interval = c(-pi,pi)))

#TASK2
func2 <- function(x)log(base = 3, x^2 + 8*x + 16)
(answer2 <- uniroot.all(func2,interval = c(-100,100)))

#TASK3
func3_1 <- function(x)1/x^2
a = 0.01
plot(func3_1)
abline(v = a)
(answer3_1 <- integrate(f = func3_1, lower = a, upper = Inf))

#TASK4
graphics.off()
func4_1 <- function(x)x*sqrt(9-x^2)
plot(func4_1,from = -10, to = 10)
abline(h=0)
(solve4_1 <- uniroot.all(func4_1,interval = c(-10,10)))
(answer4_1 <- integrate(func4_1,lower = solve4_1[2],upper = solve4_1[1]))

#TASK5
graphics.off()
func5_1 <- function(x)4-x^2
func5_2 <- function(x)x^2-2*x
plot(func5_1, from=-10, to=10)
par(new=TRUE)
plot(func5_2, from=-10, to=10)
func5_3 <- function(x)4-x^2-x^2+2*x
(rts <- uniroot.all(func5_3,interval = c(-10,10)))
(int5_1 <- integrate(func5_1,lower = rts[1],upper = rts[2]))
(int5_2 <- integrate(func5_2,lower = rts[1],upper = rts[2]))
(answer5 <- as.numeric(int5_1[1]) - as.numeric(int5_2[1]))


#TASK6
graphics.off()
func6_1 <- function(x)sin(x)*cos(x)^2
#0< X < pi/2

plot(func6_1,from = 0, to = pi/2)
abline(h=0)

(answer6 <- as.numeric(integrate(func6_1, lower = 0, upper = pi/2)[1]))


#TASK7

func7 <- function(x)-x^2 + 5
{
graphics.off()
plot(func7, xlim = c(-5,5), ylab = c(-20,5))
abline(h=0,lty=2)
abline(v=-4,lty=2)
abline(v=-2,lty=2)
abline(v=3,lty=2)
abline(v=4,lty=2)
lines(seq(-4,2,0.1),func7(seq(-4,2,0.1)),type = "h")
lines(seq(3,4,0.1),func7(seq(3,4,0.1)),type = "h")
}


(rts7 <- uniroot.all(func7,lower = -4, upper = 4))
(part7_1 <- -as.numeric(integrate(func7, -4, rts7[1])[1]))
(part7_2 <- as.numeric(integrate(func7, rts7[1], rts7[2])[1]))
(part7_3 <- -as.numeric(integrate(func7, 3, 4)[1]))
(total7 <- part7_1 + part7_2 + part7_3)


#TASK8

func8.1 <- function(x)x^3-12*x-4
{graphics.off()
plot(func8.1,-10,10)}
(answ8.1min <- optimize(func8.1,lower = -10, upper = 10))
(answ8.1max <- optimize(func8.1,lower = -10, upper = 10, maximum = TRUE))

func8.2 <- function(x)(x+1)/(x-1)^2
{graphics.off()
plot(func8.2,-10,10)}
(answ8.2min <- optimize(func8.2,lower = -10, upper = 10))
(answ8.2max <- optimize(func8.2,lower = -10, upper = 10, maximum = TRUE))

func8.3 <- function(x)x/(9-x)
{graphics.off()
  plot(func8.3,-10,15)}
(answ8.3min <- optimize(func8.3,lower = -10, upper = 15))
(answ8.3max <- optimize(func8.3,lower = -10, upper = 15, maximum = TRUE))

func8.4 <- function(x)x^2/(4*x^2-1)
{graphics.off()
  plot(func8.4,-10,15)}
(answ8.4min <- optimize(func8.4,lower = -10, upper = 15))
(answ8.4max <- optimize(func8.4,lower = -10, upper = 15, maximum = TRUE))


#TASK9

e1 <- expression(sin(x))
(D(e1,"x"))

e2 <- expression(cos(x))
(D(e2,"x"))


#TASK 10
x <- pi/4
y <- pi/6
exp1 <- expression(sin(x+y^2))

(eval(D(exp1,"x")))


x <- pi
exp2 <- expression(cos(x))
(eval(D(exp2,"x")))
