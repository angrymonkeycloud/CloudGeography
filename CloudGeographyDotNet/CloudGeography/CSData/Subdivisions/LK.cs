using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsLK()
    {
        AddSubdivisions("LK", new List<Subdivision>()
        {
            new(){ Code ="52", LocalName="Ampara", Name="Ampara", Type="District" },
            new(){ Code ="71", LocalName="Anuradhapura", Name="Anuradhapura", Type="District" },
            new(){ Code ="81", LocalName="Badulla", Name="Badulla", Type="District" },
            new(){ Code ="1", LocalName="Basnahira pa?ata", Name="Basnahira pa?ata", Type="Province" },
            new(){ Code ="51", LocalName="Batticaloa", Name="Batticaloa", Type="District" },
            new(){ Code ="11", LocalName="Colombo", Name="Colombo", Type="District" },
            new(){ Code ="3", LocalName="Daku?u pa?ata", Name="Daku?u pa?ata", Type="Province" },
            new(){ Code ="31", LocalName="Galle", Name="Galle", Type="District" },
            new(){ Code ="12", LocalName="Gampaha", Name="Gampaha", Type="District" },
            new(){ Code ="33", LocalName="Hambantota", Name="Hambantota", Type="District" },
            new(){ Code ="41", LocalName="Jaffna", Name="Jaffna", Type="District" },
            new(){ Code ="13", LocalName="Kalutara", Name="Kalutara", Type="District" },
            new(){ Code ="21", LocalName="Kandy", Name="Kandy", Type="District" },
            new(){ Code ="92", LocalName="Kegalla", Name="Kegalla", Type="District" },
            new(){ Code ="42", LocalName="Kilinochchi", Name="Kilinochchi", Type="District" },
            new(){ Code ="61", LocalName="Kurunegala", Name="Kurunegala", Type="District" },
            new(){ Code ="2", LocalName="Madhyama pa?ata", Name="Madhyama pa?ata", Type="Province" },
            new(){ Code ="43", LocalName="Mannar", Name="Mannar", Type="District" },
            new(){ Code ="22", LocalName="Matale", Name="Matale", Type="District" },
            new(){ Code ="32", LocalName="Matara", Name="Matara", Type="District" },
            new(){ Code ="82", LocalName="Monaragala", Name="Monaragala", Type="District" },
            new(){ Code ="45", LocalName="Mullaittivu", Name="Mullaittivu", Type="District" },
            new(){ Code ="5", LocalName="Næ?genahira pa?ata", Name="Næ?genahira pa?ata", Type="Province" },
            new(){ Code ="23", LocalName="Nuwara Eliya", Name="Nuwara Eliya", Type="District" },
            new(){ Code ="72", LocalName="Polonnaruwa", Name="Polonnaruwa", Type="District" },
            new(){ Code ="62", LocalName="Puttalam", Name="Puttalam", Type="District" },
            new(){ Code ="91", LocalName="Ratnapura", Name="Ratnapura", Type="District" },
            new(){ Code ="9", LocalName="Sabaragamuva pa?ata", Name="Sabaragamuva pa?ata", Type="Province" },
            new(){ Code ="53", LocalName="Trincomalee", Name="Trincomalee", Type="District" },
            new(){ Code ="4", LocalName="Uturu pa?ata", Name="Uturu pa?ata", Type="Province" },
            new(){ Code ="7", LocalName="Uturumæ?da pa?ata", Name="Uturumæ?da pa?ata", Type="Province" },
            new(){ Code ="8", LocalName="Uva pa?ata", Name="Uva pa?ata", Type="Province" },
            new(){ Code ="44", LocalName="Vavuniya", Name="Vavuniya", Type="District" },
            new(){ Code ="6", LocalName="Vayamba pa?ata", Name="Vayamba pa?ata", Type="Province" }

        });
    }
}
