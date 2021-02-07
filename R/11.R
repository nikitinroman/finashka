library(ggplot2)
 
2.1
base  = ggplot(mtcars, aes(wt, hp, color = factor(wt))) + geom_jitter() + ggtitle("Мощность к весу авто")

a <- theme(plot.title = element_text(size=17, color = "red", face = "bold", hjust = 0))

base + a

2.2
base  = ggplot(mtcars, aes(wt, hp, color = factor(wt))) + geom_jitter() + ggtitle("Мощность к весу авто")

a <- theme(
  plot.title = element_text(
      size=25, 
      color = "yellow", 
      face = "bold", 
      hjust = 0.5),
  legend.background = element_rect(
        fill = "pink", 
        colour = "black", 
        size = 0.3),
  legend.key = element_rect(color = "green"),
  legend.key.width = unit(0.5, "cm"),
  legend.key.height = unit(0.5, "cm"),
  legend.text = element_text(size = 5),
  legend.title = element_text(size = 5)
)
  
base + a

2.3
base  = ggplot(mtcars, aes(wt, hp, color = factor(wt))) + geom_jitter() + geom_abline(colour = "grey50", size=2) + ggtitle("Мощность к весу авто")

a <- theme(
  plot.title = element_text(
      size=25, 
      color = "red", 
      face = "bold", 
      hjust = 0.5),
      
  legend.background = element_rect(
        fill = "pink", 
        colour = "gold", 
        size = 0.3),
  legend.key = element_rect(color = "green"),
  legend.key.width = unit(0.5, "cm"),
  legend.key.height = unit(0.5, "cm"),
  legend.text = element_text(size = 5),
  legend.title = element_text(size = 5),
  
  panel.background = element_rect(fill = "gold"),
  panel.grid.major = element_line(color = "blue", size = 0.8),
  panel.grid.major.x = element_line(color = "grey", size = 0.8),
  panel.grid.minor = element_line(color = "green", size = 0.8),
  panel.grid.minor.x = element_line(color = "black", size = 0.8),

  axis.line = element_line(colour = "red", size = 1),
  axis.text = element_text(color = "black", size = 12)
)

base + a

2.4
base  = ggplot(mtcars, aes(wt, hp, color = factor(wt))) + geom_jitter() + geom_abline(colour = "grey50", size=2) + ggtitle("Мощность к весу авто")

a <- theme(
  plot.title = element_text(
    size=25, 
    color = "red", 
    face = "bold", 
    hjust = 0.5),
  
  legend.background = element_rect(
    fill = "pink", 
    colour = "gold", 
    size = 0.3),
  legend.key = element_rect(color = "green"),
  legend.key.width = unit(0.5, "cm"),
  legend.key.height = unit(0.5, "cm"),
  legend.text = element_text(size = 5),
  legend.title = element_text(size = 5),
  
  panel.background = element_rect(fill = "gold"),
  panel.grid.major = element_line(color = "blue", size = 0.8),
  panel.grid.major.x = element_line(color = "grey", size = 0.8),
  panel.grid.minor = element_line(color = "green", size = 0.8),
  panel.grid.minor.x = element_line(color = "black", size = 0.8),
  
  axis.line = element_line(colour = "red", size = 1),
  axis.text = element_text(color = "black", size = 12),
  axis.text.x = element_text(angle = 1, vjust = 1)
)

base + a


2.5
panel.background = element_rect(fill = "gold")

2.6
a <- theme(
  plot.title = element_text(
    size=25, 
    color = "red", 
    face = "bold", 
    hjust = 0.5),
  
  legend.background = element_rect(
    fill = "pink", 
    colour = "gold", 
    size = 0.3),
  legend.key = element_rect(color = "green"),
  legend.key.width = unit(0.5, "cm"),
  legend.key.height = unit(0.5, "cm"),
  legend.text = element_text(size = 5),
  legend.title = element_text(size = 5),
  
  panel.background = element_rect(fill = "gold"),
  panel.grid.major = element_line(color = "blue", size = 0.8),
  panel.grid.major.x = element_line(color = "grey", size = 0.8),
  panel.grid.minor = element_line(color = "green", size = 0.8),
  panel.grid.minor.x = element_line(color = "black", size = 0.8),
  
  axis.line = element_line(colour = "red", size = 1),
  axis.text = element_text(color = "black", size = 12),
  axis.text.x = element_text(angle = 1, vjust = 1),

  plot.background = element_rect(fill = "grey", size= 2),
  plot.margin = margin(2, 30, 2, 2),
  aspect.ratio = 2 / 1
)

base + a

2.7
a <- theme(
  plot.title = element_text(
    size=25, 
    color = "red", 
    face = "bold", 
    hjust = 0.5),
  
  legend.background = element_rect(
    fill = "pink", 
    colour = "gold", 
    size = 0.3),
  legend.key = element_rect(color = "green"),
  legend.key.width = unit(0.5, "cm"),
  legend.key.height = unit(0.5, "cm"),
  legend.text = element_text(size = 5),
  legend.title = element_text(size = 5),
  
  panel.background = element_rect(fill = "gold"),
  panel.grid.major = element_line(color = "blue", size = 0.8),
  panel.grid.major.x = element_line(color = "grey", size = 0.8),
  panel.grid.minor = element_line(color = "green", size = 0.8),
  panel.grid.minor.x = element_line(color = "black", size = 0.8),
  
  axis.line = element_line(colour = "red", size = 1),
  axis.text = element_text(color = "black", size = 12),
  axis.text.x = element_text(angle = 1, vjust = 1),
  
  plot.background = element_rect(fill = "grey", size= 2),
  plot.margin = margin(2, 30, 2, 2),
  aspect.ratio = 2 / 1
)
base + facet_wrap(~cyl) + a

4.
base  = ggplot(mtcars, aes(hp, wt)) + geom_jitter() + ggtitle("Мощность к весу авто")
base
4.1
base + facet_wrap(~carb, nrow = 3, ncol = 2, dir = "v") + a
base
4.2
base + facet_grid(carb~gear) + a

4.3
base + facet_wrap(~gear, scales = "free") + a
4.4
df <- data.frame( x = mtcars$mpg,y = mtcars$qsec,z = cut_number(mtcars$wt, 3))
ggplot(df, aes(x, y)) + geom_point(aes(colour = z)) + a 
ggplot(df, aes(x, y)) + geom_point() + facet_wrap(~z) + a


df_sum <- df %>% group_by(z) %>% summarise(x = mean(x), y = mean(y)) %>% rename(z2 = z)
ggplot(df, aes(x, y)) + geom_point() + geom_point(data = df_sum, aes(colour = z2), size = 4) + facet_wrap(~z) + a

df2 <- dplyr::select(df, -z)
ggplot(df, aes(x, y)) + geom_point(data = df2, colour = "grey") + geom_point(aes(colour = z)) + facet_wrap(~z) + a

5.
pdf("output.pdf", width = 6, height = 6) 
ggplot(df, aes(x, y)) + geom_point(data = df2, colour = "grey") + geom_point(aes(colour = z)) + facet_wrap(~z) + a 
dev.off() 

ggplot(df, aes(x, y)) + geom_point(data = df2, colour = "grey") + geom_point(aes(colour = z)) + facet_wrap(~z) + a 
ggsave("output2.pdf")


