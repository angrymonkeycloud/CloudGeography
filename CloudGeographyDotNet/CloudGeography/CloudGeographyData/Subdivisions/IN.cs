using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIN()
    {
        AddSubdivisions("IN", new List<Subdivision>()
        {
            new(){ Code ="AP", LocalName="Andhra Pradesh", Name="Andhra Pradesh", Type="State" },
            new(){ Code ="AR", LocalName="Arunachal Pradesh", Name="Arunachal Pradesh", Type="State" },
            new(){ Code ="AS", LocalName="Assam", Name="Assam", Type="State" },
            new(){ Code ="BR", LocalName="Bihar", Name="Bihar", Type="State" },
            new(){ Code ="CT", LocalName="Chhattisgarh", Name="Chhattisgarh", Type="State" },
            new(){ Code ="GA", LocalName="Goa", Name="Goa", Type="State" },
            new(){ Code ="GJ", LocalName="Gujarat", Name="Gujarat", Type="State" },
            new(){ Code ="HR", LocalName="Haryana", Name="Haryana", Type="State" },
            new(){ Code ="HP", LocalName="Himachal Pradesh", Name="Himachal Pradesh", Type="State" },
            new(){ Code ="JK", LocalName="Jammu and Kashmir", Name="Jammu and Kashmir", Type="State" },
            new(){ Code ="JH", LocalName="Jharkhand", Name="Jharkhand", Type="State" },
            new(){ Code ="KA", LocalName="Karnataka", Name="Karnataka", Type="State" },
            new(){ Code ="KL", LocalName="Kerala", Name="Kerala", Type="State" },
            new(){ Code ="MP", LocalName="Madhya Pradesh", Name="Madhya Pradesh", Type="State" },
            new(){ Code ="MH", LocalName="Maharashtra", Name="Maharashtra", Type="State" },
            new(){ Code ="MN", LocalName="Manipur", Name="Manipur", Type="State" },
            new(){ Code ="ML", LocalName="Meghalaya", Name="Meghalaya", Type="State" },
            new(){ Code ="MZ", LocalName="Mizoram", Name="Mizoram", Type="State" },
            new(){ Code ="NL", LocalName="Nagaland", Name="Nagaland", Type="State" },
            new(){ Code ="OR", LocalName="Odisha", Name="Odisha", Type="State" },
            new(){ Code ="PB", LocalName="Punjab", Name="Punjab", Type="State" },
            new(){ Code ="RJ", LocalName="Rajasthan", Name="Rajasthan", Type="State" },
            new(){ Code ="SK", LocalName="Sikkim", Name="Sikkim", Type="State" },
            new(){ Code ="TN", LocalName="Tamil Nadu", Name="Tamil Nadu", Type="State" },
            new(){ Code ="TG", LocalName="Telangana", Name="Telangana", Type="State" },
            new(){ Code ="TR", LocalName="Tripura", Name="Tripura", Type="State" },
            new(){ Code ="UP", LocalName="Uttar Pradesh", Name="Uttar Pradesh", Type="State" },
            new(){ Code ="UT", LocalName="Uttarakhand", Name="Uttarakhand", Type="State" },
            new(){ Code ="WB", LocalName="West Bengal", Name="West Bengal", Type="State" }

        });
    }
}
