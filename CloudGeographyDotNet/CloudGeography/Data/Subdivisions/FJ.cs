using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsFJ()
    {
        AddSubdivisions("FJ", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Ba", Name="Ba", Type="Province" },
            new(){ Code ="2", LocalName="Bua", Name="Bua", Type="Province" },
            new(){ Code ="3", LocalName="Cakaudrove", Name="Cakaudrove", Type="Province" },
            new(){ Code ="4", LocalName="Kadavu", Name="Kadavu", Type="Province" },
            new(){ Code ="5", LocalName="Lau", Name="Lau", Type="Province" },
            new(){ Code ="6", LocalName="Lomaiviti", Name="Lomaiviti", Type="Province" },
            new(){ Code ="7", LocalName="Macuata", Name="Macuata", Type="Province" },
            new(){ Code ="8", LocalName="Nadroga and Navosa", Name="Nadroga and Navosa", Type="Province" },
            new(){ Code ="9", LocalName="Naitasiri", Name="Naitasiri", Type="Province" },
            new(){ Code ="10", LocalName="Namosi", Name="Namosi", Type="Province" },
            new(){ Code ="11", LocalName="Ra", Name="Ra", Type="Province" },
            new(){ Code ="12", LocalName="Rewa", Name="Rewa", Type="Province" },
            new(){ Code ="R", LocalName="Rotuma", Name="Rotuma", Type="Dependency" },
            new(){ Code ="13", LocalName="Serua", Name="Serua", Type="Province" },
            new(){ Code ="14", LocalName="Tailevu", Name="Tailevu", Type="Province" }

        });
    }
}
