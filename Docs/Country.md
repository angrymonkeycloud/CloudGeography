### For Countries:
---


#### Get all available countries


```cs
List<Country> countries = client.Countries.Get();
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
Country country = client.Countries.GetByCallingCode(1);
//returns USA and Canada because they share the same phone code
```
