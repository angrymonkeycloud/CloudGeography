# Cloud Geography

 **IMPORTANT: Do not update this file directly, update files within the Docs folder and run Cloud Mate to generate this README.md file.**

<br/>

## Summary
A .Net client to retrieve Countries, Languages, and Currencies information.The .Net client is built on .Net Standard so it supports Windows, Windows Store, Windows Phone, Mono, and Xamarin, also it has implemented an integrated caching so developers don't have to. Backend API is deployed on Microsoft Azure latest technology services. .Net client and backend API are both built using best practices as lead developers would expect.


## Overview
```cs
 //gets all countries
 CloudGeographyClient client = new();
 List<Country> country = client.Countries.GetAll();
```

```cs
//gets all currencies
CloudGeographyClient client = new();
List<Currency> Currencies = client.Currencies.GetAll();
```

```cs
//gets all languages
CloudGeographyClient client = new();
List<Language> languages = client.Languages.GetAll();
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


#### Namespace

```cs     
using AngryMonkey.Cloud;
using AngryMonkey.Cloud.Geography;
```

#### Initialization

```cs
CloudGeographyClient cloudGeography = new CloudGeographyClient();
```

## Usage
 

### For Countries:
<br/>

#### Get all available countries

```cs
List<Country> countries = client.Countries.GetAll();
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
Country country = client.Countries.Get(1);
//returns USA and Canada because they share the same phone code
```

### For Currency:
<br>

#### Get all available currencies

```cs
List<Currency> Currencies = client.Currencies.GetAll();
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

<br/>

#### Get all available langugaes

```cs
List<Language> languages = client.Languages.GetAll();
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