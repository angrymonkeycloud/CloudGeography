using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBT()
    {
        AddSubdivisions("BT", new List<Subdivision>()
        {
            new(){ Code ="33", LocalName="བུམ་ཐང་རྫོང་ཁག་", Name="Bumthang", Type="District" },
            new(){ Code ="12", LocalName="ཆུ་ཁ་རྫོང་ཁག་", Name="Chukha", Type="District" },
            new(){ Code ="22", LocalName="དར་དཀར་ན་རྫོང་ཁག་", Name="Dagana", Type="District" },
            new(){ Code ="GA", LocalName="མགར་ས་རྫོང་ཁག་", Name="Gasa", Type="District" },
            new(){ Code ="13", LocalName="ཧཱ་རྫོང་ཁག་", Name="Haa", Type="District" },
            new(){ Code ="44", LocalName="ལྷུན་རྩེ་རྫོང་ཁག་", Name="Lhuntse", Type="District" },
            new(){ Code ="42", LocalName="མོང་སྒར་རྫོང་ཁག་", Name="Mongar", Type="District" },
            new(){ Code ="11", LocalName="སྤ་རོ་རྫོང་ཁག་", Name="Paro", Type="District" },
            new(){ Code ="43", LocalName="པད་མ་དགའ་ཚལ་རྫོང་ཁག་", Name="Pemagatshel", Type="District" },
            new(){ Code ="23", LocalName="སྤུ་ན་ཁ་རྫོང་ཁག་", Name="Punakha", Type="District" },
            new(){ Code ="45", LocalName="བསམ་གྲུབ་ལྗོངས་མཁར་རྫོང་ཁག་", Name="Samdrup Jongkhar", Type="District" },
            new(){ Code ="14", LocalName="བསམ་རྩེ་རྫོང་ཁག་", Name="Samtse", Type="District" },
            new(){ Code ="31", LocalName="གསར་སྤང་རྫོང་ཁག་", Name="Sarpang", Type="District" },
            new(){ Code ="15", LocalName="ཐིམ་ཕུ་རྫོང་ཁག་", Name="Thimphu", Type="District" },
            new(){ Code ="41", LocalName="བཀྲ་ཤིས་སྒང་རྫོང་ཁག་", Name="Trashigang", Type="District" },
            new(){ Code ="TY", LocalName="བཀྲ་ཤིས་གཡང་རྩེ་རྫོང་ཁག་", Name="Trashiyangtse", Type="District" },
            new(){ Code ="32", LocalName="ཀྲོང་གསར་རྫོང་ཁག་", Name="Trongsa", Type="District" },
            new(){ Code ="21", LocalName="རྩི་རང་རྫོང་ཁག་", Name="Tsirang", Type="District" },
            new(){ Code ="24", LocalName="དབང་འདུས་ཕོ་བྲང་རྫོང་ཁག་", Name="Wangdue Phodrang", Type="District" },
            new(){ Code ="34", LocalName="གཞམས་སྒང་རྫོང་ཁག་", Name="Zhemgang", Type="District" }

        });
    }
}
