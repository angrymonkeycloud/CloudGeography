using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLS()
    {
        AddSubdivisions("LS", new List<Subdivision>()
        {
            new()
            { 
                Code = "D",
                Type = "District",
                Name = "Berea",
                LocalName = "Berea"
            },
            new()
            { 
                Code = "B",
                Type = "District",
                Name = "Butha-Buthe",
                LocalName = "Butha-Buthe"
            },
            new()
            { 
                Code = "C",
                Type = "District",
                Name = "Leribe",
                LocalName = "Leribe"
            },
            new()
            { 
                Code = "E",
                Type = "District",
                Name = "Mafeteng",
                LocalName = "Mafeteng"
            },
            new()
            { 
                Code = "A",
                Type = "District",
                Name = "Maseru",
                LocalName = "Maseru"
            },
            new()
            { 
                Code = "F",
                Type = "District",
                Name = "Mohale's Hoek",
                LocalName = "Mohale's Hoek"
            },
            new()
            { 
                Code = "J",
                Type = "District",
                Name = "Mokhotlong",
                LocalName = "Mokhotlong"
            },
            new()
            { 
                Code = "H",
                Type = "District",
                Name = "Qacha's Nek",
                LocalName = "Qacha's Nek"
            },
            new()
            { 
                Code = "G",
                Type = "District",
                Name = "Quthing",
                LocalName = "Quthing"
            },
            new()
            { 
                Code = "K",
                Type = "District",
                Name = "Thaba-Tseka",
                LocalName = "Thaba-Tseka"
            }

        });
    }
}
