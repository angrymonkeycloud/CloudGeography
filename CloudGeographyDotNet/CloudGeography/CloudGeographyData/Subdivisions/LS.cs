using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLS()
    {
        AddSubdivisions("LS", new List<Subdivision>()
        {
            new(){ Code ="D", LocalName="Berea", Name="Berea", Type="District" },
            new(){ Code ="B", LocalName="Butha-Buthe", Name="Butha-Buthe", Type="District" },
            new(){ Code ="C", LocalName="Leribe", Name="Leribe", Type="District" },
            new(){ Code ="E", LocalName="Mafeteng", Name="Mafeteng", Type="District" },
            new(){ Code ="A", LocalName="Maseru", Name="Maseru", Type="District" },
            new(){ Code ="F", LocalName="Mohale's Hoek", Name="Mohale's Hoek", Type="District" },
            new(){ Code ="J", LocalName="Mokhotlong", Name="Mokhotlong", Type="District" },
            new(){ Code ="H", LocalName="Qacha's Nek", Name="Qacha's Nek", Type="District" },
            new(){ Code ="G", LocalName="Quthing", Name="Quthing", Type="District" },
            new(){ Code ="K", LocalName="Thaba-Tseka", Name="Thaba-Tseka", Type="District" }

        });
    }
}
