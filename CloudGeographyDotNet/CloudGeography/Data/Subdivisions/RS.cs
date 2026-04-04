using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsRS()
    {
        AddSubdivisions("RS",
        [
            new()
            { 
                Code = "12",
                Type = SubdivisionTypes.District,
                Name = "umadijski okrug",
                LocalName = "umadijski okrug"
            },
            new()
            { 
                Code = "0",
                Type = SubdivisionTypes.City,
                Name = "Beograd",
                LocalName = "Beograd"
            },
            new()
            { 
                Code = "14",
                Type = SubdivisionTypes.District,
                Name = "Borski okrug",
                LocalName = "Borski okrug"
            },
            new()
            { 
                Code = "11",
                Type = SubdivisionTypes.District,
                Name = "Branicevski okrug",
                LocalName = "Branicevski okrug"
            },
            new()
            { 
                Code = "23",
                Type = SubdivisionTypes.District,
                Name = "Jablanicki okrug",
                LocalName = "Jablanicki okrug"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.District,
                Name = "Junobacki okrug",
                LocalName = "Junobacki okrug"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.District,
                Name = "Junobanatski okrug",
                LocalName = "Junobanatski okrug"
            },
            new()
            { 
                Code = "9",
                Type = SubdivisionTypes.District,
                Name = "Kolubarski okrug",
                LocalName = "Kolubarski okrug"
            },
            new()
            { 
                Code = "KM",
                Type = SubdivisionTypes.Province,
                Name = "Kosovo-Metohija",
                LocalName = "Kosovo-Metohija"
            },
            new()
            { 
                Code = "25",
                Type = SubdivisionTypes.District,
                Name = "Kosovski okrug",
                LocalName = "Kosovski okrug"
            },
            new()
            { 
                Code = "28",
                Type = SubdivisionTypes.District,
                Name = "Kosovsko-Mitrovacki okrug",
                LocalName = "Kosovsko-Mitrovacki okrug"
            },
            new()
            { 
                Code = "29",
                Type = SubdivisionTypes.District,
                Name = "Kosovsko-Pomoravski okrug",
                LocalName = "Kosovsko-Pomoravski okrug"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.District,
                Name = "Macvanski okrug",
                LocalName = "Macvanski okrug"
            },
            new()
            { 
                Code = "17",
                Type = SubdivisionTypes.District,
                Name = "Moravicki okrug",
                LocalName = "Moravicki okrug"
            },
            new()
            { 
                Code = "20",
                Type = SubdivisionTypes.District,
                Name = "Niavski okrug",
                LocalName = "Niavski okrug"
            },
            new()
            { 
                Code = "24",
                Type = SubdivisionTypes.District,
                Name = "Pcinjski okrug",
                LocalName = "Pcinjski okrug"
            },
            new()
            { 
                Code = "26",
                Type = SubdivisionTypes.District,
                Name = "Pecki okrug",
                LocalName = "Pecki okrug"
            },
            new()
            { 
                Code = "22",
                Type = SubdivisionTypes.District,
                Name = "Pirotski okrug",
                LocalName = "Pirotski okrug"
            },
            new()
            { 
                Code = "10",
                Type = SubdivisionTypes.District,
                Name = "Podunavski okrug",
                LocalName = "Podunavski okrug"
            },
            new()
            { 
                Code = "13",
                Type = SubdivisionTypes.District,
                Name = "Pomoravski okrug",
                LocalName = "Pomoravski okrug"
            },
            new()
            { 
                Code = "27",
                Type = SubdivisionTypes.District,
                Name = "Prizrenski okrug",
                LocalName = "Prizrenski okrug"
            },
            new()
            { 
                Code = "18",
                Type = SubdivisionTypes.District,
                Name = "Raki okrug",
                LocalName = "Raki okrug"
            },
            new()
            { 
                Code = "19",
                Type = SubdivisionTypes.District,
                Name = "Rasinski okrug",
                LocalName = "Rasinski okrug"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.District,
                Name = "Severnobacki okrug",
                LocalName = "Severnobacki okrug"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.District,
                Name = "Severnobanatski okrug",
                LocalName = "Severnobanatski okrug"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.District,
                Name = "Srednjebanatski okrug",
                LocalName = "Srednjebanatski okrug"
            },
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.District,
                Name = "Sremski okrug",
                LocalName = "Sremski okrug"
            },
            new()
            { 
                Code = "21",
                Type = SubdivisionTypes.District,
                Name = "Toplicki okrug",
                LocalName = "Toplicki okrug"
            },
            new()
            { 
                Code = "VO",
                Type = SubdivisionTypes.Province,
                Name = "Vojvodina",
                LocalName = "Vojvodina"
            },
            new()
            { 
                Code = "15",
                Type = SubdivisionTypes.District,
                Name = "Zajecarski okrug",
                LocalName = "Zajecarski okrug"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.District,
                Name = "Zapadnobacki okrug",
                LocalName = "Zapadnobacki okrug"
            },
            new()
            { 
                Code = "16",
                Type = SubdivisionTypes.District,
                Name = "Zlatiborski okrug",
                LocalName = "Zlatiborski okrug"
            }

        ]);
    }
}
