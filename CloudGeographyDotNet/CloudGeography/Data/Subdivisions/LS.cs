using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLS()
    {
        AddSubdivisions("LS",
        [
            new()
            { 
                Code = "D",
                Type = SubdivisionTypes.District,
                Name = "Berea",
                LocalName = "Berea"
            },
            new()
            { 
                Code = "B",
                Type = SubdivisionTypes.District,
                Name = "Butha-Buthe",
                LocalName = "Butha-Buthe"
            },
            new()
            { 
                Code = "C",
                Type = SubdivisionTypes.District,
                Name = "Leribe",
                LocalName = "Leribe"
            },
            new()
            { 
                Code = "E",
                Type = SubdivisionTypes.District,
                Name = "Mafeteng",
                LocalName = "Mafeteng"
            },
            new()
            { 
                Code = "A",
                Type = SubdivisionTypes.District,
                Name = "Maseru",
                LocalName = "Maseru"
            },
            new()
            { 
                Code = "F",
                Type = SubdivisionTypes.District,
                Name = "Mohale's Hoek",
                LocalName = "Mohale's Hoek"
            },
            new()
            { 
                Code = "J",
                Type = SubdivisionTypes.District,
                Name = "Mokhotlong",
                LocalName = "Mokhotlong"
            },
            new()
            { 
                Code = "H",
                Type = SubdivisionTypes.District,
                Name = "Qacha's Nek",
                LocalName = "Qacha's Nek"
            },
            new()
            { 
                Code = "G",
                Type = SubdivisionTypes.District,
                Name = "Quthing",
                LocalName = "Quthing"
            },
            new()
            { 
                Code = "K",
                Type = SubdivisionTypes.District,
                Name = "Thaba-Tseka",
                LocalName = "Thaba-Tseka"
            }

        ]);
    }
}
