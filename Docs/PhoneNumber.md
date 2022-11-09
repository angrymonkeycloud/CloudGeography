### For Phone Numbers:
---

#### Get The Country Code of an International Phone Number

```cs
PhoneNumber number = client.PhoneNumbers.Get("+16265895784");
string countryCode = number?.CountryCode;
//US
```
#### Get The Country Calling Code of an International Phone Number 

```cs
PhoneNumber number = client.PhoneNumbers.Get("+16265895784");
string countryCallingCode = number?.CountryCallingCode;
//1
```
#### Get The Local Phone Number of an International Phone Number

```cs
PhoneNumber number = client.PhoneNumbers.Get("+16265895784");
string countryCallingCode = number?.Number;
//6265895784
```