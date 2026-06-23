### Subdivisions

#### Get all subdivisions by country code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US");
```

#### Get multiple subdivisions by country and subdivision codes

```cs
string[] subdivisionCodes = ["AL", "AK", "AZ"];
List<Subdivision> subdivisions = client.Subdivisions.Get("US", subdivisionCodes);
```

#### Get a subdivision by country and subdivision code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US", "AL");
```
