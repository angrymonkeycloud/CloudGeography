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

