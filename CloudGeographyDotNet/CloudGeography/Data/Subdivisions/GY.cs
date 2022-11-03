using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGY()
    {
        AddSubdivisions("GY", new List<Subdivision>()
        {
            new(){ Code ="BA", LocalName="Barima-Waini", Name="Barima-Waini", Type="Region" },
            new(){ Code ="CU", LocalName="Cuyuni-Mazaruni", Name="Cuyuni-Mazaruni", Type="Region" },
            new(){ Code ="DE", LocalName="Demerara-Mahaica", Name="Demerara-Mahaica", Type="Region" },
            new(){ Code ="EB", LocalName="East Berbice-Corentyne", Name="East Berbice-Corentyne", Type="Region" },
            new(){ Code ="ES", LocalName="Essequibo Islands-West Demerara", Name="Essequibo Islands-West Demerara", Type="Region" },
            new(){ Code ="MA", LocalName="Mahaica-Berbice", Name="Mahaica-Berbice", Type="Region" },
            new(){ Code ="PM", LocalName="Pomeroon-Supenaam", Name="Pomeroon-Supenaam", Type="Region" },
            new(){ Code ="PT", LocalName="Potaro-Siparuni", Name="Potaro-Siparuni", Type="Region" },
            new(){ Code ="UD", LocalName="Upper Demerara-Berbice", Name="Upper Demerara-Berbice", Type="Region" },
            new(){ Code ="UT", LocalName="Upper Takutu-Upper Essequibo", Name="Upper Takutu-Upper Essequibo", Type="Region" }

        });
    }
}
