#!/bin/bash

ls -a ~ | awk 'BEGIN {count=0} 
               /\.txt$/{count+=1}
               END{print "В домашнем каталоге " count " файлов с расширением \".txt\""}'
