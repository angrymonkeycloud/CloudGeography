using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsPS()
    {
        AddSubdivisions("PS", new List<Subdivision>()
        {
            new(){ Code ="BTH", LocalName="Bethlehem", Name="Bethlehem", Type="Governorate" },
            new(){ Code ="DEB", LocalName="Deir El Balah", Name="Deir El Balah", Type="Governorate" },
            new(){ Code ="GZA", LocalName="Gaza", Name="Gaza", Type="Governorate" },
            new(){ Code ="HBN", LocalName="Hebron", Name="Hebron", Type="Governorate" },
            new(){ Code ="JRH", LocalName="Jericho and Al Aghwar", Name="Jericho and Al Aghwar", Type="Governorate" },
            new(){ Code ="JEM", LocalName="Jerusalem", Name="Jerusalem", Type="Governorate" },
            new(){ Code ="KYS", LocalName="Khan Yunis", Name="Khan Yunis", Type="Governorate" },
            new(){ Code ="NBS", LocalName="Nablus", Name="Nablus", Type="Governorate" },
            new(){ Code ="NGZ", LocalName="North Gaza", Name="North Gaza", Type="Governorate" },
            new(){ Code ="QQA", LocalName="Qalqilya", Name="Qalqilya", Type="Governorate" },
            new(){ Code ="RFH", LocalName="Rafah", Name="Rafah", Type="Governorate" },
            new(){ Code ="RBH", LocalName="Ramallah", Name="Ramallah", Type="Governorate" },
            new(){ Code ="SLT", LocalName="Salfit", Name="Salfit", Type="Governorate" },
            new(){ Code ="TBS", LocalName="Tubas", Name="Tubas", Type="Governorate" },
            new(){ Code ="TKM", LocalName="Tulkarm", Name="Tulkarm", Type="Governorate" }

        });
    }
}
