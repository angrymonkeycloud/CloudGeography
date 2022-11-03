using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTW()
    {
        AddSubdivisions("TW", new List<Subdivision>()
        {
            new(){ Code ="CHA", LocalName="Changhua", Name="Changhua", Type="County" },
            new(){ Code ="CYQ", LocalName="Chiayi", Name="Chiayi", Type="County" },
            new(){ Code ="CYI", LocalName="Chiayi", Name="Chiayi", Type="City" },
            new(){ Code ="HSQ", LocalName="Hsinchu", Name="Hsinchu", Type="County" },
            new(){ Code ="HSZ", LocalName="Hsinchu", Name="Hsinchu", Type="City" },
            new(){ Code ="HUA", LocalName="Hualien", Name="Hualien", Type="County" },
            new(){ Code ="KHH", LocalName="Kaohsiung", Name="Kaohsiung", Type="Municipality" },
            new(){ Code ="KEE", LocalName="Keelung", Name="Keelung", Type="City" },
            new(){ Code ="KIN", LocalName="Kinmen", Name="Kinmen", Type="County" },
            new(){ Code ="LIE", LocalName="Lienchiang", Name="Lienchiang", Type="County" },
            new(){ Code ="MIA", LocalName="Miaoli", Name="Miaoli", Type="County" },
            new(){ Code ="NAN", LocalName="Nantou", Name="Nantou", Type="County" },
            new(){ Code ="NWT", LocalName="New Taipei", Name="New Taipei", Type="Municipality" },
            new(){ Code ="PEN", LocalName="Penghu", Name="Penghu", Type="County" },
            new(){ Code ="PIF", LocalName="Pingtung", Name="Pingtung", Type="County" },
            new(){ Code ="TXG", LocalName="Taichung", Name="Taichung", Type="Municipality" },
            new(){ Code ="TNN", LocalName="Tainan", Name="Tainan", Type="Municipality" },
            new(){ Code ="TPE", LocalName="Taipei", Name="Taipei", Type="Municipality" },
            new(){ Code ="TTT", LocalName="Taitung", Name="Taitung", Type="County" },
            new(){ Code ="TAO", LocalName="Taoyuan", Name="Taoyuan", Type="Municipality" },
            new(){ Code ="ILA", LocalName="Yilan", Name="Yilan", Type="County" },
            new(){ Code ="YUN", LocalName="Yunlin", Name="Yunlin", Type="County" }

        });
    }
}
