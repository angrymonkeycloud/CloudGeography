# Overview
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
