# Cloud Geography

** IMPORTANT: Do not update this file directly, update files within the Docs folder and run Cloud Mate to generate this README.md file. **
## Summary
A .Net client to retrieve Countries, Languages, and Currencies information.The .Net client is built on .Net Standard so it supports Windows, Windows Store, Windows Phone, Mono, and Xamarin, also it has implemented an integrated caching so developers don't have to. Backend API is deployed on Microsoft Azure latest technology services. .Net client and backend API are both built using best practices as lead developers would expect.



## Code Sample
```cs
 //gets all countries
 CloudGeographyClient client = new();
 List<Country> country = client.Countries.Get();
```

```cs
//gets all currencies
CloudGeographyClient client = new();
List<Currency> Currencies = client.Currencies.Get();
```

```cs
//gets all languages
CloudGeographyClient client = new();
List<Language> languages = client.Languages.Get();
```

## Installation

### Package Manager

```batch
Install-Package AngryMonkey.Cloud.Geography
```

### .Net CLI
```
dotnet add package AngryMonkey.Cloud.Geography 
```


## Implementation


### Namespace

```cs     
using AngryMonkey.Cloud;
using AngryMonkey.Cloud.Geography;
```

### Initialization

```cs
CloudGeographyClient cloudGeography = new CloudGeographyClient();
```


## Usage


### For Countries:
---


#### Get all available countries


```cs
List<Country> countries = client.Countries.Get();
```


#### Get a country by its code


 ```cs
 // by 2 letters code
Country country = client.Countries.Get("US");

// by 3 letters code
Country country = client.Countries.Get("USA");
```


#### Get multiple countries by their code


```cs
//by 2 letters code
List<Country> countries = client.Countries.Get(new[] {"CA", "US"});

//by 3 letters code
List<Country> countries = client.Countries.Get(new[] {"CAN", "USA"});
```



#### Get a country by its phone code


 ```cs
Country country = client.Countries.GetByCallingCode(1);
//returns USA and Canada because they share the same phone code
```

### For Currency:
---


#### Get all available currencies


```cs
List<Currency> Currencies = client.Currencies.Get();
```


#### Get a currecny from its code


 ```cs
Currency Currency = client.Currencies.Get("USD");
```


#### Get multiple currencies from currency codes


```cs
List<Currency> Currencies = client.Currencies.Get(new[] { "AFN", "USD" });
```


#### Get  multiple currencies from country code


 ```cs
 // by 2 letter country code
List<CountryCurrency> Currencies = client.Currencies.GetByCountry("US");

 // by 3 letter country code
List<CountryCurrency> Currencies = client.Currencies.GetByCountry("USA");

//Note: A country can have multiple currencies
```


### For Language:
---


#### Get all available langugaes


```cs
List<Language> languages = client.Languages.Get();
```


#### Get languages by language codes


```cs
List<Language> languages = client.Languages.Get(new[]{"USA","CA"});
```


#### Get languages by country code


```cs
//by 2 letters code
List<CountryLanguage> languages = client.Languages.GetByCountry("US");

//by 3 letters code
List<CountryLanguage> languages = client.Languages.GetByCountry("USA");
```


#### Get language by language code


 ```cs
 //by 2 letter code
Language ?language = client.Languages.Get("EN");

//by 3 letter code
Language? language = client.Languages.Get("ENG");
```
### For Subdivisions:

#### Get All Subdivisions by Country Code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US");
```

#### Get All Subdivisions by Country And Subdivision Code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US", new[] { "AL", "AK", "AZ" });
```

#### Get a Subdivisions by Country And Subdivision Code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US", "AL");
```


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

### For Money:
---
#### Add Money


```cs
//Positive Addition
Money moneyA = new("USD", 1.2m);
Money moneyB = new("USD", 1.4m);
//2.6m
Money sum = moneyA.Add(moneyB); 

//Negatice Addition
Money moneyA = new("USD", -1.2m);
Money moneyB = new("USD", -1.4m);
//-2.6m
Money sum = moneyA.Add(moneyB);
```


#### Subtract Money


```cs
//Positive Subtraction
Money moneyA = new("USD", 1.2m);
Money moneyB = new("USD", 1.4m);
//-.2m
Money sum = moneyA.Subtract(moneyB); 

//Negatice Subtraction
Money moneyA = new("USD", -1.2m);
Money moneyB = new("USD", -1.4m);
//.2m
Money sum = moneyA.Subtract(moneyB);
```

#### Get Decimal Part of the Money As Integer

```cs
//Positive Number
Money money = new("USD", 50.3m);
int decimalPart = money.DecimalNumberAsInteger;
// decimalPart = 3

//Negative Number
Money money = new("USD", -50.3m);
int decimalPart = money.DecimalNumberAsInteger;
// decimalPart = -3
```

### For Phone Numbers:
---

#### Get The Country Code of an International Phone Number

```cs
PhoneNumber number = client.PhoneNumbers.Get("+16265895784");
string countryCode = number?.CountryCode;
//US
```
#### Get The Country Calling Code of an International Phone Number 

```cs
PhoneNumber number = client.PhoneNumbers.Get("+16265895784");
string countryCallingCode = number?.CountryCallingCode;
//1
```
#### Get The Local Phone Number of an International Phone Number

```cs
PhoneNumber number = client.PhoneNumbers.Get("+16265895784");
string countryCallingCode = number?.Number;
//6265895784
```