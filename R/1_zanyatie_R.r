Никитин ПИ18-2

#1. Как вы могли заметить, я установил RStudio!

#2. 10 примеров использования операторов присвоения
a<-5
5->qq
q=5
h1h=90
height=80
высота=90
hРІ=90
bb<-7
6->six

#3.Проверить возможность использования имен переменных: t, T, f, F, q, a.
t=9
T=10
f=9
F=10
q=10
a=10
# Сообщений не возникло, будут лишь тогда, когда будем пытаться использовать зарезервированные переменные.

#4. Построить выражения с использованием функций (не менее 10 примеров)
sqrt(a)
tan(pi/2)
cos(1)
factorial(qq)
sin(1)
min(a)
max(a)
new = c(1,23,4,5,6,7,8,888,-19,-2,0)
min(new)
max(new)
mean(new)

#5. Вызвать справку по 3 любым функциям из п.3. Описать их одной фразой. 
?q #заканчивает начатую сессию 
?F #сокращенный вариант FALSE, булев тип
?T #сокращенный вариант TRUE, булев тип

#6. Числовые объекты. Типы numeric integer double. Функции is.___ as.___  
xxx = numeric(1) #Создал переменные трех типов 
yyy <- double(1) 
integer(1) -> zzz 
integer(1) -> zzz1 
xxx = 1 # Присвоил значения (целочисленные и дробные) 
yyy = 1.1 
zzz = -7 
zzz1 = 7 
is.double(yyy) #Проверил принадлежность к типам
is.double(xxx) 
is.integer(xxx) 
as.double(xxx) #Преобразовал в другие типы данных 
as.integer(zzz) 
as.integer(yyy) 
is.double(yyy) #Проверил принадлежность к типам 
is.double(xxx) 
is.integer(zzz)

#7. Логические объекты. Тип logical. 
flag<-logical(1)#Создал переменные logical 
bad_flag = logical(1)
short_flag<-logical(1)
short_flag1<-logical(1)
rm(T)#В 3 задании я переприсвоил зарезервированным переменным новые значения, а тут возникла ошибка, о которой я предупреждал выше!
rm(F)
short_flag = T#Присвоил значения в полном написании (TRUE/FALSE), сокращенном (T/F) 
short_flag1 = F
flag = TRUE 
bad_flag = FALSE
flag #Вывел значения переменных logical
bad_flag
short_flag
short_flag1
flag<-as.numeric(flag) #Присвоил переменным logical значения переменных numeric 
bad_flag<-as.numeric(bad_flag)
short_flag<-as.numeric(short_flag)
short_flag1<-as.numeric(short_flag1)
flag #Вывести значения переменных logical
bad_flag
short_flag
short_flag1
flag<-as.character(flag) #Присвоил переменным logical значения переменных character 
bad_flag<-as.character(bad_flag)
short_flag<-as.character(short_flag)
short_flag1<-as.character(short_flag1)
flag #Вывел значения переменных logical
bad_flag
short_flag
short_flag1

#8.Символьные объекты. Тип character (не)
x<-"0" #Из character в numeric, integer, double, logical
yn<-as.numeric(x)
yi<-as.integer(x)
yd<-as.double(x)
yl<-as.logical(x)
yn
yi
yd
yl
v<-"134"#Из character в numeric, integer, double, logical
zn<-as.numeric(v)
zi<-as.integer(v)
zd<-as.double(v)
zl<-as.logical(v)
zn
zi
zd
zl
p<-"T"
pl<-as.logical(p)
pl
o<-"False"
ol<-as.logical(o)
ol
i<-F#Из logical в character 
i<-as.character(i);i
i1<-as.logical(i);i1
e543<-4#из numeric в character
e543<-as.character(e543);e543
e544 = 3.1
e544 = as.double(e544);
e544<-as.character(e543);e544
yyy1 <- double(1) 
yyy1 = 3.111
is.double(yyy1)

#Преобразования. Функция mode

#9.1. Создать переменные различных типов и проверить их тип (не менее 10 примеров)
xxxx = numeric(1)
yyyy <- double(1) 
integer(1) -> zzzz 
bad_flag1 = logical(1)
short_flag1<-logical(1)
short_flag11<-logical(1)
short_flag1 = T#Присвоил значения в полном написании (TRUE/FALSE), сокращенном (T/F) 
short_flag11 = F
flag1 = TRUE 
bad_flag1 = FALSE
aa1<-5
5->qqa1
qa1=5
e54444 = 3.1
mode(qa1)
mode(aa1)
mode(bad_flag1)
mode(flag1)
mode(short_flag11)
mode(short_flag1)
mode(xxxx)
mode(yyyy)
mode(zzzz)
mode(e54444)

#9.2. Написать примеры преобразования переменных (не менее 10 примеров)
zzzz = as.character(zzzz)
mode(zzzz)
xxxx = as.character(xxxx)
mode(xxxx)
yyyy = as.character(yyyy)
mode(yyyy)
qa1 = as.double(qa1)
mode(qa1)
aa1 = as.double(aa1)
mode(aa1)
flag1 = as.character(flag1)
mode(flag1)
bad_flag1 = as.character(bad_flag1)
mode(bad_flag1)
short_flag11 = as.character(short_flag11)
mode(short_flag11)
short_flag1 = as.character(short_flag1)
mode(short_flag1)
e54444 = as.double(e54444)
mode(e54444)

#10. Специальные переменные Inf, NA, NaN, NULL
#10.1. Создать объекты, содержащие специальные переменные
#10.2. Проверить объекты на принадлежность к специальным переменным
lol = NULL
class(lol)
kek = NA
class(kek)
lel = Inf
mode(lel)
kok = NaN
mode(kok)

#11. Сохранить историю команд в файл. Результат выслать В.В.Шевцову shevtsov_vv@pfur.ru
#Записал, отправляю работу!
#12. Завершить работу
#Завершил работу, честное слово!
