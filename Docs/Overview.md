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
