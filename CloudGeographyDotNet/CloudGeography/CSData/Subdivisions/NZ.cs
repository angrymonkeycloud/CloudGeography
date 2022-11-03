using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNZ()
    {
        AddSubdivisions("NZ", new List<Subdivision>()
        {
            new(){ Code ="AUK", LocalName="Auckland", Name="Auckland", Type="Region" },
            new(){ Code ="BOP", LocalName="Bay of Plenty", Name="Bay of Plenty", Type="Region" },
            new(){ Code ="CAN", LocalName="Canterbury", Name="Canterbury", Type="Region" },
            new(){ Code ="CIT", LocalName="Chatham Islands Territory", Name="Chatham Islands Territory", Type="Island" },
            new(){ Code ="GIS", LocalName="Gisborne", Name="Gisborne", Type="Region" },
            new(){ Code ="HKB", LocalName="Hawkes's Bay", Name="Hawkes's Bay", Type="Region" },
            new(){ Code ="MWT", LocalName="Manawatu-Wanganui", Name="Manawatu-Wanganui", Type="Region" },
            new(){ Code ="MBH", LocalName="Marlborough", Name="Marlborough", Type="Region" },
            new(){ Code ="NSN", LocalName="Nelson", Name="Nelson", Type="Region" },
            new(){ Code ="NTL", LocalName="Northland", Name="Northland", Type="Region" },
            new(){ Code ="OTA", LocalName="Otago", Name="Otago", Type="Region" },
            new(){ Code ="STL", LocalName="Southland", Name="Southland", Type="Region" },
            new(){ Code ="TKI", LocalName="Taranaki", Name="Taranaki", Type="Region" },
            new(){ Code ="TAS", LocalName="Tasman", Name="Tasman", Type="Region" },
            new(){ Code ="WKO", LocalName="Waikato", Name="Waikato", Type="Region" },
            new(){ Code ="WGN", LocalName="Wellington", Name="Wellington", Type="Region" },
            new(){ Code ="WTC", LocalName="West Coast", Name="West Coast", Type="Region" }

        });
    }
}
