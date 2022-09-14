## Usage


### For Countries:
---


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
---


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
---


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
