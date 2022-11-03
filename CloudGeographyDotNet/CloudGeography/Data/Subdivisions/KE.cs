using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsKE()
    {
        AddSubdivisions("KE", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Baringo", Name="Baringo", Type="County" },
            new(){ Code ="2", LocalName="Bomet", Name="Bomet", Type="County" },
            new(){ Code ="3", LocalName="Bungoma", Name="Bungoma", Type="County" },
            new(){ Code ="4", LocalName="Busia", Name="Busia", Type="County" },
            new(){ Code ="5", LocalName="Elgeyo/Marakwet", Name="Elgeyo/Marakwet", Type="County" },
            new(){ Code ="6", LocalName="Embu", Name="Embu", Type="County" },
            new(){ Code ="7", LocalName="Garissa", Name="Garissa", Type="County" },
            new(){ Code ="8", LocalName="Homa Bay", Name="Homa Bay", Type="County" },
            new(){ Code ="9", LocalName="Isiolo", Name="Isiolo", Type="County" },
            new(){ Code ="10", LocalName="Kajiado", Name="Kajiado", Type="County" },
            new(){ Code ="11", LocalName="Kakamega", Name="Kakamega", Type="County" },
            new(){ Code ="12", LocalName="Kericho", Name="Kericho", Type="County" },
            new(){ Code ="13", LocalName="Kiambu", Name="Kiambu", Type="County" },
            new(){ Code ="14", LocalName="Kilifi", Name="Kilifi", Type="County" },
            new(){ Code ="15", LocalName="Kirinyaga", Name="Kirinyaga", Type="County" },
            new(){ Code ="16", LocalName="Kisii", Name="Kisii", Type="County" },
            new(){ Code ="17", LocalName="Kisumu", Name="Kisumu", Type="County" },
            new(){ Code ="18", LocalName="Kitui", Name="Kitui", Type="County" },
            new(){ Code ="19", LocalName="Kwale", Name="Kwale", Type="County" },
            new(){ Code ="20", LocalName="Laikipia", Name="Laikipia", Type="County" },
            new(){ Code ="21", LocalName="Lamu", Name="Lamu", Type="County" },
            new(){ Code ="22", LocalName="Machakos", Name="Machakos", Type="County" },
            new(){ Code ="23", LocalName="Makueni", Name="Makueni", Type="County" },
            new(){ Code ="24", LocalName="Mandera", Name="Mandera", Type="County" },
            new(){ Code ="25", LocalName="Marsabit", Name="Marsabit", Type="County" },
            new(){ Code ="26", LocalName="Meru", Name="Meru", Type="County" },
            new(){ Code ="27", LocalName="Migori", Name="Migori", Type="County" },
            new(){ Code ="28", LocalName="Mombasa", Name="Mombasa", Type="County" },
            new(){ Code ="29", LocalName="Murang'a", Name="Murang'a", Type="County" },
            new(){ Code ="30", LocalName="Nairobi City", Name="Nairobi City", Type="County" },
            new(){ Code ="31", LocalName="Nakuru", Name="Nakuru", Type="County" },
            new(){ Code ="32", LocalName="Nandi", Name="Nandi", Type="County" },
            new(){ Code ="33", LocalName="Narok", Name="Narok", Type="County" },
            new(){ Code ="34", LocalName="Nyamira", Name="Nyamira", Type="County" },
            new(){ Code ="35", LocalName="Nyandarua", Name="Nyandarua", Type="County" },
            new(){ Code ="36", LocalName="Nyeri", Name="Nyeri", Type="County" },
            new(){ Code ="37", LocalName="Samburu", Name="Samburu", Type="County" },
            new(){ Code ="38", LocalName="Siaya", Name="Siaya", Type="County" },
            new(){ Code ="39", LocalName="Taita/Taveta", Name="Taita/Taveta", Type="County" },
            new(){ Code ="40", LocalName="Tana River", Name="Tana River", Type="County" },
            new(){ Code ="41", LocalName="Tharaka-Nithi", Name="Tharaka-Nithi", Type="County" },
            new(){ Code ="42", LocalName="Trans Nzoia", Name="Trans Nzoia", Type="County" },
            new(){ Code ="43", LocalName="Turkana", Name="Turkana", Type="County" },
            new(){ Code ="44", LocalName="Uasin Gishu", Name="Uasin Gishu", Type="County" },
            new(){ Code ="45", LocalName="Vihiga", Name="Vihiga", Type="County" },
            new(){ Code ="46", LocalName="Wajir", Name="Wajir", Type="County" },
            new(){ Code ="47", LocalName="West Pokot", Name="West Pokot", Type="County" }

        });
    }
}
