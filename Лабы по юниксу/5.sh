#!/bin/bash

echo "Домашний каталог пользователя $username"
ls -aAF ~ | awk 'BEGIN {simple=0; hidden=0} 
               /^[^\.].*[^\/]$/{simple+=1}
               /^\..*[^\/]$/{hidden+=1}
               END{printf "Содержит обычных файлов:\n" simple "\nскрытых файлов:\n" hidden "\n"}'
