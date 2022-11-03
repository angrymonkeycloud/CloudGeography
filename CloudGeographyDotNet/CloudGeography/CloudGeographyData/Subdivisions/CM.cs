using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCM()
    {
        AddSubdivisions("CM", new List<Subdivision>()
        {
            new(){ Code ="AD", LocalName="Adamaoua", Name="Adamaoua", Type="Region" },
            new(){ Code ="CE", LocalName="Centre", Name="Centre", Type="Region" },
            new(){ Code ="ES", LocalName="East", Name="East", Type="Region" },
            new(){ Code ="EN", LocalName="Far North", Name="Far North", Type="Region" },
            new(){ Code ="LT", LocalName="Littoral", Name="Littoral", Type="Region" },
            new(){ Code ="NO", LocalName="North", Name="North", Type="Region" },
            new(){ Code ="NW", LocalName="North-West", Name="North-West", Type="Region" },
            new(){ Code ="SU", LocalName="South", Name="South", Type="Region" },
            new(){ Code ="SW", LocalName="South-West", Name="South-West", Type="Region" },
            new(){ Code ="OU", LocalName="West", Name="West", Type="Region" }

        });
    }
}
