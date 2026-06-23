### Time Zones

#### Get all time zones

```cs
List<TimeZoneInfo> timeZones = client.TimeZones.Get();
```

#### Get time zones by IDs

```cs
string[] timeZoneIds = ["Hawaiian Standard Time", "Middle East Standard Time", "Greenland Standard Time"];
List<TimeZoneInfo> timeZones = client.TimeZones.Get(timeZoneIds);
```

#### Get time zones by country code

```cs
List<CountryTimeZone> timeZones = client.TimeZones.GetByCountry("LB");
```

#### Get current time in a time zone

```cs
string toTimeZone = "Eastern Standard Time";
DateTime convertedTime = client.TimeZones.GetTime(toTimeZone);
```

#### Convert UTC to a time zone

```cs
string toTimeZone = "Eastern Standard Time";
DateTime utcTime = DateTime.Parse("2022-11-09 10:00:00 AM");
DateTime convertedTime = client.TimeZones.GetTime(toTimeZone, utcTime);
```

#### Convert between time zones

```cs
string toTimeZone = "Afghanistan Standard Time";
string fromTimeZone = "Middle East Standard Time";
DateTime timeToConvert = DateTime.Parse("2022-11-08 12:00:00 PM");
DateTime convertedTime = client.TimeZones.GetTime(toTimeZone, timeToConvert, fromTimeZone);
```
