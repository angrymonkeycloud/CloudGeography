### For TimeZones:
---
#### Get all timeZones


```cs
List<TimeZoneInfo> timeZones = client.TimeZones.Get();
```


#### Get timeZones by timeZone codes


```cs
List<TimeZoneInfo> timeZones = client.TimeZones.Get(new[]{ "Hawaiian Standard Time", "Middle East Standard Time", "Greenland Standard Time" });
```


#### Get current time of a timeZone by timeZone id


```cs
DateTime dateTime = client.TimeZones.GetDateTime("Eastern Standard Time");
```

#### Get timezones by country code


```cs
List<CountryTimeZone> timeZones = client.TimeZones.GetByCountry("LB");
```


#### Convert UTC time to a timeZone time by timeZone id


```cs
DateTime convertedTime = client.TimeZones.GetDateTime(DateTime.Parse("2022-11-09 10:00:00 AM"), "Eastern Standard Time");
```

#### Convert time from a timeZone to another timeZone time by timeZone ids


```cs
DateTime convertedTime = client.TimeZones.GetDateTime(DateTime.Parse("2022-11-08 12:00:00 PM"), "Middle East Standard Time", "Eastern Standard Time");
```
