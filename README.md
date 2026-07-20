# Cloud Geography

> **📦 New Package**: This library is now available as **`AngryMonkey.CloudGeography`** on NuGet. This is the recommended package going forward with enhanced features, better performance, and comprehensive test coverage.

[![Website](https://img.shields.io/badge/Website-angrymonkeycloud.com-0B5FFF?style=flat-square&logo=googlechrome&logoColor=white)](https://angrymonkeycloud.com/cloudgeography)
[![GitHub repository](https://img.shields.io/badge/GitHub-CloudGeography-181717?style=flat-square&logo=github)](https://github.com/angrymonkeycloud/CloudGeography)
[![NuGet](https://img.shields.io/nuget/v/AngryMonkey.CloudGeography?style=flat-square&logo=nuget)](https://www.nuget.org/packages/AngryMonkey.CloudGeography/)
[![NuGet downloads](https://img.shields.io/nuget/dt/AngryMonkey.CloudGeography?style=flat-square&logo=nuget)](https://www.nuget.org/packages/AngryMonkey.CloudGeography/)
[![Tests](https://img.shields.io/badge/tests-passing-brightgreen.svg)](https://github.com/angrymonkeycloud/CloudGeography)
[![.NET](https://img.shields.io/badge/.NET-9%20%7C%2010-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-2F855A?style=flat-square)](LICENSE)

[![Legacy Package Downloads](https://img.shields.io/badge/legacy_downloads-23.5K+-gray?style=flat-square&logo=nuget)](https://www.nuget.org/packages/AngryMonkey.Cloud.Geography/)

## Summary
Cloud Geography is a .NET client library for geographic and financial data operations, including countries, currencies, languages, subdivisions, time zones, money, and international phone number parsing.

**Migration Note**: If you're using the legacy `AngryMonkey.Cloud.Geography` package, we recommend upgrading to `AngryMonkey.CloudGeography` for access to the latest features, including flexible country/currency/language search by name with alternative names support, and enhanced subdivision search with fuzzy matching.

## Features
- Country lookup by code, name, alternative names, or calling code
- Country lookup by coordinates (requires Azure Maps API key)
- Country lookup by IP address (requires Azure Maps API key)
- Country guessing from phone numbers
- Currency lookup by code, name, or country
- Language lookup by code, name, or country
- Subdivision lookup by country code, name, or hierarchical queries
- Subdivision search with fuzzy matching and Arabic transliteration support
- Time zone lookup, conversion, and current time retrieval
- Money arithmetic helpers (add, subtract, decimal extraction)
- International phone number parsing and validation (country code, calling code, local number)

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
Install-Package AngryMonkey.CloudGeography
```

### .NET CLI

```bash
dotnet add package AngryMonkey.CloudGeography
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

#### Find a country by name

```cs
// Find by full name, short name, local name, or common alternative names
Country? country = client.Countries.Find("United States");
Country? country = client.Countries.Find("America");
Country? country = client.Countries.Find("Deutschland"); // Germany in German
Country? country = client.Countries.Find("لبنان"); // Lebanon in Arabic
Country? country = client.Countries.Find("UK"); // Alternative name for Great Britain
```

#### Find all countries matching a query

```cs
List<Country> countries = client.Countries.FindAll("Korea");
// returns all countries matching "Korea"
```

#### Guess country from phone number

```cs
Country? country = client.Countries.GuessCountryByPhoneNumber("+16265895784");
// US

Country? country = client.Countries.GuessCountryByPhoneNumber("+14185895784");
// CA (Canadian area code)
```

#### Get country by coordinates (requires Azure Maps API key)

```cs
CloudGeographyConfig config = new() { AzureMapsKey = "your-api-key" };
CloudGeographyClient client = new(config);

Coordinate coordinate = new(33.8464, 35.5343); // Lebanon coordinates
Country? country = await client.Countries.GetByCoordinates(coordinate);
```

#### Get country by IP address (requires Azure Maps API key)

```cs
CloudGeographyConfig config = new() { AzureMapsKey = "your-api-key" };
CloudGeographyClient client = new(config);

Country? country = await client.Countries.GetByIP("178.135.2.147");
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

#### Find a currency by name

```cs
// Find by full name, short name, native name, or code
Currency? currency = client.Currencies.Find("United States Dollar");
Currency? currency = client.Currencies.Find("US Dollar");
Currency? currency = client.Currencies.Find("US Dollars");
Currency? currency = client.Currencies.Find("Euro");
Currency? currency = client.Currencies.Find("Lebanese pounds"); // plural form
```

#### Find all currencies matching a query

```cs
List<Currency> currencies = client.Currencies.FindAll("Dollar");
// returns all currencies matching "Dollar"
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

#### Find a language by name

```cs
// Find by English name, native name, or code
Language? language = client.Languages.Find("English");
Language? language = client.Languages.Find("French");
Language? language = client.Languages.Find("العربية"); // Arabic in Arabic script
Language? language = client.Languages.Find("日本語"); // Japanese in Japanese
Language? language = client.Languages.Find("español"); // Spanish in Spanish
```

#### Find all languages matching a query

```cs
List<Language> languages = client.Languages.FindAll("Arabic");
// returns all languages matching "Arabic"
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
Subdivision? subdivision = client.Subdivisions.Get("US", "AL");
```

#### Get child subdivisions

```cs
// Get all children of a subdivision (for hierarchical subdivisions)
List<Subdivision>? children = client.Subdivisions.GetChildren("LB", "BA");

// Get a specific child subdivision
Subdivision? child = client.Subdivisions.GetChild("LB", "BA", "BAS");
```

#### Get all subdivisions (flattened)

```cs
// Returns all subdivisions at all hierarchy levels as a flat list
List<Subdivision> allSubdivisions = client.Subdivisions.GetAll("US");
```

#### Find a subdivision by name

```cs
// Find by code or name (English or local language)
Subdivision? subdivision = client.Subdivisions.Find("US", "California");
Subdivision? subdivision = client.Subdivisions.Find("LB", "Mount Lebanon");
Subdivision? subdivision = client.Subdivisions.Find("LB", "جبل لبنان"); // Arabic
Subdivision? subdivision = client.Subdivisions.Find("LB", "Matn"); // Alternative spelling of Matn
```

#### Find all subdivisions matching a query

```cs
List<Subdivision> subdivisions = client.Subdivisions.FindAll("US", "New");
// returns all subdivisions matching "New" (e.g., New York, New Mexico, New Hampshire)
```

#### Advanced subdivision search

```cs
// Rich search with multi-part queries, fuzzy matching, and Arabic transliteration
SubdivisionSearchRequest request = new()
{
    Query = "Mount Lebanon",
    CountryCode = "LB"
};
SubdivisionSearchResult? result = client.Subdivisions.Search(request);

// Search across all countries (returns highest scoring match)
SubdivisionSearchRequest globalRequest = new()
{
    Query = "California"
};
SubdivisionSearchResult? result = client.Subdivisions.Search(globalRequest);

// Search with parent subdivision constraint
SubdivisionSearchRequest hierarchyRequest = new()
{
    Query = "Beirut",
    CountryCode = "LB",
    ParentSubdivisionCode = "BA" // Must be child of Beirut Amiounieh
};
SubdivisionSearchResult? result = client.Subdivisions.Search(hierarchyRequest);
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

#### Validate phone number

```cs
bool isValid = client.PhoneNumbers.IsValidPhoneNumber("+16265895784");
// true

bool isValid = client.PhoneNumbers.IsValidPhoneNumber("invalid");
// false
```

---

## Angry Monkey Cloud

This project is part of the [Angry Monkey Cloud](https://angrymonkeycloud.com) open-source ecosystem. Follow the shared [AI development instructions](https://github.com/angrymonkeycloud/CloudDocs/blob/main/docs/ai/instructions.md) and browse the [project catalog](https://angrymonkeycloud.com) and [GitHub organization](https://github.com/angrymonkeycloud).
