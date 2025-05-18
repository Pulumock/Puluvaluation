library(dplyr)
library(ggplot2)

with_pulumock <- read.csv("TaskCompletionTimes_WithPulumock.csv")
without_pulumock <- read.csv("TaskCompletionTimes_WithoutPulumock.csv")

with_pulumock_totals <- with_pulumock %>%
  group_by(Participant) %>%
  summarise(Time_sec = sum(Time))

without_pulumock_totals <- without_pulumock %>%
  group_by(Participant) %>%
  summarise(Time_sec = sum(Time))

differences <- with_pulumock_totals$Time_sec - without_pulumock_totals$Time_sec
shapiro.test(differences)

qqnorm(differences,
       main = "",
       xlab = "Theoretical Quantiles",
       ylab = "Observed Differences",
       cex.axis = 1.2,
       cex.lab = 1.5,
       family = "serif")
qqline(differences, col = "red", lwd = 2)
