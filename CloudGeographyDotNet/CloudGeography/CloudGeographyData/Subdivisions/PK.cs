using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPK()
    {
        AddSubdivisions("PK", new List<Subdivision>()
        {
            new(){ Code ="JK", LocalName="Azad Kashmir", Name="Azad Kashmir", Type="Area" },
            new(){ Code ="BA", LocalName="Balochistan", Name="Balochistan", Type="Province" },
            new(){ Code ="TA", LocalName="Federally Administered Tribal Areas", Name="Federally Administered Tribal Areas", Type="Territory" },
            new(){ Code ="GB", LocalName="Gilgit-Baltistan", Name="Gilgit-Baltistan", Type="Area" },
            new(){ Code ="IS", LocalName="Islamabad", Name="Islamabad", Type="Territory" },
            new(){ Code ="KP", LocalName="Khyber Pakhtunkhwa", Name="Khyber Pakhtunkhwa", Type="Province" },
            new(){ Code ="PB", LocalName="Punjab", Name="Punjab", Type="Province" },
            new(){ Code ="SD", LocalName="Sindh", Name="Sindh", Type="Province" }

        });
    }
}
