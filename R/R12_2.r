library(maps)
library(viridis)
library(dplyr)
library(ggplot2)

#task 2
# В датасете map_data("world") 99338 строк записей о границах суши,
# каждая из которых включает в себя информацию о координатах, названиях региона, id региона

#task 3
ggplot(map_data("world", region = "Russia"), aes(x = long, y = lat, group = group)) +
  geom_polygon(fill = "white", colour = "blue")
head(map_data("world", region = "Russia"))
#task 4
eu_countries <- c("Russia", "Ukraine", "France", "Spain", "Sweden", "Norway", "Germany", "Finland", "Poland", "Italy", "United Kingdom", "Romania", "Belarus", "Kazakhstan", "Greece", "Bulgaria", "Iceland", "Hungary", "Portugal", "Austria", "Czechia", "Serbia", "Ireland", "Lithuania", "Latvia", "Croatia", "Bosnia and Herzegovina", "Slovakia", "Estonia", "Denmark", "Switzerland", "Netherlands", "Moldova", "Belgium", "Armenia", "Albania", "North Macedonia", "Turkey", "Slovenia", "Montenegro", "Kosovo", "Cyprus", "Azerbaijan", "Luxembourg", "Georgia", "Andorra", "Malta", "Liechtenstein", "San Marino", "Monaco", "Vatican City")
map <- map_data("world", region = eu_countries)
regions <- map %>%
  group_by(region) %>%
  summarise(long = mean(long), lat = mean(lat))
ggplot(map, aes(x = long, y = lat)) +
  geom_polygon(aes(group = group, fill = region)) +
  geom_label(aes(label = region), data = regions) +
  scale_fill_viridis_d() +
  theme_void() +
  theme(legend.position = "hidden")

#task 5
arrests <- USArrests
arrests
arrests$region <- tolower(rownames(USArrests))
head(regions, 10)
head(arrests)

states_map <- map_data("state")
arrests_map <- left_join(states_map, arrests, by = tolower(rownames(USArrests)))
ggplot(arrests_map, aes(long, lat, group = group)) +
  geom_polygon(aes(fill = Murder), color = "white") +
  scale_fill_viridis_c(option = "C")
ggplot(arrests_map, aes(long, lat, group = group)) +
  geom_polygon(aes(fill = Assault), color = "black") +
  scale_fill_viridis_c(option = "C")
