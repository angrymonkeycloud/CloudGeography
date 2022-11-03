using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsBG()
    {
        AddSubdivisions("BG", new List<Subdivision>()
        {
            new(){ Code ="1", LocalName="Благоевград", Name="Blagoevgrad", Type="Province" },
            new(){ Code ="2", LocalName="Бургас", Name="Burgas", Type="Province" },
            new(){ Code ="8", LocalName="Добрич", Name="Dobrich", Type="Province" },
            new(){ Code ="7", LocalName="Габрово", Name="Gabrovo", Type="Province" },
            new(){ Code ="26", LocalName="Хасково", Name="Haskovo", Type="Province" },
            new(){ Code ="9", LocalName="Кърджали", Name="Kardzhali", Type="Province" },
            new(){ Code ="10", LocalName="Кюстендил", Name="Kyustendil", Type="Province" },
            new(){ Code ="11", LocalName="Ловеч", Name="Lovech", Type="Province" },
            new(){ Code ="12", LocalName="Монтана", Name="Montana", Type="Province" },
            new(){ Code ="13", LocalName="Пазарджик", Name="Pazardzik", Type="Province" },
            new(){ Code ="14", LocalName="Перник", Name="Pernik", Type="Province" },
            new(){ Code ="15", LocalName="Плевен", Name="Pleven", Type="Province" },
            new(){ Code ="16", LocalName="Пловдив", Name="Plovdiv", Type="Province" },
            new(){ Code ="17", LocalName="Разград", Name="Razgrad", Type="Province" },
            new(){ Code ="18", LocalName="Русе", Name="Ruse", Type="Province" },
            new(){ Code ="27", LocalName="Шумен", Name="Shumen", Type="Province" },
            new(){ Code ="19", LocalName="Шумен", Name="Silistra", Type="Province" },
            new(){ Code ="20", LocalName="Сливен", Name="Sliven", Type="Province" },
            new(){ Code ="21", LocalName="Смолян", Name="Smolyan", Type="Province" },
            new(){ Code ="23", LocalName="Софийска", Name="Sofia", Type="Province" },
            new(){ Code ="22", LocalName="София-град", Name="Sofia City", Type="Province" },
            new(){ Code ="24", LocalName="Стара Загора", Name="Stara Zagora", Type="Province" },
            new(){ Code ="25", LocalName="Търговище", Name="Targovishte", Type="Province" },
            new(){ Code ="3", LocalName="Варна", Name="Varna", Type="Province" },
            new(){ Code ="4", LocalName="Велико Търново", Name="Veliko Tarnovo", Type="Province" },
            new(){ Code ="5", LocalName="Видин", Name="Vidin", Type="Province" },
            new(){ Code ="6", LocalName="Враца", Name="Vratsa", Type="Province" },
            new(){ Code ="28", LocalName="Ямбол", Name="Yambol", Type="Province" }

        });
    }
}
