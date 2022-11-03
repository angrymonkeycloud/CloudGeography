using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsTN()
    {
        AddSubdivisions("TN", new List<Subdivision>()
        {
            new(){ Code ="31", LocalName="Béja", Name="Béja", Type="Governorate" },
            new(){ Code ="13", LocalName="Ben Arous", Name="Ben Arous", Type="Governorate" },
            new(){ Code ="23", LocalName="Bizerte", Name="Bizerte", Type="Governorate" },
            new(){ Code ="81", LocalName="Gabès", Name="Gabès", Type="Governorate" },
            new(){ Code ="71", LocalName="Gafsa", Name="Gafsa", Type="Governorate" },
            new(){ Code ="32", LocalName="Jendouba", Name="Jendouba", Type="Governorate" },
            new(){ Code ="41", LocalName="Kairouan", Name="Kairouan", Type="Governorate" },
            new(){ Code ="42", LocalName="Kasserine", Name="Kasserine", Type="Governorate" },
            new(){ Code ="73", LocalName="Kébili", Name="Kébili", Type="Governorate" },
            new(){ Code ="14", LocalName="La Manouba", Name="La Manouba", Type="Governorate" },
            new(){ Code ="12", LocalName="L'Ariana", Name="L'Ariana", Type="Governorate" },
            new(){ Code ="33", LocalName="Le Kef", Name="Le Kef", Type="Governorate" },
            new(){ Code ="53", LocalName="Mahdia", Name="Mahdia", Type="Governorate" },
            new(){ Code ="82", LocalName="Médenine", Name="Médenine", Type="Governorate" },
            new(){ Code ="52", LocalName="Monastir", Name="Monastir", Type="Governorate" },
            new(){ Code ="21", LocalName="Nabeul", Name="Nabeul", Type="Governorate" },
            new(){ Code ="61", LocalName="Sfax", Name="Sfax", Type="Governorate" },
            new(){ Code ="43", LocalName="Sidi Bouzid", Name="Sidi Bouzid", Type="Governorate" },
            new(){ Code ="34", LocalName="Siliana", Name="Siliana", Type="Governorate" },
            new(){ Code ="51", LocalName="Sousse", Name="Sousse", Type="Governorate" },
            new(){ Code ="83", LocalName="Tataouine", Name="Tataouine", Type="Governorate" },
            new(){ Code ="72", LocalName="Tozeur", Name="Tozeur", Type="Governorate" },
            new(){ Code ="11", LocalName="Tunis", Name="Tunis", Type="Governorate" },
            new(){ Code ="22", LocalName="Zaghouan", Name="Zaghouan", Type="Governorate" }

        });
    }
}
