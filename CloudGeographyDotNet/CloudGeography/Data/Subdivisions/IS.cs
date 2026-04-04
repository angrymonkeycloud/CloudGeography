using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIS()
    {
        AddSubdivisions("IS",
        [
            new()
            { 
                Code = "7",
                Type = SubdivisionTypes.Region,
                Name = "Austurland",
                LocalName = "Austurland"
            },
            new()
            { 
                Code = "1",
                Type = SubdivisionTypes.Region,
                Name = "Höfuðborgarsvæði utan Reykjavíkur",
                LocalName = "Höfuðborgarsvæði utan Reykjavíkur"
            },
            new()
            { 
                Code = "6",
                Type = SubdivisionTypes.Region,
                Name = "Norðurland eystra",
                LocalName = "Norðurland eystra"
            },
            new()
            { 
                Code = "5",
                Type = SubdivisionTypes.Region,
                Name = "Norðurland vestra",
                LocalName = "Norðurland vestra"
            },
            new()
            { 
                Code = "8",
                Type = SubdivisionTypes.Region,
                Name = "Suðurland",
                LocalName = "Suðurland"
            },
            new()
            { 
                Code = "2",
                Type = SubdivisionTypes.Region,
                Name = "Suðurnes",
                LocalName = "Suðurnes"
            },
            new()
            { 
                Code = "4",
                Type = SubdivisionTypes.Region,
                Name = "Vestfirðir",
                LocalName = "Vestfirðir"
            },
            new()
            { 
                Code = "3",
                Type = SubdivisionTypes.Region,
                Name = "Vesturland",
                LocalName = "Vesturland"
            }

        ]);
    }
}
