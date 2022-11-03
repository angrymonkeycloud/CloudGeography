using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsRS()
    {
        AddSubdivisions("RS", new List<Subdivision>()
        {
            new(){ Code ="12", LocalName="umadijski okrug", Name="umadijski okrug", Type="District" },
            new(){ Code ="0", LocalName="Beograd", Name="Beograd", Type="City" },
            new(){ Code ="14", LocalName="Borski okrug", Name="Borski okrug", Type="District" },
            new(){ Code ="11", LocalName="Branicevski okrug", Name="Branicevski okrug", Type="District" },
            new(){ Code ="23", LocalName="Jablanicki okrug", Name="Jablanicki okrug", Type="District" },
            new(){ Code ="6", LocalName="Junobacki okrug", Name="Junobacki okrug", Type="District" },
            new(){ Code ="4", LocalName="Junobanatski okrug", Name="Junobanatski okrug", Type="District" },
            new(){ Code ="9", LocalName="Kolubarski okrug", Name="Kolubarski okrug", Type="District" },
            new(){ Code ="KM", LocalName="Kosovo-Metohija", Name="Kosovo-Metohija", Type="Province" },
            new(){ Code ="25", LocalName="Kosovski okrug", Name="Kosovski okrug", Type="District" },
            new(){ Code ="28", LocalName="Kosovsko-Mitrovacki okrug", Name="Kosovsko-Mitrovacki okrug", Type="District" },
            new(){ Code ="29", LocalName="Kosovsko-Pomoravski okrug", Name="Kosovsko-Pomoravski okrug", Type="District" },
            new(){ Code ="8", LocalName="Macvanski okrug", Name="Macvanski okrug", Type="District" },
            new(){ Code ="17", LocalName="Moravicki okrug", Name="Moravicki okrug", Type="District" },
            new(){ Code ="20", LocalName="Niavski okrug", Name="Niavski okrug", Type="District" },
            new(){ Code ="24", LocalName="Pcinjski okrug", Name="Pcinjski okrug", Type="District" },
            new(){ Code ="26", LocalName="Pecki okrug", Name="Pecki okrug", Type="District" },
            new(){ Code ="22", LocalName="Pirotski okrug", Name="Pirotski okrug", Type="District" },
            new(){ Code ="10", LocalName="Podunavski okrug", Name="Podunavski okrug", Type="District" },
            new(){ Code ="13", LocalName="Pomoravski okrug", Name="Pomoravski okrug", Type="District" },
            new(){ Code ="27", LocalName="Prizrenski okrug", Name="Prizrenski okrug", Type="District" },
            new(){ Code ="18", LocalName="Raki okrug", Name="Raki okrug", Type="District" },
            new(){ Code ="19", LocalName="Rasinski okrug", Name="Rasinski okrug", Type="District" },
            new(){ Code ="1", LocalName="Severnobacki okrug", Name="Severnobacki okrug", Type="District" },
            new(){ Code ="3", LocalName="Severnobanatski okrug", Name="Severnobanatski okrug", Type="District" },
            new(){ Code ="2", LocalName="Srednjebanatski okrug", Name="Srednjebanatski okrug", Type="District" },
            new(){ Code ="7", LocalName="Sremski okrug", Name="Sremski okrug", Type="District" },
            new(){ Code ="21", LocalName="Toplicki okrug", Name="Toplicki okrug", Type="District" },
            new(){ Code ="VO", LocalName="Vojvodina", Name="Vojvodina", Type="Province" },
            new(){ Code ="15", LocalName="Zajecarski okrug", Name="Zajecarski okrug", Type="District" },
            new(){ Code ="5", LocalName="Zapadnobacki okrug", Name="Zapadnobacki okrug", Type="District" },
            new(){ Code ="16", LocalName="Zlatiborski okrug", Name="Zlatiborski okrug", Type="District" }

        });
    }
}
