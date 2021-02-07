library(tibble)
library(psych)
library(dplyr)

#task 1
data1 = data.frame(read.csv("evals.csv",encoding = "UTF-8", sep = ",", header = TRUE))
data1$score

#task 2
what_is_score = c()
for (i in 1:nrow(data1)){if (data1$score[i]>4.5) {what_is_score[i] = "Hight"} else if (4 < data1$score[i] & data1$score[i] < 4.5)  {what_is_score[i] = "Middle"}  else {what_is_score[i] = "Low"}}
what_is_score
data1 = add_column(data1, what_is_score, .after = "score")
head(data1)

#task 3
data1$what_is_score_2 <- ifelse(data1$score >=4.5, "Hight", ifelse(data1$score >= 4, "Middle", "Low")) 
head(data1)

#task 4
for (i in 1:nrow(data1))
  switch(
    as.character(data1$gender[i]),
    "male" = data1$gender2[i] <- "мужчина︎",
    "female" = data1$gender2[i] <- "женщина︎"
  )
head(data1)

#task 5
aggregate(cls_credits ~ gender2, data1, length)

#task 6
data1$rank
aggregate(cls_credits ~ gender2 + language, filter(data1, rank == "teaching"), length)

#task 7
stats_column <- sapply(data1, typeof) %in% c("integer", "double") & !sapply(data1, is.factor)
describe(data1[, stats_column]) 

#task 8
describeBy(data1[, stats_column], group = data1$gender) 