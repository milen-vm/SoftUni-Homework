namespace ExportMonasteriesByCountryAsXML
{
    using System.Linq;
    using System.Xml.Linq;

    using EntityFrameworkMappings;

    class ExportMonasteriesByCountryAsXml
    {
        static void Main()
        {
            var context = new GeographyContext();
            var countries = context.Countries
                .Where(c => c.Monasteries.Any())
                .OrderBy(c => c.CountryName)
                .Select(c => new
                {
                    c.CountryName,
                    Monasteries = c.Monasteries
                        .OrderBy(m => m.Name)
                        .Select(m => m.Name)
                })
                .ToList();

            var xmlMonasteries = new XElement("monasteries");
            foreach (var country in countries)
            {
                var xmlCountry = new XElement("country");
                xmlCountry.Add(new XAttribute("name", country.CountryName));

                foreach (var monastery in country.Monasteries)
                {
                    var xmlMonastery = new XElement("monastery", monastery);
                    xmlCountry.Add(xmlMonastery);
                }

                xmlMonasteries.Add(xmlCountry);
            }

            var xmlDoc = new XDocument();
            xmlDoc.Add(xmlMonasteries);
            xmlDoc.Save("../../monasteries.xml");
        }
    }
}
