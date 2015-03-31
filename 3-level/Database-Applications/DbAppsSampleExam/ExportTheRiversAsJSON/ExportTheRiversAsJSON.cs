namespace ExportTheRiversAsJSON
{
    using System.IO;
    using System.Linq;
    using System.Web.Script.Serialization;

    using EntityFrameworkMappings;

    class ExportTheRiversAsJson
    {
        static void Main()
        {
            var context = new GeographyContext();
            var rivers = context.Rivers
                .OrderByDescending(r => r.Length)
                .Select(r => new
                {
                    r.RiverName,
                    r.Length,
                    Countries = r.Countries
                        .OrderBy(c => c.CountryName)
                        .Select(c => c.CountryName)
                })
                .ToList();

            var jsSerializer = new JavaScriptSerializer();
            var riversJson = jsSerializer.Serialize(rivers);
            File.WriteAllText("../../rivers.json", riversJson);
        }
    }
}
