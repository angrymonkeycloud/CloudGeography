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
