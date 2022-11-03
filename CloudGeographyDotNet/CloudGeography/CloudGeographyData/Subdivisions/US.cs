using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsUS()
    {
        AddSubdivisions("US", new List<Subdivision>()
        {
            new(){ Code ="AL", LocalName="Alabama", Name="Alabama", Type="State" },
            new(){ Code ="AK", LocalName="Alaska", Name="Alaska", Type="State" },
            new(){ Code ="AZ", LocalName="Arizona", Name="Arizona", Type="State" },
            new(){ Code ="AR", LocalName="Arkansas", Name="Arkansas", Type="State" },
            new(){ Code ="CA", LocalName="California", Name="California", Type="State" },
            new(){ Code ="CO", LocalName="Colorado", Name="Colorado", Type="State" },
            new(){ Code ="CT", LocalName="Connecticut", Name="Connecticut", Type="State" },
            new(){ Code ="DE", LocalName="Delaware", Name="Delaware", Type="State" },
            new(){ Code ="DC", LocalName="District of Columbia", Name="District of Columbia", Type="District" },
            new(){ Code ="FL", LocalName="Florida", Name="Florida", Type="State" },
            new(){ Code ="GA", LocalName="Georgia", Name="Georgia", Type="State" },
            new(){ Code ="HI", LocalName="Hawaii", Name="Hawaii", Type="State" },
            new(){ Code ="ID", LocalName="Idaho", Name="Idaho", Type="State" },
            new(){ Code ="IL", LocalName="Illinois", Name="Illinois", Type="State" },
            new(){ Code ="IN", LocalName="Indiana", Name="Indiana", Type="State" },
            new(){ Code ="IA", LocalName="Iowa", Name="Iowa", Type="State" },
            new(){ Code ="KS", LocalName="Kansas", Name="Kansas", Type="State" },
            new(){ Code ="KY", LocalName="Kentucky", Name="Kentucky", Type="State" },
            new(){ Code ="LA", LocalName="Louisiana", Name="Louisiana", Type="State" },
            new(){ Code ="ME", LocalName="Maine", Name="Maine", Type="State" },
            new(){ Code ="MD", LocalName="Maryland", Name="Maryland", Type="State" },
            new(){ Code ="MA", LocalName="Massachusetts", Name="Massachusetts", Type="State" },
            new(){ Code ="MI", LocalName="Michigan", Name="Michigan", Type="State" },
            new(){ Code ="MN", LocalName="Minnesota", Name="Minnesota", Type="State" },
            new(){ Code ="MS", LocalName="Mississippi", Name="Mississippi", Type="State" },
            new(){ Code ="MO", LocalName="Missouri", Name="Missouri", Type="State" },
            new(){ Code ="MT", LocalName="Montana", Name="Montana", Type="State" },
            new(){ Code ="NE", LocalName="Nebraska", Name="Nebraska", Type="State" },
            new(){ Code ="NV", LocalName="Nevada", Name="Nevada", Type="State" },
            new(){ Code ="NH", LocalName="New Hampshire", Name="New Hampshire", Type="State" },
            new(){ Code ="NJ", LocalName="New Jersey", Name="New Jersey", Type="State" },
            new(){ Code ="NM", LocalName="New Mexico", Name="New Mexico", Type="State" },
            new(){ Code ="NY", LocalName="New York", Name="New York", Type="State" },
            new(){ Code ="NC", LocalName="North Carolina", Name="North Carolina", Type="State" },
            new(){ Code ="ND", LocalName="North Dakota", Name="North Dakota", Type="State" },
            new(){ Code ="OH", LocalName="Ohio", Name="Ohio", Type="State" },
            new(){ Code ="OK", LocalName="Oklahoma", Name="Oklahoma", Type="State" },
            new(){ Code ="OR", LocalName="Oregon", Name="Oregon", Type="State" },
            new(){ Code ="PA", LocalName="Pennsylvania", Name="Pennsylvania", Type="State" },
            new(){ Code ="RI", LocalName="Rhode Island", Name="Rhode Island", Type="State" },
            new(){ Code ="SC", LocalName="South Carolina", Name="South Carolina", Type="State" },
            new(){ Code ="SD", LocalName="South Dakota", Name="South Dakota", Type="State" },
            new(){ Code ="TN", LocalName="Tennessee", Name="Tennessee", Type="State" },
            new(){ Code ="TX", LocalName="Texas", Name="Texas", Type="State" },
            new(){ Code ="UT", LocalName="Utah", Name="Utah", Type="State" },
            new(){ Code ="VT", LocalName="Vermont", Name="Vermont", Type="State" },
            new(){ Code ="VA", LocalName="Virginia", Name="Virginia", Type="State" },
            new(){ Code ="WA", LocalName="Washington", Name="Washington", Type="State" },
            new(){ Code ="WV", LocalName="West Virginia", Name="West Virginia", Type="State" },
            new(){ Code ="WI", LocalName="Wisconsin", Name="Wisconsin", Type="State" },
            new(){ Code ="WY", LocalName="Wyoming", Name="Wyoming", Type="State" }

        });
    }
}
