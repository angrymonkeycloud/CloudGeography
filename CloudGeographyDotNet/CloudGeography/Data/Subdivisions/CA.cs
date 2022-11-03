using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCA()
    {
        AddSubdivisions("CA", new List<Subdivision>()
        {
            new(){ Code ="AB", LocalName="Alberta", Name="Alberta", Type="Province" },
            new(){ Code ="BC", LocalName="British Columbia", Name="British Columbia", Type="Province" },
            new(){ Code ="MB", LocalName="Manitoba", Name="Manitoba", Type="Province" },
            new(){ Code ="NB", LocalName="New Brunswick", Name="New Brunswick", Type="Province" },
            new(){ Code ="NL", LocalName="Newfoundland and Labrador", Name="Newfoundland and Labrador", Type="Province" },
            new(){ Code ="NT", LocalName="Northwest Territories", Name="Northwest Territories", Type="Territory" },
            new(){ Code ="NS", LocalName="Nova Scotia", Name="Nova Scotia", Type="Province" },
            new(){ Code ="NU", LocalName="Nunavut", Name="Nunavut", Type="Territory" },
            new(){ Code ="ON", LocalName="Ontario", Name="Ontario", Type="Province" },
            new(){ Code ="PE", LocalName="Prince Edward Island", Name="Prince Edward Island", Type="Province" },
            new(){ Code ="QC", LocalName="Quebec", Name="Quebec", Type="Province" },
            new(){ Code ="SK", LocalName="Saskatchewan", Name="Saskatchewan", Type="Province" },
            new(){ Code ="YT", LocalName="Yukon", Name="Yukon", Type="Territory" }

        });
    }
}
