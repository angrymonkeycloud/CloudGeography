using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsDZ()
    {
        AddSubdivisions("DZ", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Adrar", Name="Adrar", Type="Province" },
            new(){ Code ="44", LocalName="Aïn Defla", Name="Aïn Defla", Type="Province" },
            new(){ Code ="46", LocalName="Aïn Témouchent", Name="Aïn Témouchent", Type="Province" },
            new(){ Code ="16", LocalName="Alger", Name="Alger", Type="Province" },
            new(){ Code ="23", LocalName="Annaba", Name="Annaba", Type="Province" },
            new(){ Code ="5", LocalName="Batna", Name="Batna", Type="Province" },
            new(){ Code ="8", LocalName="Béchar", Name="Béchar", Type="Province" },
            new(){ Code ="6", LocalName="Béjaïa", Name="Béjaïa", Type="Province" },
            new(){ Code ="7", LocalName="Biskra", Name="Biskra", Type="Province" },
            new(){ Code ="9", LocalName="Blida", Name="Blida", Type="Province" },
            new(){ Code ="34", LocalName="Bordj Bou Arréridj", Name="Bordj Bou Arréridj", Type="Province" },
            new(){ Code ="10", LocalName="Bouira", Name="Bouira", Type="Province" },
            new(){ Code ="35", LocalName="Boumerdès", Name="Boumerdès", Type="Province" },
            new(){ Code ="2", LocalName="Chlef", Name="Chlef", Type="Province" },
            new(){ Code ="25", LocalName="Constantine", Name="Constantine", Type="Province" },
            new(){ Code ="17", LocalName="Djelfa", Name="Djelfa", Type="Province" },
            new(){ Code ="32", LocalName="El Bayadh", Name="El Bayadh", Type="Province" },
            new(){ Code ="39", LocalName="El Oued", Name="El Oued", Type="Province" },
            new(){ Code ="36", LocalName="El Tarf", Name="El Tarf", Type="Province" },
            new(){ Code ="47", LocalName="Ghardaïa", Name="Ghardaïa", Type="Province" },
            new(){ Code ="24", LocalName="Guelma", Name="Guelma", Type="Province" },
            new(){ Code ="33", LocalName="Illizi", Name="Illizi", Type="Province" },
            new(){ Code ="18", LocalName="Jijel", Name="Jijel", Type="Province" },
            new(){ Code ="40", LocalName="Khenchela", Name="Khenchela", Type="Province" },
            new(){ Code ="3", LocalName="Laghouat", Name="Laghouat", Type="Province" },
            new(){ Code ="29", LocalName="Mascara", Name="Mascara", Type="Province" },
            new(){ Code ="26", LocalName="Médéa", Name="Médéa", Type="Province" },
            new(){ Code ="43", LocalName="Mila", Name="Mila", Type="Province" },
            new(){ Code ="27", LocalName="Mostaganem", Name="Mostaganem", Type="Province" },
            new(){ Code ="28", LocalName="M'sila", Name="M'sila", Type="Province" },
            new(){ Code ="45", LocalName="Naama", Name="Naama", Type="Province" },
            new(){ Code ="31", LocalName="Oran", Name="Oran", Type="Province" },
            new(){ Code ="30", LocalName="Ouargla", Name="Ouargla", Type="Province" },
            new(){ Code ="4", LocalName="Oum el Bouaghi", Name="Oum el Bouaghi", Type="Province" },
            new(){ Code ="48", LocalName="Relizane", Name="Relizane", Type="Province" },
            new(){ Code ="20", LocalName="Saïda", Name="Saïda", Type="Province" },
            new(){ Code ="19", LocalName="Sétif", Name="Sétif", Type="Province" },
            new(){ Code ="22", LocalName="Sidi Bel Abbès", Name="Sidi Bel Abbès", Type="Province" },
            new(){ Code ="21", LocalName="Skikda", Name="Skikda", Type="Province" },
            new(){ Code ="41", LocalName="Souk Ahras", Name="Souk Ahras", Type="Province" },
            new(){ Code ="11", LocalName="Tamanrasset", Name="Tamanrasset", Type="Province" },
            new(){ Code ="12", LocalName="Tébessa", Name="Tébessa", Type="Province" },
            new(){ Code ="14", LocalName="Tiaret", Name="Tiaret", Type="Province" },
            new(){ Code ="37", LocalName="Tindouf", Name="Tindouf", Type="Province" },
            new(){ Code ="42", LocalName="Tipaza", Name="Tipaza", Type="Province" },
            new(){ Code ="38", LocalName="Tissemsilt", Name="Tissemsilt", Type="Province" },
            new(){ Code ="15", LocalName="Tizi Ouzou", Name="Tizi Ouzou", Type="Province" },
            new(){ Code ="13", LocalName="Tlemcen", Name="Tlemcen", Type="Province" }

        });
    }
}
