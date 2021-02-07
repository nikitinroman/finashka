#!/bin/bash
# Скрипт работает намного лучше, чем то, что я скинул доком
ps -aux > ps.out
sort ps.out -o sorted.ps

echo '<html>' > index.html
echo '<title>Статистика процессов</title>' >> index.html
echo '<body>' >> index.html
echo '<h1>Распределение процессов между пользователями</h1>' >> index.html

for user in `cut -d' ' -f1 sorted.ps | sort -u`
do
	cat sorted.ps | grep -E "^$user" > $user.ps
	cp $user.ps $user.html
	sed 's/^/<li>/' $user.ps > $user.html
	echo '<p><b>Итого процессов: ' `wc -l $user.ps | cut -d' ' -f1` '</b>' > $user.total
	cat $user.html >> index.html
	echo '<hr noshade>' >> index.html
	cat $user.total >> index.html
done

echo '</body></html>' >> index.html