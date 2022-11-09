### For Subdivisions:

#### Get all subdivisions by country code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US");
```

#### Get all subdivisions by country and subdivision code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US", new[] { "AL", "AK", "AZ" });
```

#### Get a subdivisions by country and subdivision code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US", "AL");
```