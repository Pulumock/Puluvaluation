# Developer Productivity

This section evaluates developer productivity through a within-subjects study. Each participant completed the same set of tasks under two different conditions: using Pulumock and using the standard Pulumi testing setup. Task completion times (in seconds) were collected and analyzed using statistical methods, including a Shapiro-Wilk normality test and a paired t-test.

## Install packages

1. Start R console: `R`
2. Install packages: 
    ```shell
    install.packages("dplyr")
    install.packages("ggplot2")
    ```
3. Exit R console: `q()` (Save workspace image if prompted)

## Execute Shapiro-Wilk normality test

The Shapiro-Wilk test is used to determine whether the difference scores (i.e., time with vs. without Pulumock per participant) follow a normal distribution, an assumption for the paired t-test.

Run the test:
```shell
Rscript Normality/Normality.R
```

This script will also output a [Q–Q plot](Normality/Normality_Q-Q_plot.pdf) visualizing the distribution of difference scores.

## Execute Paired t-test

A paired t-test is used to assess whether the task times differ significantly between the two conditions. It accounts for repeated measures by comparing matched pairs of observations (i.e., the same participant under each condition).

Run the test:
```shell
Rscript PairedT.R
```

The script also produces a [paired line plot](Paired_TaskTime_plot.pdf) that illustrates the individual task times per participant under each condition.