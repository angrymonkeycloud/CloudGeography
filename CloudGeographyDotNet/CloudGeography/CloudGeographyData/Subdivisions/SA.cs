using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsSA()
    {
        AddSubdivisions("SA", new List<Subdivision>()
        {
            new(){ Code ="11", LocalName="AI Bahah", Name="AI Bahah", Type="Province" },
            new(){ Code ="8", LocalName="AI Hudud ash Shamaliyah", Name="AI Hudud ash Shamaliyah", Type="Province" },
            new(){ Code ="12", LocalName="AI Jawf", Name="AI Jawf", Type="Province" },
            new(){ Code ="5", LocalName="AI Qasim", Name="AI Qasim", Type="Province" },
            new(){ Code ="3", LocalName="Al Madinah al Munawwarah", Name="Al Madinah al Munawwarah", Type="Province" },
            new(){ Code ="1", LocalName="Ar Riyad", Name="Ar Riyad", Type="Province" },
            new(){ Code ="4", LocalName="Ash Sharqiyah", Name="Ash Sharqiyah", Type="Province" },
            new(){ Code ="14", LocalName="'Asir", Name="'Asir", Type="Province" },
            new(){ Code ="6", LocalName="Ha'il", Name="Ha'il", Type="Province" },
            new(){ Code ="9", LocalName="Jazan", Name="Jazan", Type="Province" },
            new(){ Code ="2", LocalName="Makkah al Mukarramah", Name="Makkah al Mukarramah", Type="Province" },
            new(){ Code ="10", LocalName="Najran", Name="Najran", Type="Province" },
            new(){ Code ="7", LocalName="Tabuk", Name="Tabuk", Type="Province" }

        });
    }
}
