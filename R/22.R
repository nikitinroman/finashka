install.packages("magrittr")
install.packages("dplyr")
install.packages("readxl")
install.packages("stringr")
library(stringr)
library(readxl)
library(tidyverse)
library(dplyr)

#1
df = read_excel("C:\\Users\\User\\Desktop\\R\\kek_2.xlsx")

df = df %>% fill(Страна, Округ, .direction = "up" ) #Заполняет вверх, так как у нас сверху пусто, то ничего не сделает
df = df %>% fill(Страна, Округ, .direction = "updown" ) #Заполняет и верх и низ
df = df %>% fill(Страна, Округ, .direction = "down" ) #Заполняет только низ


df = df %>% pivot_longer(cols = c('2005', '2010', '2011', '2012', '2013', '2014', '2015', '2016', '2017', '2018'), names_to = "year", values_to = "population")
df

df1 = tidyr::who
df1

#2
df1 = df1 %>% pivot_longer(cols = new_sp_m014:newrel_f65, names_to = c("diagnosis", "gender", "age"),
                     names_pattern = "new_?(.*)_(.)0?([1-9]*)", values_to = "Count") 
tail(df1)

df1 = df1 %>% pivot_longer(cols = new_sp_m014:newrel_f65, names_to = c("diagnosis", "gender", "age"),
                     names_pattern = "new_?(.*)_(.)(.*)", values_to = "Count")

#3
df2 = world_bank_pop 
df2

df2 <- df2 %>% pivot_longer(cols = c('2000', '2001', '2002', '2003', '2004', '2005',
                                    '2006', '2007', '2008', '2009', '2010', '2011', 
                                    '2012', '2013', '2014', '2015', '2016', '2017'), 
                           names_to = 'Year', values_to = 'value') %>% extract(col = indicator, into = c("area", "variable"), regex = "...(...).(....)")
df2
