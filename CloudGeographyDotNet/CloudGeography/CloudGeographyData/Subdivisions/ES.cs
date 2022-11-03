using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsES()
    {
        AddSubdivisions("ES", new List<Subdivision>()
        {
            new(){ Code ="C", LocalName="A Coruña", Name="A Coruña", Type="Province" },
            new(){ Code ="VI", LocalName="Álava / Araba", Name="Álava / Araba", Type="Province" },
            new(){ Code ="AB", LocalName="Albacete", Name="Albacete", Type="Province" },
            new(){ Code ="A", LocalName="Alicante / Alacant", Name="Alicante / Alacant", Type="Province" },
            new(){ Code ="AL", LocalName="Almería", Name="Almería", Type="Province" },
            new(){ Code ="O", LocalName="Asturias", Name="Asturias", Type="Province" },
            new(){ Code ="AV", LocalName="Ávila", Name="Ávila", Type="Province" },
            new(){ Code ="BA", LocalName="Badajoz", Name="Badajoz", Type="Province" },
            new(){ Code ="PM", LocalName="Balears", Name="Balears", Type="Province" },
            new(){ Code ="B", LocalName="Barcelona", Name="Barcelona", Type="Province" },
            new(){ Code ="BI", LocalName="Biskaia", Name="Biskaia", Type="Province" },
            new(){ Code ="BU", LocalName="Burgos", Name="Burgos", Type="Province" },
            new(){ Code ="CC", LocalName="Cáceres", Name="Cáceres", Type="Province" },
            new(){ Code ="CA", LocalName="Cádiz", Name="Cádiz", Type="Province" },
            new(){ Code ="S", LocalName="Cantabria", Name="Cantabria", Type="Province" },
            new(){ Code ="CS", LocalName="Castellón / Castelló", Name="Castellón / Castelló", Type="Province" },
            new(){ Code ="CR", LocalName="Ciudad Real", Name="Ciudad Real", Type="Province" },
            new(){ Code ="CO", LocalName="Córdoba", Name="Córdoba", Type="Province" },
            new(){ Code ="CU", LocalName="Cuenca", Name="Cuenca", Type="Province" },
            new(){ Code ="SS", LocalName="Gipuzkoa", Name="Gipuzkoa", Type="Province" },
            new(){ Code ="GI", LocalName="Girona", Name="Girona", Type="Province" },
            new(){ Code ="GR", LocalName="Granada", Name="Granada", Type="Province" },
            new(){ Code ="GU", LocalName="Guadalajara", Name="Guadalajara", Type="Province" },
            new(){ Code ="H", LocalName="Huelva", Name="Huelva", Type="Province" },
            new(){ Code ="HU", LocalName="Huesca", Name="Huesca", Type="Province" },
            new(){ Code ="J", LocalName="Jaén", Name="Jaén", Type="Province" },
            new(){ Code ="LO", LocalName="La Rioja", Name="La Rioja", Type="Province" },
            new(){ Code ="GC", LocalName="Las Palmas", Name="Las Palmas", Type="Province" },
            new(){ Code ="LE", LocalName="León", Name="León", Type="Province" },
            new(){ Code ="L", LocalName="Lleida", Name="Lleida", Type="Province" },
            new(){ Code ="LU", LocalName="Lugo", Name="Lugo", Type="Province" },
            new(){ Code ="M", LocalName="Madrid", Name="Madrid", Type="Province" },
            new(){ Code ="MA", LocalName="Málaga", Name="Málaga", Type="Province" },
            new(){ Code ="MU", LocalName="Murcia", Name="Murcia", Type="Province" },
            new(){ Code ="NA", LocalName="Navarra / Nafarroa", Name="Navarra / Nafarroa", Type="Province" },
            new(){ Code ="OR", LocalName="Ourense", Name="Ourense", Type="Province" },
            new(){ Code ="P", LocalName="Palencia", Name="Palencia", Type="Province" },
            new(){ Code ="PO", LocalName="Pontevedra", Name="Pontevedra", Type="Province" },
            new(){ Code ="SA", LocalName="Salamanca", Name="Salamanca", Type="Province" },
            new(){ Code ="TF", LocalName="Santa Cruz de Tenerife", Name="Santa Cruz de Tenerife", Type="Province" },
            new(){ Code ="SG", LocalName="Segovia", Name="Segovia", Type="Province" },
            new(){ Code ="SE", LocalName="Sevilla", Name="Sevilla", Type="Province" },
            new(){ Code ="SO", LocalName="Soria", Name="Soria", Type="Province" },
            new(){ Code ="T", LocalName="Tarragona", Name="Tarragona", Type="Province" },
            new(){ Code ="TE", LocalName="Teruel", Name="Teruel", Type="Province" },
            new(){ Code ="TO", LocalName="Toledo", Name="Toledo", Type="Province" },
            new(){ Code ="V", LocalName="Valencia / València", Name="Valencia / València", Type="Province" },
            new(){ Code ="VA", LocalName="Valladolid", Name="Valladolid", Type="Province" },
            new(){ Code ="ZA", LocalName="Zamora", Name="Zamora", Type="Province" },
            new(){ Code ="Z", LocalName="Zaragoza", Name="Zaragoza", Type="Province" }

        });
    }
}
