#1_Создать числовые последовательности
x = 1:10; x
y = 10:1; y
seq(from = 1, to = 5, by = 0.7) -> z; z
t = rep(z, times = 2); t
r = rep(1:3,each = 2, times = 5); r
x = 1
seq(from = 1, to = 5, by = 0.75) -> z1; z1
new = seq(2,5, length.out = 12); new
#2_Cоздать буквенные последовательности
abc = letters[1:3]; abc
abc_h = LETTERS[1:3]; abc_h
cba = letters[3:1]; cba
#3_Адресация векторов
x = 1:10; x
x[1]
x[-1]
x[1:2]
x[-(1:2)]
x[c(1,5,8)]
names(x) <- c("a","b","c","d","e","f","g","h","k",'l'); x
x["g"]
x = 1:10; x
x[x>3]
x[x>3&x<6]
x[x==3]
x[x %in% c(2,5,6)]
wtf = c(FALSE,TRUE,TRUE,FALSE,TRUE,TRUE,FALSE,TRUE,TRUE,TRUE)
x[wtf]
#4_Матрицы
ma = matrix(x, nrow = 3, ncol = 3); ma
attr(x, "dim")<- 1:10 ###ya_ne_pon'yal :((
ma_c = cbind(0:5,0:5,0:5); ma_c
ma_r = rbind(0:5,0:5,0:5); ma_r
dimnames(ma_c) <- list(c("row_0", "row_1", "row_2", "row_3", "row_4", "row_5"), c("col_0", "col_1", "col_2")); ma_c
#4_5 Адресация
x[x>4]
x[x == 4]
x[x > 3 & x<8]
x[x %in% c(2,5,6)]
#5 Шахматная доска
matrix(paste(rep(seq(1, 8, 1), each=8),LETTERS[1:8], sep=""), nrow = 8, ncol = 8, dimnames = list(letters[1:8], 1:8))

matrix(rep(seq(1,10, 1), each=10)*1:10, nrow = 10, ncol = 10)
k = 0
k1 = 0
mat <- matrix(nrow = 26,ncol = 26)
for (i in 1:26){
  k = k + 1
  for (j in 1:26){
    k1 = (26+k)%%26
    mat[i,j] <- LETTERS[k1]
  }
}
mat

aaaaaaaaaa = matrix(sapply(1:26, function(n) letters[c((26-n+1):26,1:(26-n+1))][-1]),26, byrow = T); aaaaaaaaaa

#6. Создать матрицу – таблицу умножения
n1 = 1:10
n2 = 1:10
c1<-n1*n2[1];c1
c2<-n1*n2[2];c2
c3<-n1*n2[3];c3
c4<-n1*n2[4];c4
c5<-n1*n2[5];c5
c6<-n1*n2[6];c6
c7<-n1*n2[7];c7
c8<-n1*n2[8];c8
c9<-n1*n2[9];c9
c10<-n1*n2[10];c10
mul<-cbind(c1,c2,c3,c4,c5,c6,c7,c8,c9,c10);mul
dimnames(mul)<-list(c("1","2","3","4","5","6","7","8","9","10"),c("1","2","3","4","5","6","7","8","9","10"));mul
#7. Создать квадратную матрицу, заполненную буквами латинского алфавита со смещением
a<-LETTERS[1:26]
ma3<-matrix(a,nrow=25,ncol=25,byrow=T);ma3
  