## Usage
<br/>

### For Countries:
---
<br/>

#### Get all available countries
<br/>

```cs
List<Country> countries = client.Countries.GetAll();
```
<br/>

#### Get a country by its code
<br/>

 ```cs
 // by 2 letters code
Country country = client.Countries.Get("US");

// by 3 letters code
Country country = client.Countries.Get("USA");
```
<br/>

#### Get multiple countries by their code
<br/>

```cs
//by 2 letters code
List<Country> countries = client.Countries.Get(new[] {"CA", "US"});

//by 3 letters code
List<Country> countries = client.Countries.Get(new[] {"CAN", "USA"});
```
<br/>


#### Get a country by its phone code
<br/>

 ```cs
Country country = client.Countries.Get(1);
//returns USA and Canada because they share the same phone code
```

### For Currency:
---
<br/>

#### Get all available currencies
<br/>

```cs
List<Currency> Currencies = client.Currencies.GetAll();
```
<br/>

#### Get a currecny from its code
<br/>

 ```cs
Currency Currency = client.Currencies.Get("USD");
```
<br/>

#### Get multiple currencies from currency codes
<br/>

```cs
List<Currency> Currencies = client.Currencies.Get(new[] { "AFN", "USD" });
```
<br/>

#### Get  multiple currencies from country code
<br/>

 ```cs
 // by 2 letter country code
List<CountryCurrency> Currencies = client.Currencies.GetByCountry("US");

 // by 3 letter country code
List<CountryCurrency> Currencies = client.Currencies.GetByCountry("USA");

//Note: A country can have multiple currencies
```
<br/>

### For Language:
---
<br/>

#### Get all available langugaes
<br/>

```cs
List<Language> languages = client.Languages.GetAll();
```
<br/>

#### Get languages by language codes
<br/>

```cs
List<Language> languages = client.Languages.Get(new[]{"USA","CA"});
```
<br/>

#### Get languages by country code
<br/>

```cs
//by 2 letters code
List<CountryLanguage> languages = client.Languages.GetByCountry("US");

//by 3 letters code
List<CountryLanguage> languages = client.Languages.GetByCountry("USA");
```
<br/>

#### Get language by language code
<br/>

 ```cs
 //by 2 letter code
Language ?language = client.Languages.Get("EN");

//by 3 letter code
Language? language = client.Languages.Get("ENG");
```
