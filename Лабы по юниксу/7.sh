#!/bin/bash

ps aux | awk -v username="$USER" 'BEGIN {user=0; root=0} 
               {if ($1 == username)
                    user+=1
                elif ($1 == "root")
                    root+=1
                fi}
               END{printf "Процессов пользователя:\n" username "\n" user "\nПроцессов пользователя root:\n" root "\n"}'
