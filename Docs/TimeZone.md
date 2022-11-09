### For TimeZones:
---
#### Get all TimeZones


```cs
List<TimeZoneInfo> timeZones = client.TimeZones.Get();
```


#### Get TimeZones by TimeZone Codes


```cs
List<TimeZoneInfo> timeZones = client.TimeZones.Get(new[]{ "Hawaiian Standard Time", "Middle East Standard Time", "Greenland Standard Time" });
```


#### Get Current Time of a TimeZone by TimeZone Id


```cs
DateTime dateTime = client.TimeZones.GetDateTime("Eastern Standard Time");
```


#### Convert UTC Time to a TimeZone Time by TimeZone Id


```cs
DateTime convertedTime = client.TimeZones.GetDateTime(DateTime.Parse("2022-11-09 10:00:00 AM"), "Eastern Standard Time");
```

#### Convert Time from a TimeZone To Another TimeZone Time by TimeZone Ids


```cs
DateTime convertedTime = client.TimeZones.GetDateTime(DateTime.Parse("2022-11-08 12:00:00 PM"), "Middle East Standard Time", "Eastern Standard Time");
```
