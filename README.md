# PicoPlacaPredictor

VB.NET implementation of Quito's "Pico & Placa" rules for cars on roads.



## Rule definition

Pico & Placa applies from 7:00 to 9:30 and from 16:00 to 19:30. Within these periods, certain cars are restricted to circulate in Quito. Thus:

- Cars whose license plate's last digit ends in 1 or 2 must adhere to Pico & Placa schedules on Mondays.
- Cars whose license plate's last digit ends in 3 or 4 must adhere to Pico & Placa schedules on Tuesdays.
- Cars whose license plate's last digit ends in 5 or 6 must adhere to Pico & Placa schedules on Wednesdays.
- Cars whose license plate's last digit ends in 7 or 8 must adhere to Pico & Placa schedules on Thursdays.
- Cars whose license plate's last digit ends in 9 or 0 must adhere to Pico & Placa schedules on Fridays.
- No Pico & Placa applies on Saturdays and Sundays.



## Code distribution

`PicoPlacaPredictor` contains the main classes.

`PicoPlacaPredictorTests` contains test classes.

`PicoPlacaPredictorConsole` contains the main application that instantiates objects of `PicoPlacaPredictor`'s classes. This application receives as inputs a license plate string and a date-time string and returns whether Pico & Placa applies to that license plate.

The license plate string must follow the pattern `XXX-000` or `XXX-0000`, where `X` should be replaced for any capital letter from `A` to `Z` and `0` should be replaced for any number from `0` to `9`.

The date-time string must follow the pattern `dd/MM/yyyy HH:mm`, where `dd` represents the day, `MM` represents the month, `yyyy` represents the year, `HH` represents an hour and `mm` represents the minutes.

The console output is as follows:

```
License plate (format: XXX-000 or XXX-0000): DZL-576
Date and time (format: dd/MM/yyyy HH:mm): 19/09/2018 08:36
DZL-576 is restricted to circulate in Quito on 19 September 2018 at 08:36.
```

```
License plate (format: XXX-000 or XXX-0000): DZL-576
Date and time (format: dd/MM/yyyy HH:mm): 19/09/2018 10:55
DZL-576 is not restricted to circulate in Quito on 19 September 2018 at 10:55.
```





