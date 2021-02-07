#!/bin/bash
awk '{

logdate = match($0, /\[(.+)\]/,logdateres)                          
host = "с хоста" $1
protocol = "по протоколу " match($0, /(HT[^ ]+)"/, protocolres)
atype = " был выполнен запрос типа " match($6, /"(.+)/, atyperes)
file = " для получения ресурса, находящегося по ссылке " $7
code = ". Код ответа на запрос от сервера: " $9 
byte = $10
refer = match($11, /"(.+)"/, referres)
useragent = match($12 " " $13 " " $14 " " $15 " " $16 , /"(.+)"[ ]{1}"-"/, useragentres)

#Проверка кол-ва переданных байт
if (byte > 0){
    bytes = " Кол-во переданных байт: " byte
} else {
    bytes= ""
}

#Следующая часть в зависимости от кода ответа (304,404,200,403)

if (code == 304){
    answ = ". Такой ответ не продполагает наличие тела ответа (кол-во переданных байт - 0)"
}
if (code == 404){
    answ = ". Ошибка, требуемого файла нет на сервере."
}
if (code == 200){
    answ = ". ОК."
}
if (code == 403){
    answ = ". Отказано в доступе."
}

#Проверка на наличие рефера

if (referres[1] == "-"){
    referansw = ". Запрос выполняелся напрямую, а не по ссылке с другого сайта (поле рефер - пустое)"
} else {
    referansw = ". Рефер: " referres[1]
}

#Вывод результата

print logdateres[1] " " host " " protocolres[1] atyperes[1] file code answ bytes referansw ". User-agent: " useragentres[1]

}' $1
