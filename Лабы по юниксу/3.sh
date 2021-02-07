#!/bin/bash

echo "Доброе утро, $username!"
echo "Текущее время и дата:"
date | awk '{print $4}'
cal
echo "Список ваших дел: "
cat ~/TODO.txt