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

mean_with <- mean(with_pulumock_totals$Time_sec)
sd_with <- sd(with_pulumock_totals$Time_sec)

mean_without <- mean(without_pulumock_totals$Time_sec)
sd_without <- sd(without_pulumock_totals$Time_sec)

t_test <- t.test(with_pulumock_totals$Time_sec, without_pulumock_totals$Time_sec, paired = TRUE)

t_value <- t_test$statistic
df <- t_test$parameter
r <- sqrt(t_value^2/(t_value^2+df))

print(t_test)
cat("Effect size (r):", r, "\n")
cat("With Pulumock: Mean =", round(mean_with, 2), "SD =", round(sd_with, 2), "\n")
cat("Without Pulumock: Mean =", round(mean_without, 2), "SD =", round(sd_without, 2), "\n")


data_long <- rbind(
  data.frame(Participant = with_pulumock_totals$Participant,
             Condition = "With Pulumock",
             Time = with_pulumock_totals$Time_sec),
  data.frame(Participant = without_pulumock_totals$Participant,
             Condition = "Without Pulumock",
             Time = without_pulumock_totals$Time_sec)
)

data_long$Condition <- factor(data_long$Condition, levels = c("Without Pulumock", "With Pulumock"))
data_long$Participant <- factor(
  data_long$Participant,
  labels = paste0("P", 1:4)
)
labels_df <- data_long[data_long$Condition == "Without Pulumock", ]

ggplot(data_long, aes(x = Condition, y = Time, group = Participant)) +
  geom_line(aes(color = Participant), linewidth = 1) +
  geom_point(aes(color = Participant), size = 3) +
  geom_text(data = labels_df, aes(label = Participant), hjust = -0.2, family = "serif") +
  scale_color_manual(values = c("red", "blue", "green", "purple")) +  
  labs(
    title = "",
    y = "Time (seconds)",
    x = "Condition"
  ) +
  theme_minimal(base_family = "serif") +
  theme(
    legend.position = "none",
    axis.text = element_text(size = 13),
    axis.title = element_text(size = 15)
  )