using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsAF()
    {
        AddSubdivisions("AF", new List<Subdivision>()
        {
            new(){ Code ="BDS", LocalName="Badakhshan", Name="Badakhshan", Type="Province" },
            new(){ Code ="BDG", LocalName="Badghis", Name="Badghis", Type="Province" },
            new(){ Code ="BGL", LocalName="Baghlan", Name="Baghlan", Type="Province" },
            new(){ Code ="BAL", LocalName="Balkh", Name="Balkh", Type="Province" },
            new(){ Code ="BAM", LocalName="Bamyan", Name="Bamyan", Type="Province" },
            new(){ Code ="DAY", LocalName="Daykundi", Name="Daykundi", Type="Province" },
            new(){ Code ="FRA", LocalName="Farah", Name="Farah", Type="Province" },
            new(){ Code ="FYB", LocalName="Faryab", Name="Faryab", Type="Province" },
            new(){ Code ="GHA", LocalName="Ghazni", Name="Ghazni", Type="Province" },
            new(){ Code ="GHO", LocalName="Ghor", Name="Ghor", Type="Province" },
            new(){ Code ="HEL", LocalName="Helmand", Name="Helmand", Type="Province" },
            new(){ Code ="HER", LocalName="Herat", Name="Herat", Type="Province" },
            new(){ Code ="JOW", LocalName="Jowzjan", Name="Jowzjan", Type="Province" },
            new(){ Code ="KAB", LocalName="Kabul", Name="Kabul", Type="Province" },
            new(){ Code ="KAN", LocalName="Kandahar", Name="Kandahar", Type="Province" },
            new(){ Code ="KAP", LocalName="Kapisa", Name="Kapisa", Type="Province" },
            new(){ Code ="KHO", LocalName="Khost", Name="Khost", Type="Province" },
            new(){ Code ="KNR", LocalName="Kuna?", Name="Kuna?", Type="Province" },
            new(){ Code ="KDZ", LocalName="Kunduz", Name="Kunduz", Type="Province" },
            new(){ Code ="LAG", LocalName="Laghman", Name="Laghman", Type="Province" },
            new(){ Code ="LOG", LocalName="Logar", Name="Logar", Type="Province" },
            new(){ Code ="NAN", LocalName="Nangarhar", Name="Nangarhar", Type="Province" },
            new(){ Code ="NIM", LocalName="Nimroz", Name="Nimroz", Type="Province" },
            new(){ Code ="NUR", LocalName="Nuristan", Name="Nuristan", Type="Province" },
            new(){ Code ="PKA", LocalName="Paktika", Name="Paktika", Type="Province" },
            new(){ Code ="PIA", LocalName="Paktiya", Name="Paktiya", Type="Province" },
            new(){ Code ="PAN", LocalName="Panjshayr", Name="Panjshayr", Type="Province" },
            new(){ Code ="PAR", LocalName="Parwan", Name="Parwan", Type="Province" },
            new(){ Code ="SAM", LocalName="Samangan", Name="Samangan", Type="Province" },
            new(){ Code ="SAR", LocalName="Sar-e Pul", Name="Sar-e Pul", Type="Province" },
            new(){ Code ="TAK", LocalName="Takhar", Name="Takhar", Type="Province" },
            new(){ Code ="URU", LocalName="Uruzgan", Name="Uruzgan", Type="Province" },
            new(){ Code ="WAR", LocalName="Wardak", Name="Wardak", Type="Province" },
            new(){ Code ="ZAB", LocalName="Zabul", Name="Zabul", Type="Province" }

        });
    }
}
