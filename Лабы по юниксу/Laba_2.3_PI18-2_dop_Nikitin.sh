#!/bin/bash
echo $1
echo 'Введите код'
read t
awk -v o=$t '{if($9 == o) print $0}' $1 > result.txt
cat result.txt
bash Laba_2.3_PI18-2_Nikitin.sh result.txt
