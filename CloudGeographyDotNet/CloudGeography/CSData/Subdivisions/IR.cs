using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsIR()
    {
        AddSubdivisions("IR", new List<Subdivision>()
        {
            new(){ Code ="32", LocalName="البرز", Name="Alborz", Type="Province" },
            new(){ Code ="3", LocalName="اردبیل", Name="Ardabil", Type="Province" },
            new(){ Code ="6", LocalName="بوشهر", Name="Bushehr", Type="Province" },
            new(){ Code ="8", LocalName="چهارمحال و بختیاری", Name="Chahar Mahaal and Bakhtiari", Type="Province" },
            new(){ Code ="1", LocalName="آذربایجان شرقی", Name="East Azerbaijan", Type="Province" },
            new(){ Code ="14", LocalName="پارس", Name="Fars", Type="Province" },
            new(){ Code ="19", LocalName="گیلان", Name="Gilan", Type="Province" },
            new(){ Code ="27", LocalName="گلستان", Name="Golestan", Type="Province" },
            new(){ Code ="24", LocalName="همدان", Name="Hamadan", Type="Province" },
            new(){ Code ="23", LocalName="هرمزگان", Name="Hormozgan", Type="Province" },
            new(){ Code ="5", LocalName="ایلام", Name="Ilam", Type="Province" },
            new(){ Code ="4", LocalName="اصفهان", Name="Isfahan", Type="Province" },
            new(){ Code ="15", LocalName="کرمان", Name="Kerman", Type="Province" },
            new(){ Code ="17", LocalName="کرمانشاه", Name="Kermanshah", Type="Province" },
            new(){ Code ="10", LocalName="خوزستان", Name="Khuzestan", Type="Province" },
            new(){ Code ="18", LocalName=" کهگیلویه و بویراحمد", Name="Kohgiluyeh and Boyer-Ahmad ", Type="Province" },
            new(){ Code ="16", LocalName="کردستان", Name="Kordestan", Type="Province" },
            new(){ Code ="20", LocalName="لرستان", Name="Lorestan", Type="Province" },
            new(){ Code ="22", LocalName="مرکزی", Name="Markazi", Type="Province" },
            new(){ Code ="21", LocalName="مازندران", Name="Mazandaran", Type="Province" },
            new(){ Code ="31", LocalName="خراسان شمالی", Name="North Khorasan", Type="Province" },
            new(){ Code ="28", LocalName="قزوین", Name="Qazvin", Type="Province" },
            new(){ Code ="26", LocalName="قم", Name="Qom", Type="Province" },
            new(){ Code ="30", LocalName="خراسان رضوی", Name="Razavi Khorasan", Type="Province" },
            new(){ Code ="12", LocalName="سمنان", Name="Semnan", Type="Province" },
            new(){ Code ="13", LocalName="سیستان و بلوچستان", Name="Sistan va Baluchestan", Type="Province" },
            new(){ Code ="29", LocalName="خراسان جنوبی", Name="South Khorasan", Type="Province" },
            new(){ Code ="7", LocalName="تهران", Name="Tehran", Type="Province" },
            new(){ Code ="2", LocalName="آذربایجان غربی", Name="West Azerbaijan", Type="Province" },
            new(){ Code ="25", LocalName="یزد", Name="Yazd", Type="Province" },
            new(){ Code ="11", LocalName="زنجان", Name="Zanjan", Type="Province" }

        });
    }
}
