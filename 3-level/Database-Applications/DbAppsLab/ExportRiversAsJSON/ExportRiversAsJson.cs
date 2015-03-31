namespace ExportRiversAsJSON
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Web.Script.Serialization;
    using EFMappings;

    class ExportRiversAsJson
    {
        static void Main()
        {
            var geographyDb = new GeographyEntities();
            //var rivers = geographyDb.Rivers;

            //foreach (var river in rivers)
            //{
            //    Console.WriteLine(river.RiverName);
            //}

            var rivers = geographyDb.Rivers
                .OrderByDescending(r => r.Length)
                .Select(r =>
                    new
                    {
                        r.RiverName,
                        r.Length,
                        Countries = r.Countries
                            .OrderBy(c => c.CountryName)
                            .Select(c => c.CountryName)
                    })
                .ToList();

            foreach (var river in rivers)
            {
                Console.WriteLine(river.RiverName + " - " + river.Length);
                Console.WriteLine(string.Join(", ", river.Countries));
                Console.WriteLine();
            }

            var jsSerializer = new JavaScriptSerializer();
            var riversJson = jsSerializer.Serialize(rivers);
            Console.WriteLine(riversJson);
            File.WriteAllText("../../rivers.json", riversJson);
        }
    }
}
