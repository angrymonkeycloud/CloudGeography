using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsNG()
    {
        AddSubdivisions("NG", new List<Subdivision>()
        {
            new(){ Code ="AB", LocalName="Abia", Name="Abia", Type="State" },
            new(){ Code ="FC", LocalName="Abuja Capital Territory", Name="Abuja Capital Territory", Type="Territory" },
            new(){ Code ="AD", LocalName="Adamawa", Name="Adamawa", Type="State" },
            new(){ Code ="AK", LocalName="Akwa Ibom", Name="Akwa Ibom", Type="State" },
            new(){ Code ="AN", LocalName="Anambra", Name="Anambra", Type="State" },
            new(){ Code ="BA", LocalName="Bauchi", Name="Bauchi", Type="State" },
            new(){ Code ="BY", LocalName="Bayelsa", Name="Bayelsa", Type="State" },
            new(){ Code ="BE", LocalName="Benue", Name="Benue", Type="State" },
            new(){ Code ="BO", LocalName="Borno", Name="Borno", Type="State" },
            new(){ Code ="CR", LocalName="Cross River", Name="Cross River", Type="State" },
            new(){ Code ="DE", LocalName="Delta", Name="Delta", Type="State" },
            new(){ Code ="EB", LocalName="Ebonyi", Name="Ebonyi", Type="State" },
            new(){ Code ="ED", LocalName="Edo", Name="Edo", Type="State" },
            new(){ Code ="EK", LocalName="Ekiti", Name="Ekiti", Type="State" },
            new(){ Code ="EN", LocalName="Enugu", Name="Enugu", Type="State" },
            new(){ Code ="GO", LocalName="Gombe", Name="Gombe", Type="State" },
            new(){ Code ="IM", LocalName="Imo", Name="Imo", Type="State" },
            new(){ Code ="JI", LocalName="Jigawa", Name="Jigawa", Type="State" },
            new(){ Code ="KD", LocalName="Kaduna", Name="Kaduna", Type="State" },
            new(){ Code ="KN", LocalName="Kano", Name="Kano", Type="State" },
            new(){ Code ="KT", LocalName="Katsina", Name="Katsina", Type="State" },
            new(){ Code ="KE", LocalName="Kebbi", Name="Kebbi", Type="State" },
            new(){ Code ="KO", LocalName="Kogi", Name="Kogi", Type="State" },
            new(){ Code ="KW", LocalName="Kwara", Name="Kwara", Type="State" },
            new(){ Code ="LA", LocalName="Lagos", Name="Lagos", Type="State" },
            new(){ Code ="NA", LocalName="Nasarawa", Name="Nasarawa", Type="State" },
            new(){ Code ="NI", LocalName="Niger", Name="Niger", Type="State" },
            new(){ Code ="OG", LocalName="Ogun", Name="Ogun", Type="State" },
            new(){ Code ="ON", LocalName="Ondo", Name="Ondo", Type="State" },
            new(){ Code ="OS", LocalName="Osun", Name="Osun", Type="State" },
            new(){ Code ="OY", LocalName="Oyo", Name="Oyo", Type="State" },
            new(){ Code ="PL", LocalName="Plateau", Name="Plateau", Type="State" },
            new(){ Code ="RI", LocalName="Rivers", Name="Rivers", Type="State" },
            new(){ Code ="SO", LocalName="Sokoto", Name="Sokoto", Type="State" },
            new(){ Code ="TA", LocalName="Taraba", Name="Taraba", Type="State" },
            new(){ Code ="YO", LocalName="Yobe", Name="Yobe", Type="State" },
            new(){ Code ="ZA", LocalName="Zamfara", Name="Zamfara", Type="State" }

        });
    }
}
