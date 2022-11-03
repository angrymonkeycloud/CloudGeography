using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsMD()
    {
        AddSubdivisions("MD", new List<Subdivision>()
        {
            new(){ Code ="AN", LocalName="Raionul Anenii Noi", Name="Anenii Noi", Type="District" },
            new(){ Code ="BA", LocalName="Balti", Name="Balti", Type="Municipality" },
            new(){ Code ="BS", LocalName="Basarabeasca", Name="Basarabeasca", Type="District" },
            new(){ Code ="BD", LocalName="Bendery", Name="Bender", Type="Municipality" },
            new(){ Code ="BR", LocalName="Briceni", Name="Briceni", Type="District" },
            new(){ Code ="CA", LocalName="Cahul", Name="Cahul", Type="District" },
            new(){ Code ="CL", LocalName="Calarasi", Name="Calarasi", Type="District" },
            new(){ Code ="CT", LocalName="Cantemir", Name="Cantemir", Type="District" },
            new(){ Code ="CS", LocalName="Causeni", Name="Causeni", Type="District" },
            new(){ Code ="CU", LocalName="Chisinau", Name="Chisinau", Type="Municipality" },
            new(){ Code ="CM", LocalName="Cimislia", Name="Cimislia", Type="District" },
            new(){ Code ="CR", LocalName="Criuleni", Name="Criuleni", Type="District" },
            new(){ Code ="DO", LocalName="Donduseni", Name="Donduseni", Type="District" },
            new(){ Code ="DR", LocalName="Drochia", Name="Drochia", Type="District" },
            new(){ Code ="DU", LocalName="Dubasari", Name="Dubasari", Type="District" },
            new(){ Code ="ED", LocalName="Edinet", Name="Edinet", Type="District" },
            new(){ Code ="FA", LocalName="Falesti", Name="Falesti", Type="District" },
            new(){ Code ="FL", LocalName="Floresti", Name="Floresti", Type="District" },
            new(){ Code ="GZ", LocalName="Găgăuzia", Name="Gagauzia", Type="Territory" },
            new(){ Code ="GL", LocalName="Glodeni", Name="Glodeni", Type="District" },
            new(){ Code ="HI", LocalName="Hîncesti", Name="Hîncesti", Type="District" },
            new(){ Code ="IA", LocalName="Ialoveni", Name="Ialoveni", Type="District" },
            new(){ Code ="LE", LocalName="Leova", Name="Leova", Type="District" },
            new(){ Code ="NI", LocalName="Nisporeni", Name="Nisporeni", Type="District" },
            new(){ Code ="OC", LocalName="Ocniþa", Name="Ocniþa", Type="District" },
            new(){ Code ="OR", LocalName="Orhei", Name="Orhei", Type="District" },
            new(){ Code ="RE", LocalName="Rezina", Name="Rezina", Type="District" },
            new(){ Code ="RI", LocalName="Rîscani", Name="Rîscani", Type="District" },
            new(){ Code ="SI", LocalName="Sîngerei", Name="Sîngerei", Type="District" },
            new(){ Code ="SD", LocalName="Soldanesti", Name="Soldanesti", Type="District" },
            new(){ Code ="SO", LocalName="Soroca", Name="Soroca", Type="District" },
            new(){ Code ="SV", LocalName="Stefan Voda", Name="Stefan Voda", Type="District" },
            new(){ Code ="SN", LocalName="Stînga Nistrului", Name="Stînga Nistrului", Type="Territory" },
            new(){ Code ="ST", LocalName="Straseni", Name="Straseni", Type="District" },
            new(){ Code ="TA", LocalName="Taraclia", Name="Taraclia", Type="District" },
            new(){ Code ="TE", LocalName="Telenesti", Name="Telenesti", Type="District" },
            new(){ Code ="UN", LocalName="Ungheni", Name="Ungheni", Type="District" }

        });
    }
}
