using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBS()
    {
        AddSubdivisions("BS", new List<Subdivision>()
        {
            new(){ Code ="AK", LocalName="Acklins", Name="Acklins", Type="District" },
            new(){ Code ="BY", LocalName="Berry Islands", Name="Berry Islands", Type="District" },
            new(){ Code ="BI", LocalName="Bimini", Name="Bimini", Type="District" },
            new(){ Code ="BP", LocalName="Black Point", Name="Black Point", Type="District" },
            new(){ Code ="CI", LocalName="Cat Island", Name="Cat Island", Type="District" },
            new(){ Code ="CO", LocalName="Central Abaco", Name="Central Abaco", Type="District" },
            new(){ Code ="CS", LocalName="Central Andros", Name="Central Andros", Type="District" },
            new(){ Code ="CE", LocalName="Central Eleuthera", Name="Central Eleuthera", Type="District" },
            new(){ Code ="FP", LocalName="City of Freeport", Name="City of Freeport", Type="District" },
            new(){ Code ="CK", LocalName="Crooked Island and Long Cay", Name="Crooked Island and Long Cay", Type="District" },
            new(){ Code ="EG", LocalName="East Grand Bahama", Name="East Grand Bahama", Type="District" },
            new(){ Code ="EX", LocalName="Exuma", Name="Exuma", Type="District" },
            new(){ Code ="GC", LocalName="Grand Cay", Name="Grand Cay", Type="District" },
            new(){ Code ="HI", LocalName="Harbour Island", Name="Harbour Island", Type="District" },
            new(){ Code ="HT", LocalName="Hope Town", Name="Hope Town", Type="District" },
            new(){ Code ="IN", LocalName="Inagua", Name="Inagua", Type="District" },
            new(){ Code ="LI", LocalName="Long Island", Name="Long Island", Type="District" },
            new(){ Code ="MC", LocalName="Mangrove Cay", Name="Mangrove Cay", Type="District" },
            new(){ Code ="MG", LocalName="Mayaguana", Name="Mayaguana", Type="District" },
            new(){ Code ="MI", LocalName="Moore's Island", Name="Moore's Island", Type="District" },
            new(){ Code ="NO", LocalName="North Abaco", Name="North Abaco", Type="District" },
            new(){ Code ="NS", LocalName="North Andros", Name="North Andros", Type="District" },
            new(){ Code ="NE", LocalName="North Eleuthera", Name="North Eleuthera", Type="District" },
            new(){ Code ="RI", LocalName="Ragged Island", Name="Ragged Island", Type="District" },
            new(){ Code ="RC", LocalName="Rum Cay", Name="Rum Cay", Type="District" },
            new(){ Code ="SS", LocalName="San Salvador", Name="San Salvador", Type="District" },
            new(){ Code ="SO", LocalName="South Abaco", Name="South Abaco", Type="District" },
            new(){ Code ="SA", LocalName="South Andros", Name="South Andros", Type="District" },
            new(){ Code ="SE", LocalName="South Eleuthera", Name="South Eleuthera", Type="District" },
            new(){ Code ="SW", LocalName="Spanish Wells", Name="Spanish Wells", Type="District" },
            new(){ Code ="WG", LocalName="West Grand Bahama", Name="West Grand Bahama", Type="District" }

        });
    }
}
