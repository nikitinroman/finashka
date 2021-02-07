#1
func = function(x){
  if (length(x) == 1){
    return(mean(x))
  } else {
    return(range(x))
  }
}

(vect = apply(matrix(rnorm(5),nrow = 1),2,func))
mode(test_1) #numeric

(matrix = apply(matrix(rnorm(5),nrow = 5), 2,func))
mode(test_3) #character

#2
vblbros = function(x){
  if (any(abs(x - mean(x)) > sd(x)*2)){
    return(length(subset(x,abs(x - mean(x)) > sd(x)*2)))
  } else {
    return('нет выбросов')
  }
}
(lst = apply(iris[1:4],2,vblbros))

#3
vblbros = function(x){
  if (any(abs(x - mean(x)) > sd(x)*2)){
    return(subset(x,abs(x - mean(x)) > sd(x)*2))
  } else {
    return('Ќет выбросов')
  }
}

(subs = apply(content[1:4],2,vblbros))

#4
mat = matrix(c(1,0,4,-2,1,1,2,3,4,2,0,-3,3,1,3,2,9,5,4,0,3,2,0,-5,5,7,1,-2,8,3,6,4,1,2,0,2), nrow = 6, byrow = TRUE)
maximum <- function(x) norm(x, type = "2")
(answer <- mat[,which.max(apply(mat, 2, maximum))])

#5
(a = apply(mtcars, 2, mean))
(l = lapply(mtcars, mean))
#В lapply не нужно указывать, что мы обрабатываем- столбец или строку, а так же выводит список, а не вектор.
#Так и не разобрался, почему apply выдает везде NA, а lapply- нет

#6
(l = lapply(airquality,mean))

#8
replicate(5,mean(rnorm(10,15,5)))

#9
(t = tapply(mtcars$mpg, mtcars$carb, max))
(b = by(mtcars$mpg, mtcars$carb, max))
#Разный вывод данных.

#10
(last = outer(1:9,1:9,FUN = function(x,y){paste(x,'*',y,'=',x*y, sep = ' ')}))
