using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsCN()
    {
        AddSubdivisions("CN", new List<Subdivision>()
        {
            new(){ Code ="34", LocalName="安徽省", Name="Anhui", Type="Province" },
            new(){ Code ="11", LocalName="北京市", Name="Beijing", Type="Municipality" },
            new(){ Code ="50", LocalName="重庆市", Name="Chongqing", Type="Municipality" },
            new(){ Code ="35", LocalName="福建省", Name="Fujian", Type="Province" },
            new(){ Code ="62", LocalName="甘肃省", Name="Gansu", Type="Province" },
            new(){ Code ="44", LocalName="广东省", Name="Guangdong", Type="Province" },
            new(){ Code ="45", LocalName="广西壮族自治区", Name="Guangxi", Type="Region" },
            new(){ Code ="52", LocalName="贵州省", Name="Guizhou", Type="Province" },
            new(){ Code ="46", LocalName="海南省", Name="Hainan", Type="Province" },
            new(){ Code ="13", LocalName="河北省", Name="Hebei", Type="Province" },
            new(){ Code ="23", LocalName="黑龙江省", Name="Heilongjiang", Type="Province" },
            new(){ Code ="41", LocalName="河南省", Name="Henan", Type="Province" },
            new(){ Code ="91", LocalName="香港特别行政区", Name="Hong Kong", Type="Region" },
            new(){ Code ="42", LocalName="河北省", Name="Hubei", Type="Province" },
            new(){ Code ="43", LocalName="湖南省", Name="Hunan", Type="Province" },
            new(){ Code ="15", LocalName="内蒙古自治区", Name="Inner Mongolia", Type="Region" },
            new(){ Code ="32", LocalName="江苏省", Name="Jiangsu", Type="Province" },
            new(){ Code ="36", LocalName="江西省", Name="Jiangxi", Type="Province" },
            new(){ Code ="22", LocalName="吉林省", Name="Jilin", Type="Province" },
            new(){ Code ="21", LocalName="辽宁省", Name="Liaoning", Type="Province" },
            new(){ Code ="92", LocalName="澳门特别行政区", Name="Macau", Type="Region" },
            new(){ Code ="64", LocalName="宁夏回族自治区", Name="Ningxia", Type="Region" },
            new(){ Code ="63", LocalName="青海省", Name="Qinghai", Type="Province" },
            new(){ Code ="61", LocalName="陕西省", Name="Shaanxi", Type="Province" },
            new(){ Code ="37", LocalName="山东省", Name="Shandong", Type="Province" },
            new(){ Code ="31", LocalName="上海市", Name="Shanghai", Type="Municipality" },
            new(){ Code ="14", LocalName="山西省", Name="Shanxi", Type="Province" },
            new(){ Code ="51", LocalName="四川省", Name="Sichuan", Type="Province" },
            new(){ Code ="71", LocalName="台湾省", Name="Taiwan", Type="Province" },
            new(){ Code ="12", LocalName="天津市", Name="Tianjin", Type="Municipality" },
            new(){ Code ="54", LocalName="西藏自治区", Name="Tibet", Type="Region" },
            new(){ Code ="65", LocalName="新疆维吾尔自治区", Name="Xinjiang", Type="Region" },
            new(){ Code ="53", LocalName="云南省", Name="Yunnan", Type="Province" },
            new(){ Code ="33", LocalName="浙江省", Name="Zhejiang", Type="Province" }

        });
    }
}
