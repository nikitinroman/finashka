
 
2.1
base  = ggplot(mtcars, aes(mpg, hp, color = factor(hp))) + geom_jitter() + geom_abline(colour = "grey50", size=2) + ggtitle("Заголовок")

a <- theme(plot.title = element_text(size=25, color = "blue", face = "bold", hjust = 0.5))

base + a

2.2
base  = ggplot(mtcars, aes(mpg, hp, color = factor(hp))) + geom_jitter() + geom_abline(colour = "grey50", size=2) + ggtitle("Заголовок")

a <- theme(
  plot.title = element_text(
      size=25, 
      color = "blue", 
      face = "bold", 
      hjust = 0.5),
  legend.background = element_rect(
        fill = "lemonchiffon", 
        colour = "black", 
        size = 0.3),
  legend.key = element_rect(color = "green"),
  legend.key.width = unit(0.5, "cm"),
  legend.key.height = unit(0.5, "cm"),
  legend.text = element_text(size = 2),
  legend.title = element_text(size == 2)
)
  
base + a

2.3
base  = ggplot(mtcars, aes(mpg, hp, color = factor(hp))) + geom_jitter() + geom_abline(colour = "grey50", size=2) + ggtitle("Заголовок")

a <- theme(
  plot.title = element_text(
      size=25, 
      color = "blue", 
      face = "bold", 
      hjust = 0.5),
      
  legend.background = element_rect(
        fill = "lemonchiffon", 
        colour = "black", 
        size = 0.3),
  legend.key = element_rect(color = "green"),
  legend.key.width = unit(0.5, "cm"),
  legend.key.height = unit(0.5, "cm"),
  legend.text = element_text(size = 10),
  legend.title = element_text(size = 12),
  
  panel.background = element_rect(fill = "#d7ebf4"),
  panel.grid.major = element_line(color = "#e7d0c1", size = 0.8),
  panel.grid.major.x = element_line(color = "#e7d0c1", size = 0.8),
  panel.grid.minor = element_line(color = "#e7d0c1", size = 0.8),
  panel.grid.minor.x = element_line(color = "#e7d0c1", size = 0.8),

  axis.line = element_line(colour = "red", size = 2),
  axis.text = element_text(color = "black", size = 12)
)

base + a

2.4
a <- theme(
  plot.title = element_text(
      size=25, 
      color = "blue", 
      face = "bold", 
      hjust = 0.5),
      
  legend.background = element_rect(
        fill = "lemonchiffon", 
        colour = "black", 
        size = 0.3),
  legend.key = element_rect(color = "green"),
  legend.key.width = unit(0.5, "cm"),
  legend.key.height = unit(0.5, "cm"),
  legend.text = element_text(size = 10),
  legend.title = element_text(size = 12),
  
  panel.background = element_rect(fill = "#d7ebf4"),
  panel.grid.major = element_line(color = "#e7d0c1", size = 0.8),
  panel.grid.major.x = element_line(color = "#e7d0c1", size = 0.8),
  panel.grid.minor = element_line(color = "#e7d0c1", size = 0.8),
  panel.grid.minor.x = element_line(color = "#e7d0c1", size = 0.8),

  axis.line = element_line(colour = "black", size = 0.5),
  axis.text = element_text(color = "#545454", size = 12),
  axis.text.x = element_text(angle = 0, vjust = 0.5)
)

2.5
Сделано ранее
panel.background = element_rect(fill = "#d7ebf4")

2.6
a <- theme(
  plot.title = element_text(
      size=25, 
      color = "blue", 
      face = "bold", 
      hjust = 0.5),
      
  legend.background = element_rect(
        fill = "lemonchiffon", 
        colour = "black", 
        size = 0.3),
  legend.key = element_rect(color = "green"),
  legend.key.width = unit(0.5, "cm"),
  legend.key.height = unit(0.5, "cm"),
  legend.text = element_text(size = 10),
  legend.title = element_text(size = 12),
  
  panel.background = element_rect(fill = "#d7ebf4"),
  panel.grid.major = element_line(color = "#e7d0c1", size = 0.8),
  panel.grid.major.x = element_line(color = "#e7d0c1", size = 0.8),
  panel.grid.minor = element_line(color = "#e7d0c1", size = 0.8),
  panel.grid.minor.x = element_line(color = "#e7d0c1", size = 0.8),

  axis.line = element_line(colour = "black", size = 0.5),
  axis.text = element_text(color = "#545454", size = 12),
  axis.text.x = element_text(angle = 0, vjust = 0.5),
  
  plot.background = element_rect(fill = "#e5e1cd", size= 2),
  plot.margin = margin(2, 30, 2, 2),
  aspect.ratio = 2 / 1
  
)
2.7
base  = ggplot(mtcars, aes(mpg, hp, color = factor(hp))) + geom_jitter() + geom_abline(colour = "grey50", size=2) + ggtitle("Заголовок")

a <- theme(
  plot.title = element_text(
      size=25, 
      color = "blue", 
      face = "bold", 
      hjust = 0.5),
      
  legend.background = element_rect(
        fill = "lemonchiffon", 
        colour = "black", 
        size = 0.3),
  legend.key = element_rect(color = "green"),
  legend.key.width = unit(0.5, "cm"),
  legend.key.height = unit(0.5, "cm"),
  legend.text = element_text(size = 10),
  legend.title = element_text(size = 12),
  
  panel.background = element_rect(fill = "#d7ebf4"),
  panel.grid.major = element_line(color = "#e7d0c1", size = 0.8),
  panel.grid.major.x = element_line(color = "#e7d0c1", size = 0.8),
  panel.grid.minor = element_line(color = "#e7d0c1", size = 0.8),
  panel.grid.minor.x = element_line(color = "#e7d0c1", size = 0.8),

  axis.line = element_line(colour = "black", size = 0.5),
  axis.text = element_text(color = "#545454", size = 12),
  axis.text.x = element_text(angle = 0, vjust = 0.5),
  
  plot.background = element_rect(fill = "#e5e1cd", size= 2),
  plot.margin = margin(2, 30, 2, 2),
  aspect.ratio = 2 / 1,
  
  strip.background = element_rect(fill="black", color="red", size = 1),
  strip.text = element_text(colour = "white")
)

base + facet_wrap(~cyl) + a

3.


4.
base  = ggplot(mtcars, aes(mpg, hp)) + geom_jitter() + geom_abline(colour = "grey50", size=2) + ggtitle("Заголовок")

4.1
base + facet_wrap(~carb, nrow = 3, ncol = 2, dir = "v") + a

4.2
base + facet_grid(carb~gear) + a

4.3
f + facet_wrap(~gear, scales = "free") + a

4.4
df <- data.frame( x = mtcars$mpg,y = mtcars$qsec,z = cut_number(mtcars$wt, 3))
ggplot(df, aes(x, y)) + geom_point(aes(colour = z)) + a 
ggplot(df, aes(x, y)) + geom_point() + facet_wrap(~z) + a


df_sum <- df %>% group_by(z) %>% summarise(x = mean(x), y = mean(y)) %>% rename(z2 = z)
ggplot(df, aes(x, y)) + geom_point() + geom_point(data = df_sum, aes(colour = z2), size = 4) + facet_wrap(~z) + a

df2 <- dplyr::select(df, -z)
ggplot(df, aes(x, y)) + geom_point(data = df2, colour = "grey70") + geom_point(aes(colour = z)) + facet_wrap(~z) + a

5.
pdf("output.pdf", width = 6, height = 6) 
ggplot(df, aes(x, y)) + geom_point(data = df2, colour = "grey70") + geom_point(aes(colour = z)) + facet_wrap(~z) + a 
dev.off() 

ggplot(df, aes(x, y)) + geom_point(data = df2, colour = "grey70") + geom_point(aes(colour = z)) + facet_wrap(~z) + t 
ggsave("output2.pdf")