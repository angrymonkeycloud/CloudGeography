using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsHU()
    {
        AddSubdivisions("HU", new List<Subdivision>()
        {
            new(){ Code ="BK", LocalName="Bács-Kiskun", Name="Bács-Kiskun", Type="County" },
            new(){ Code ="BA", LocalName="Baranya", Name="Baranya", Type="County" },
            new(){ Code ="BE", LocalName="Békés", Name="Békés", Type="County" },
            new(){ Code ="BZ", LocalName="Borsod-Abaúj-Zemplén", Name="Borsod-Abaúj-Zemplén", Type="County" },
            new(){ Code ="BU", LocalName="Budapest", Name="Budapest", Type="CapitalCity" },
            new(){ Code ="CS", LocalName="Csongrád", Name="Csongrád", Type="County" },
            new(){ Code ="FE", LocalName="Fejér", Name="Fejér", Type="County" },
            new(){ Code ="GS", LocalName="Gyor-Moson-Sopron", Name="Gyor-Moson-Sopron", Type="County" },
            new(){ Code ="HB", LocalName="Hajdú-Bihar", Name="Hajdú-Bihar", Type="County" },
            new(){ Code ="HE", LocalName="Heves", Name="Heves", Type="County" },
            new(){ Code ="JN", LocalName="Jász-Nagykun-Szolnok", Name="Jász-Nagykun-Szolnok", Type="County" },
            new(){ Code ="KE", LocalName="Komárom-Esztergom", Name="Komárom-Esztergom", Type="County" },
            new(){ Code ="NO", LocalName="Nógrád", Name="Nógrád", Type="County" },
            new(){ Code ="PE", LocalName="Pest", Name="Pest", Type="County" },
            new(){ Code ="SO", LocalName="Somogy", Name="Somogy", Type="County" },
            new(){ Code ="SZ", LocalName="Szabolcs-Szatmár-Bereg", Name="Szabolcs-Szatmár-Bereg", Type="County" },
            new(){ Code ="TO", LocalName="Tolna", Name="Tolna", Type="County" },
            new(){ Code ="VA", LocalName="Vas", Name="Vas", Type="County" },
            new(){ Code ="VE", LocalName="Veszprém", Name="Veszprém", Type="County" },
            new(){ Code ="ZA", LocalName="Zala", Name="Zala", Type="County" }

        });
    }
}
