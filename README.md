# Cloud Geography

[![NuGet Version](https://img.shields.io/nuget/v/AngryMonkey.Cloud.Geography.svg)](https://www.nuget.org/packages/AngryMonkey.Cloud.Geography/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/AngryMonkey.Cloud.Geography.svg)](https://www.nuget.org/packages/AngryMonkey.Cloud.Geography/)
[![Tests](https://img.shields.io/badge/tests-passing-brightgreen.svg)](https://github.com/angrymonkeycloud/CloudGeography)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-9%20%7C%2010-purple.svg)](https://dotnet.microsoft.com/)

## Summary
Cloud Geography is a .NET client library for geographic and financial data operations, including countries, currencies, languages, subdivisions, time zones, money, and international phone number parsing.

## Features
- Country lookup by 2-letter or 3-letter ISO code
- Country lookup by international calling code
- Currency lookup by code and country
- Language lookup by code and country
- Subdivision lookup by country and subdivision code
- Time zone lookup, conversion, and current time retrieval
- Money arithmetic helpers (add, subtract, decimal extraction)
- International phone number parsing (country code, calling code, local number)

## Quick Start
```cs
CloudGeographyClient client = new();

List<Country> countries = client.Countries.Get();
List<Currency> currencies = client.Currencies.Get();
List<Language> languages = client.Languages.Get();
```

## Installation

### Package Manager

```powershell
Install-Package AngryMonkey.Cloud.Geography
```

### .NET CLI

```bash
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

The following sections cover all supported API areas in `CloudGeographyClient`.

### Countries

#### Get all countries

```cs
List<Country> countries = client.Countries.Get();
```

#### Get a country by code

```cs
// 2-letter code
Country country = client.Countries.Get("US");

// 3-letter code
Country country = client.Countries.Get("USA");
```

#### Get multiple countries by code

```cs
// 2-letter codes
string[] twoLettersCountryCodes = ["CA", "US"];
List<Country> countries = client.Countries.Get(twoLettersCountryCodes);

// 3-letter codes
string[] threeLettersCountryCodes = ["CAN", "USA"];
List<Country> countries = client.Countries.Get(threeLettersCountryCodes);
```

#### Get countries by calling code

```cs
Country country = client.Countries.GetByCallingCode(1);
// returns USA and Canada because they share the same calling code
```

### Currencies

#### Get all currencies

```cs
List<Currency> currencies = client.Currencies.Get();
```

#### Get a currency by code

```cs
Currency currency = client.Currencies.Get("USD");
```

#### Get multiple currencies by code

```cs
string[] currencyCodes = ["AFN", "USD"];
List<Currency> currencies = client.Currencies.Get(currencyCodes);
```

#### Get currencies by country code

```cs
// 2-letter country code
List<CountryCurrency> currencies = client.Currencies.GetByCountry("US");

// 3-letter country code
List<CountryCurrency> currencies = client.Currencies.GetByCountry("USA");

// A country can have multiple currencies.
```


### Languages

#### Get all languages

```cs
List<Language> languages = client.Languages.Get();
```

#### Get languages by language codes

```cs
string[] languageCodes = ["EN", "FR"];
List<Language> languages = client.Languages.Get(languageCodes);
```

#### Get languages by country code

```cs
// 2-letter country code
List<CountryLanguage> languages = client.Languages.GetByCountry("US");

// 3-letter country code
List<CountryLanguage> languages = client.Languages.GetByCountry("USA");
```

#### Get a language by code

```cs
// 2-letter code
Language? language = client.Languages.Get("EN");

// 3-letter code
Language? language = client.Languages.Get("ENG");
```

### Subdivisions

#### Get all subdivisions by country code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US");
```

#### Get multiple subdivisions by country and subdivision codes

```cs
string[] subdivisionCodes = ["AL", "AK", "AZ"];
List<Subdivision> subdivisions = client.Subdivisions.Get("US", subdivisionCodes);
```

#### Get a subdivision by country and subdivision code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US", "AL");
```

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

### Money

#### Add money

```cs
// Positive addition
Money moneyA = new("USD", 1.2m);
Money moneyB = new("USD", 1.4m);
Money sum = moneyA.Add(moneyB); // 2.6m

// Negative addition
Money negativeA = new("USD", -1.2m);
Money negativeB = new("USD", -1.4m);
Money negativeSum = negativeA.Add(negativeB); // -2.6m
```

#### Subtract money

```cs
// Positive subtraction
Money moneyA = new("USD", 1.2m);
Money moneyB = new("USD", 1.4m);
Money difference = moneyA.Subtract(moneyB); // -0.2m

// Negative subtraction
Money negativeA = new("USD", -1.2m);
Money negativeB = new("USD", -1.4m);
Money negativeDifference = negativeA.Subtract(negativeB); // 0.2m
```

#### Get decimal part of money as an integer

```cs
// Positive number
Money money = new("USD", 50.3m);
int decimalPart = money.DecimalNumberAsInteger; // 3

// Negative number
Money negativeMoney = new("USD", -50.3m);
int negativeDecimalPart = negativeMoney.DecimalNumberAsInteger; // -3
```

### Phone Numbers

#### Get country code from an international phone number

```cs
PhoneNumber number = client.PhoneNumbers.Get("+16265895784");
string countryCode = number?.CountryCode;
// US
```

#### Get country calling code from an international phone number

```cs
PhoneNumber number = client.PhoneNumbers.Get("+16265895784");
string countryCallingCode = number?.CountryCallingCode;
// 1
```

#### Get local number from an international phone number

```cs
PhoneNumber number = client.PhoneNumbers.Get("+16265895784");
string localNumber = number?.Number;
// 6265895784
```
