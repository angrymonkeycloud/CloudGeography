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
