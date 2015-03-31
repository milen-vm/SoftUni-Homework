using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EFMappings;

namespace ExportMonasteriesAsXML
{
    class ExportMonasteriesAsXml
    {
        static void Main()
        {
            var geographyDb = new GeographyEntities();
            foreach (var monastery in geographyDb.Monasteries)
            {
                Console.WriteLine(monastery.Name);
            }

            var countries = geographyDb.Countries
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

            foreach (var country in countries)
            {
                Console.WriteLine(country.CountryName);
                Console.WriteLine(string.Join(", ", country.Monasteries));
                Console.WriteLine();
            }

            var xmlMonasteries = new XElement("monasteries");

            foreach (var country in countries)
            {
                var xmlCountry = new XElement("country");
                xmlCountry.Add(new XAttribute("name", country.CountryName));

                foreach (var monastery in country.Monasteries)
                {
                    var xmlMonastry = new XElement("monasterry", monastery);
                    xmlCountry.Add(xmlMonastry);
                }

                xmlMonasteries.Add(xmlCountry);
            }

            Console.WriteLine(xmlMonasteries);

            var xmlDoc = new XDocument(xmlMonasteries);
            xmlDoc.Save("../../monasteries.xml");
        }
    }
}
