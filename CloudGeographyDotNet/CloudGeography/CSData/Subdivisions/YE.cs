using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsYE()
    {
        AddSubdivisions("YE", new List<Subdivision>()
        {
            new(){ Code ="HD", LocalName="?a?ramawt", Name="?a?ramawt", Type="Governorate" },
            new(){ Code ="HJ", LocalName="?ajjah", Name="?ajjah", Type="Governorate" },
            new(){ Code ="AD", LocalName="Adan", Name="Adan", Type="Governorate" },
            new(){ Code ="AM", LocalName="Amran", Name="Amran", Type="Governorate" },
            new(){ Code ="DA", LocalName="A? ?ali", Name="A? ?ali", Type="Governorate" },
            new(){ Code ="AB", LocalName="Abyan", Name="Abyan", Type="Governorate" },
            new(){ Code ="HU", LocalName="Al ?udaydah", Name="Al ?udaydah", Type="Governorate" },
            new(){ Code ="BA", LocalName="Al Bay?a", Name="Al Bay?a", Type="Governorate" },
            new(){ Code ="JA", LocalName="Al Jawf", Name="Al Jawf", Type="Governorate" },
            new(){ Code ="MW", LocalName="Al Ma?wit", Name="Al Ma?wit", Type="Governorate" },
            new(){ Code ="MR", LocalName="Al Mahrah", Name="Al Mahrah", Type="Governorate" },
            new(){ Code ="SA", LocalName="Amanat al Asimah", Name="Amanat al Asimah", Type="Municipality" },
            new(){ Code ="SU", LocalName="Arkhabil Suqutrá", Name="Arkhabil Suqutrá", Type="Governorate" },
            new(){ Code ="DH", LocalName="Dhamar", Name="Dhamar", Type="Governorate" },
            new(){ Code ="IB", LocalName="Ibb", Name="Ibb", Type="Governorate" },
            new(){ Code ="LA", LocalName="Lahij", Name="Lahij", Type="Governorate" },
            new(){ Code ="MA", LocalName="Marib", Name="Marib", Type="Governorate" },
            new(){ Code ="RA", LocalName="Raymah", Name="Raymah", Type="Governorate" },
            new(){ Code ="SD", LocalName="Sa'dah", Name="Sa'dah", Type="Governorate" },
            new(){ Code ="SN", LocalName="San?a'", Name="San?a'", Type="Governorate" },
            new(){ Code ="SH", LocalName="Shabwah", Name="Shabwah", Type="Governorate" },
            new(){ Code ="TA", LocalName="Ta'izz", Name="Ta'izz", Type="Governorate" }

        });
    }
}
