using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsEG()
    {
        AddSubdivisions("EG", new List<Subdivision>()
        {
            new(){ Code ="DK", LocalName="Ad Daqahliyah", Name="Ad Daqahliyah", Type="Governorate" },
            new(){ Code ="FYM", LocalName="AI Fayyum", Name="AI Fayyum", Type="Governorate" },
            new(){ Code ="GH", LocalName="AI Gharbiyah", Name="AI Gharbiyah", Type="Governorate" },
            new(){ Code ="ALX", LocalName="AI Iskandariyah", Name="AI Iskandariyah", Type="Governorate" },
            new(){ Code ="IS", LocalName="AI Isma 'iliyah", Name="AI Isma 'iliyah", Type="Governorate" },
            new(){ Code ="GZ", LocalName="AI Jizah", Name="AI Jizah", Type="Governorate" },
            new(){ Code ="MNF", LocalName="AI Minufiyah", Name="AI Minufiyah", Type="Governorate" },
            new(){ Code ="MN", LocalName="AI Minya", Name="AI Minya", Type="Governorate" },
            new(){ Code ="C", LocalName="AI Qahirah", Name="AI Qahirah", Type="Governorate" },
            new(){ Code ="KB", LocalName="AI Qalyubiyah", Name="AI Qalyubiyah", Type="Governorate" },
            new(){ Code ="WAD", LocalName="AI Wadi al Jadid", Name="AI Wadi al Jadid", Type="Governorate" },
            new(){ Code ="BA", LocalName="Al Ba?r al A?mar", Name="Al Ba?r al A?mar", Type="Governorate" },
            new(){ Code ="BH", LocalName="Al Bu?ayrah", Name="Al Bu?ayrah", Type="Governorate" },
            new(){ Code ="LX", LocalName="Al Uqsur", Name="Al Uqsur", Type="Governorate" },
            new(){ Code ="SUZ", LocalName="As Suways", Name="As Suways", Type="Governorate" },
            new(){ Code ="SHR", LocalName="Ash Sharqiyah", Name="Ash Sharqiyah", Type="Governorate" },
            new(){ Code ="ASN", LocalName="Aswan", Name="Aswan", Type="Governorate" },
            new(){ Code ="AST", LocalName="Asyut", Name="Asyut", Type="Governorate" },
            new(){ Code ="BNS", LocalName="Bani Suwayf", Name="Bani Suwayf", Type="Governorate" },
            new(){ Code ="PTS", LocalName="Bur Sa'id", Name="Bur Sa'id", Type="Governorate" },
            new(){ Code ="DT", LocalName="Dumyat", Name="Dumyat", Type="Governorate" },
            new(){ Code ="JS", LocalName="Janub Sina'", Name="Janub Sina'", Type="Governorate" },
            new(){ Code ="KFS", LocalName="Kafr ash Shaykh", Name="Kafr ash Shaykh", Type="Governorate" },
            new(){ Code ="MT", LocalName="Matruh", Name="Matruh", Type="Governorate" },
            new(){ Code ="KN", LocalName="Qina", Name="Qina", Type="Governorate" },
            new(){ Code ="SIN", LocalName="Shamal Sina'", Name="Shamal Sina'", Type="Governorate" },
            new(){ Code ="SHG", LocalName="Suhaj", Name="Suhaj", Type="Governorate" }

        });
    }
}
