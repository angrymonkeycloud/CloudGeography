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
