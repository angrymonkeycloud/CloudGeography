using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKR()
    {
        AddSubdivisions("KR", new List<Subdivision>()
        {
            new(){ Code ="26", LocalName="Busan Gwang'yeogsi", Name="Busan Gwang'yeogsi", Type="MetropolitanCity" },
            new(){ Code ="43", LocalName="Chungcheongbugdo", Name="Chungcheongbugdo", Type="Province" },
            new(){ Code ="44", LocalName="Chungcheongnamdo", Name="Chungcheongnamdo", Type="Province" },
            new(){ Code ="27", LocalName="Daegu Gwang'yeogsi", Name="Daegu Gwang'yeogsi", Type="MetropolitanCity" },
            new(){ Code ="30", LocalName="Daejeon Gwang'yeogsi", Name="Daejeon Gwang'yeogsi", Type="MetropolitanCity" },
            new(){ Code ="42", LocalName="Gang'weondo", Name="Gang'weondo", Type="Province" },
            new(){ Code ="29", LocalName="Gwangju Gwang'yeogsi", Name="Gwangju Gwang'yeogsi", Type="MetropolitanCity" },
            new(){ Code ="41", LocalName="Gyeonggido", Name="Gyeonggido", Type="Province" },
            new(){ Code ="47", LocalName="Gyeongsangbugdo", Name="Gyeongsangbugdo", Type="Province" },
            new(){ Code ="48", LocalName="Gyeongsangnamdo", Name="Gyeongsangnamdo", Type="Province" },
            new(){ Code ="28", LocalName="Incheon Gwang'yeogsi", Name="Incheon Gwang'yeogsi", Type="MetropolitanCity" },
            new(){ Code ="49", LocalName="Jeju-teukbyeoljachido", Name="Jeju-teukbyeoljachido", Type="Province" },
            new(){ Code ="45", LocalName="Jeonrabugdo", Name="Jeonrabugdo", Type="Province" },
            new(){ Code ="46", LocalName="Jeonranamdo", Name="Jeonranamdo", Type="Province" },
            new(){ Code ="50", LocalName="Sejong", Name="Sejong", Type="City" },
            new(){ Code ="11", LocalName="Seoul-teukbyeolsi", Name="Seoul-teukbyeolsi", Type="SpecialCity" },
            new(){ Code ="31", LocalName="Ulsan Gwang'yeogsi", Name="Ulsan Gwang'yeogsi", Type="MetropolitanCity" }

        });
    }
}
