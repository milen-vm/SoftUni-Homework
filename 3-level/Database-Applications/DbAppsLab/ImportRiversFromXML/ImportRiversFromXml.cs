namespace ImportRiversFromXML
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using System.Xml.XPath;
    using EFMappings;

    class ImportRiversFromXml
    {
        static void Main()
        {
            var geographyDb = new GeographyEntities();
            Console.WriteLine(geographyDb.Rivers.Count());

            var xmlDoc = XDocument.Load("../../rivers.xml");
            //Console.WriteLine(xmlDoc);

            var riverNodes = xmlDoc.XPathSelectElements("/rivers/river");
            foreach (var riverNode in riverNodes)
            {
                //Console.WriteLine(riverNode);
                string riverName = riverNode.Element("name").Value;
                int riverLength = int.Parse(riverNode.Element("length").Value);
                string riverOutflow = riverNode.Element("outflow").Value;

                int? drainageArea = null;
                if (riverNode.Element("drainage-area") != null)
                {
                    drainageArea = int.Parse(riverNode.Element("drainage-area").Value);
                }

                int? averageDischarge = null;
                if (riverNode.Element("average-discharge") != null)
                {
                    averageDischarge = int.Parse(riverNode.Element("average-discharge").Value);
                }

                var countriesList = new List<string>();
                if (riverNode.Element("countries") != null)
                {
                    //var countries = riverNode.Element("countries").Descendants();
                    //countriesList.AddRange(countries.Select(country => country.Value));

                    var countryNodes = riverNode.XPathSelectElements("countries/country");
                    countriesList = countryNodes.Select(c => c.Value).ToList();
                }

                Console.WriteLine("{0} - {1}km, {2}, {3}km^2,  {4}m^3\n{5}", riverName, riverLength, riverOutflow,
                    drainageArea, averageDischarge, string.Join(", ", countriesList));
                Console.WriteLine();

                var river = new River()
                {
                    RiverName = riverName,
                    Length = riverLength,
                    Outflow = riverOutflow,
                    DrainageArea = drainageArea,
                    AverageDischarge = averageDischarge
                };

                foreach (var countryName in countriesList)
                {
                    var country = geographyDb.Countries
                        .FirstOrDefault(c => c.CountryName == countryName);
                    river.Countries.Add(country);
                }

                geographyDb.Rivers.Add(river);
                geographyDb.SaveChanges();
            }
        }
    }
}
