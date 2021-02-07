#!/bin/bash

date | awk '{print $3, $2, $4}'
echo 'Зарегистрированные пользователи:'
sed 's/:.*//' /etc/passwd
uptime -p | sed 's/up /Система работает: /'
