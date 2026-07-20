# Copilot Instructions

For general AI-assisted development guidance that applies to this repository as a whole, see:

- [AI Instructions](https://github.com/angrymonkeycloud/CloudDocs/blob/main/docs/ai/instructions.md)

## Project Overview
Cloud Geography is a .NET library (`AngryMonkey.Cloud.Geography`, targets net9.0) exposing geographic data — countries, currencies, languages, subdivisions, time zones, money arithmetic, and phone number parsing — through a single `CloudGeographyClient` entry point. All data is stored as static C# initializers (no runtime JSON loading), except for the optional Azure Maps coordinate-to-country lookup.

## Solution Layout
| Project | Role |
|---|---|
| `CloudGeography/` | Main library (net9.0) |
| `CloudGeography.Test/` | MSTest suite (net10.0) |
| `CloudGeography.Packing/` | NuGet packaging + README generation via CloudMate |

## Architecture: Partial Class Pattern
`CloudGeographyClient` is a `partial class` spread across many files:
- `Methods.cs` — constructor, public property declarations for each domain group
- `*Methods.cs` — one file per domain (e.g. `SubdivisionsMethods.cs`), each a nested `partial class`
- `Data/Countries.cs`, `Data/Currencies.cs`, `Data/Languages.cs` — large static list initializers
- `Data/Subdivisions.cs` — lazy `Dictionary<string, List<Subdivision>>`, calls individual `FillInSubdivisionsXX()` methods
- `Data/Subdivisions/XX.cs` — one file per country (2-letter ISO uppercase), each containing exactly one `private static void FillInSubdivisionsXX()` method

Namespaces: client lives in `AngryMonkey.Cloud`; data contracts live in `AngryMonkey.Cloud.Geography`.

## Adding or Updating a Country's Subdivisions
1. Create `Data/Subdivisions/XX.cs` (uppercase 2-letter ISO code) following this structure:
   ```cs
   using AngryMonkey.Cloud.Geography;
   namespace AngryMonkey.Cloud;
   public partial class CloudGeographyClient
   {
       private static void FillInSubdivisionsXX()
       {
           AddSubdivisions("XX",
           [
               new()
               {
                   Code = "AB",
                   Type = SubdivisionTypes.Governorate,
                   Name = "Name",
                   LocalName = "LocalName",
                   Children = [ new() { Code = "CD", Type = SubdivisionTypes.District, Name = "Child", LocalName = "Child" } ]
               }
           ]);
       }
   }
   ```
2. Register it in `Data/Subdivisions.cs` — add `FillInSubdivisionsXX();` inside the `SubdivisionsList` getter (alphabetical order is the convention).

## Key Conventions
- **Enum names are plural**: `SubdivisionTypes` (not `SubdivisionType`). All values are in `DataContract/SubdivisionTypes.cs`; use existing members before adding new ones.
- **Hierarchical subdivisions**: top-level entries = parent level (e.g. Governorate); set `Children` for deeper levels (e.g. District). Only one nesting level is used in practice.
- **Country code normalization**: `CodeCheck()` upper-cases and trims input; `"UK"` is silently aliased to `"GB"`.
- **Money**: stored internally as `Units` + `Nanos` (factor `1_000_000_000`). Use the `decimal` constructor — it handles conversion automatically.
- **Azure Maps**: coordinate lookup requires `CloudGeographyConfig { AzureMapsKey }`. Tests that use it read the key from user secrets — set via `dotnet user-secrets set "AzureMapsKey" "<key>"` in `CloudGeography.Test/`.

## Running Tests
```powershell
dotnet test CloudGeography.Test/CloudGeography.Test.csproj
```
Tests that call `GetByCoordinates` require the `AzureMapsKey` user secret; all other tests are fully offline.

## README / Docs Workflow
- **Do not edit `README.md` directly.** Edit the source files in `Docs/` (e.g. `Docs/Country.md`, `Docs/Subdivision.md`).
- Regenerate by running `dotnet run` inside `CloudGeography.Packing/` (requires `appconfig.json` with `NuGetApiKey` and correct working directory).

## Project Guidelines
- Enum class names must be in plural form (e.g., `SubdivisionTypes` not `SubdivisionType`).