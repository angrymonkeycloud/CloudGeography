### For Subdivisions:

#### Get All Subdivisions by Country Code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US");
```

#### Get All Subdivisions by Country And Subdivision Code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US", new[] { "AL", "AK", "AZ" });
```

#### Get a Subdivisions by Country And Subdivision Code

```cs
List<Subdivision> subdivisions = client.Subdivisions.Get("US", "AL");
```