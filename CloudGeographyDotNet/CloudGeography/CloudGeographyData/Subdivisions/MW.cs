using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMW()
    {
        AddSubdivisions("MW", new List<Subdivision>()
        {
            new(){ Code ="BA", LocalName="Balaka", Name="Balaka", Type="District" },
            new(){ Code ="BL", LocalName="Blantyre", Name="Blantyre", Type="District" },
            new(){ Code ="C", LocalName="Central", Name="Central", Type="Region" },
            new(){ Code ="CK", LocalName="Chikwawa", Name="Chikwawa", Type="District" },
            new(){ Code ="CR", LocalName="Chiradzulu", Name="Chiradzulu", Type="District" },
            new(){ Code ="CT", LocalName="Chitipa", Name="Chitipa", Type="District" },
            new(){ Code ="DE", LocalName="Dedza", Name="Dedza", Type="District" },
            new(){ Code ="DO", LocalName="Dowa", Name="Dowa", Type="District" },
            new(){ Code ="KR", LocalName="Karonga", Name="Karonga", Type="District" },
            new(){ Code ="KS", LocalName="Kasungu", Name="Kasungu", Type="District" },
            new(){ Code ="LK", LocalName="Likoma", Name="Likoma", Type="District" },
            new(){ Code ="LI", LocalName="Lilongwe", Name="Lilongwe", Type="District" },
            new(){ Code ="MH", LocalName="Machinga", Name="Machinga", Type="District" },
            new(){ Code ="MG", LocalName="Mangochi", Name="Mangochi", Type="District" },
            new(){ Code ="MC", LocalName="Mchinji", Name="Mchinji", Type="District" },
            new(){ Code ="MU", LocalName="Mulanje", Name="Mulanje", Type="District" },
            new(){ Code ="MW", LocalName="Mwanza", Name="Mwanza", Type="District" },
            new(){ Code ="MZ", LocalName="Mzimba", Name="Mzimba", Type="District" },
            new(){ Code ="NE", LocalName="Neno", Name="Neno", Type="District" },
            new(){ Code ="NB", LocalName="Nkhata Bay", Name="Nkhata Bay", Type="District" },
            new(){ Code ="NK", LocalName="Nkhotakota", Name="Nkhotakota", Type="District" },
            new(){ Code ="N", LocalName="Northern", Name="Northern", Type="Region" },
            new(){ Code ="NS", LocalName="Nsanje", Name="Nsanje", Type="District" },
            new(){ Code ="NU", LocalName="Ntcheu", Name="Ntcheu", Type="District" },
            new(){ Code ="NI", LocalName="Ntchisi", Name="Ntchisi", Type="District" },
            new(){ Code ="PH", LocalName="Phalombe", Name="Phalombe", Type="District" },
            new(){ Code ="RU", LocalName="Rumphi", Name="Rumphi", Type="District" },
            new(){ Code ="SA", LocalName="Salima", Name="Salima", Type="District" },
            new(){ Code ="S", LocalName="Southern", Name="Southern", Type="Region" },
            new(){ Code ="TH", LocalName="Thyolo", Name="Thyolo", Type="District" },
            new(){ Code ="ZO", LocalName="Zomba", Name="Zomba", Type="District" }

        });
    }
}
