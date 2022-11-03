using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsFI()
    {
        AddSubdivisions("FI", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Ahvenanmaan maakunta", Name="Ahvenanmaan maakunta", Type="Region" },
            new(){ Code ="2", LocalName="Etelä-Karjala", Name="Etelä-Karjala", Type="Region" },
            new(){ Code ="3", LocalName="Etelä-Pohjanmaa", Name="Etelä-Pohjanmaa", Type="Region" },
            new(){ Code ="4", LocalName="Etelä-Savo", Name="Etelä-Savo", Type="Region" },
            new(){ Code ="5", LocalName="Kainuu", Name="Kainuu", Type="Region" },
            new(){ Code ="6", LocalName="Kanta-Häme", Name="Kanta-Häme", Type="Region" },
            new(){ Code ="7", LocalName="Keski-Pohjanmaa", Name="Keski-Pohjanmaa", Type="Region" },
            new(){ Code ="8", LocalName="Keski-Suomi", Name="Keski-Suomi", Type="Region" },
            new(){ Code ="9", LocalName="Kymenlaakso", Name="Kymenlaakso", Type="Region" },
            new(){ Code ="10", LocalName="Lappi", Name="Lappi", Type="Region" },
            new(){ Code ="16", LocalName="Päijät-Häme", Name="Päijät-Häme", Type="Region" },
            new(){ Code ="11", LocalName="Pirkanmaa", Name="Pirkanmaa", Type="Region" },
            new(){ Code ="12", LocalName="Pohjanmaa", Name="Pohjanmaa", Type="Region" },
            new(){ Code ="13", LocalName="Pohjois-Karjala", Name="Pohjois-Karjala", Type="Region" },
            new(){ Code ="14", LocalName="Pohjois-Pohjanmaa", Name="Pohjois-Pohjanmaa", Type="Region" },
            new(){ Code ="15", LocalName="Pohjois-Savo", Name="Pohjois-Savo", Type="Region" },
            new(){ Code ="17", LocalName="Satakunta", Name="Satakunta", Type="Region" },
            new(){ Code ="18", LocalName="Uusimaa", Name="Uusimaa", Type="Region" },
            new(){ Code ="19", LocalName="Varsinais-Suomi", Name="Varsinais-Suomi", Type="Region" }

        });
    }
}
