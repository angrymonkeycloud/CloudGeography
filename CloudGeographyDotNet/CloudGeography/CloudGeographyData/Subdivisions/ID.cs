using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsID()
    {
        AddSubdivisions("ID", new List<Subdivision>()
        {
            new(){ Code ="AC", LocalName="Aceh", Name="Aceh", Type="Province" },
            new(){ Code ="BA", LocalName="Bali", Name="Bali", Type="Province" },
            new(){ Code ="BT", LocalName="Banten", Name="Banten", Type="Province" },
            new(){ Code ="BE", LocalName="Bengkulu", Name="Bengkulu", Type="Province" },
            new(){ Code ="GO", LocalName="Gorontalo", Name="Gorontalo", Type="Province" },
            new(){ Code ="JK", LocalName="Jakarta Raya", Name="Jakarta Raya", Type="District" },
            new(){ Code ="JA", LocalName="Jambi", Name="Jambi", Type="Province" },
            new(){ Code ="JB", LocalName="Jawa Barat", Name="Jawa Barat", Type="Province" },
            new(){ Code ="JT", LocalName="Jawa Tengah", Name="Jawa Tengah", Type="Province" },
            new(){ Code ="JI", LocalName="Jawa Timur", Name="Jawa Timur", Type="Province" },
            new(){ Code ="KB", LocalName="Kalimantan Barat", Name="Kalimantan Barat", Type="Province" },
            new(){ Code ="KS", LocalName="Kalimantan Selatan", Name="Kalimantan Selatan", Type="Province" },
            new(){ Code ="KT", LocalName="Kalimantan Tengah", Name="Kalimantan Tengah", Type="Province" },
            new(){ Code ="KI", LocalName="Kalimantan Timur", Name="Kalimantan Timur", Type="Province" },
            new(){ Code ="KU", LocalName="Kalimantan Utara", Name="Kalimantan Utara", Type="Province" },
            new(){ Code ="BB", LocalName="Kepulauan Bangka Belitung", Name="Kepulauan Bangka Belitung", Type="Province" },
            new(){ Code ="KR", LocalName="Kepulauan Riau", Name="Kepulauan Riau", Type="Province" },
            new(){ Code ="LA", LocalName="Lampung", Name="Lampung", Type="Province" },
            new(){ Code ="MA", LocalName="Maluku", Name="Maluku", Type="Province" },
            new(){ Code ="MU", LocalName="Maluku Utara", Name="Maluku Utara", Type="Province" },
            new(){ Code ="NB", LocalName="Nusa Tenggara Barat", Name="Nusa Tenggara Barat", Type="Province" },
            new(){ Code ="NT", LocalName="Nusa Tenggara Timur", Name="Nusa Tenggara Timur", Type="Province" },
            new(){ Code ="PA", LocalName="Papua", Name="Papua", Type="Province" },
            new(){ Code ="PB", LocalName="Papua Barat", Name="Papua Barat", Type="Province" },
            new(){ Code ="RI", LocalName="Riau", Name="Riau", Type="Province" },
            new(){ Code ="SR", LocalName="Sulawesi Barat", Name="Sulawesi Barat", Type="Province" },
            new(){ Code ="SN", LocalName="Sulawesi Selatan", Name="Sulawesi Selatan", Type="Province" },
            new(){ Code ="ST", LocalName="Sulawesi Tengah", Name="Sulawesi Tengah", Type="Province" },
            new(){ Code ="SG", LocalName="Sulawesi Tenggara", Name="Sulawesi Tenggara", Type="Province" },
            new(){ Code ="SA", LocalName="Sulawesi Utara", Name="Sulawesi Utara", Type="Province" },
            new(){ Code ="SB", LocalName="Sumatera Barat", Name="Sumatera Barat", Type="Province" },
            new(){ Code ="SS", LocalName="Sumatera Selatan", Name="Sumatera Selatan", Type="Province" },
            new(){ Code ="SU", LocalName="Sumatera Utara", Name="Sumatera Utara", Type="Province" },
            new(){ Code ="YO", LocalName="Yogyakarta", Name="Yogyakarta", Type="Region" }

        });
    }
}
