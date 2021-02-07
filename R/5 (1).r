library(rootSolve)
#1
func1 = function(x) {y = sin(x+pi/4); return(y)}
answ = uniroot(f1,interval = c(-5*pi/4:3*pi/4))
plot(func1,-5*pi/4:3*pi/4)

#2
func2 <- function(x)log(base = 3, x^2 + 8*x + 16)
(answ <- uniroot.all(func2,interval = c(-100,100)))

#3
func3_1 <- function(x)1/x^2
param = 0.004
plot(func3_1)
abline(v = param)
(answ <- integrate(f = func3_1, lower = a, upper = Inf))

#4
func4_1 <- function(x)x*sqrt(9-x^2)
plot(func4_1,from = -10, to = 10)
abline(h=0)
(solve4_1 <- uniroot.all(func4_1,interval = c(-10,10)))
(answ <- integrate(func4_1,lower = solve4_1[2],upper = solve4_1[1]))

#5
func5_1 <- function(x)4-x^2
func5_2 <- function(x)x^2-2*x
plot(func5_1, from=-10, to=10)
par(new=TRUE)
plot(func5_2, from=-10, to=10)
func5_3 <- function(x)4-x^2-x^2+2*x
(rts <- uniroot.all(func5_3,interval = c(-10,10)))
(int5_1 <- integrate(func5_1,lower = rts[1],upper = rts[2]))
(int5_2 <- integrate(func5_2,lower = rts[1],upper = rts[2]))
(answ <- as.numeric(int5_1[1]) - as.numeric(int5_2[1]))


#6
func6_1 <- function(x)sin(x)*cos(x)^2

plot(func6_1,from = 0, to = pi/2)
abline(h=0)

(answ <- as.numeric(integrate(func6_1, lower = 0, upper = pi/2)[1]))