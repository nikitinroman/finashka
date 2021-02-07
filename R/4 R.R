#1
a = matrix(c(1,-1,3,2), nrow = 2, ncol = 2, byrow = TRUE);a
b = matrix(c(7,16),nrow = 2,ncol = 1,byrow = TRUE);b
det(a)
x = solve(a,b);x
#2
a = matrix(c(2,3,-1,3,-1,2,2,1,1), nrow = 3, ncol = 3, byrow = TRUE);a
b = matrix(c(0,1,4),nrow = 3,ncol = 1,byrow = TRUE);b
det(a)
x = solve(a,b);x
#3
a = matrix(c(3,4,-1,2,-1,-2,4,3,-4), nrow = 3, ncol = 3, byrow = TRUE);a
b = matrix(c(5,3,1), nrow = 3,ncol = 1,byrow = TRUE);b
x = solve(a,b);x
#7
a = matrix(c(2,5,1,3), nrow = 2,ncol = 2,byrow = TRUE);a
b = matrix(c(4,-6,2,1), nrow = 2, ncol = 2, byrow = TRUE);b
x = solve(a)%*%b;x
#8
a = matrix(c(3,-2,5,-4), nrow = 2, ncol = 2,byrow = TRUE);a
b = matrix(c(-1,2,-5,6), nrow = 2, ncol = 2, byrow = TRUE); b
x = b%*%solve(a);x
#9
a = matrix(c(2,1,3,2), nrow = 2, ncol = 2,byrow = TRUE);a
b = matrix(c(-3,2,5,-3), nrow = 2, ncol = 2, byrow = TRUE); b
d = matrix(c(-2,4,3,-1), nrow = 2, ncol = 2, byrow = TRUE); d
x = solve(a)%*%d%*%solve(b);x
#10
a = matrix(c(-1,2,-3,2,9,-6,-3,-6,0), nrow = 3, ncol = 3,byrow = TRUE);a
b = matrix(c(1,1,1,2,2,0,-3,4,-5), nrow = 3, ncol = 3, byrow = TRUE); b
e = matrix(c(1,0,0,0,1,0,0,0,1), nrow = 3, ncol = 3, byrow = TRUE); e
d = b%*%b;d
x = a%*%e%*%solve(d);x