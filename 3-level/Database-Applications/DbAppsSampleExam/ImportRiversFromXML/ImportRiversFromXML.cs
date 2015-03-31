namespace ImportRiversFromXML
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using System.Xml.XPath;
    using EntityFrameworkMappings;

    class ImportRiversFromXml
    {
        static void Main()
        {
            var xmlDoc = XDocument.Load("../../rivers.xml");
            var riverNodes = xmlDoc.XPathSelectElements("/rivers/river");

            foreach (var riverNode in riverNodes)
            {
                var name = riverNode.Element("name").Value;
                var length = int.Parse(riverNode.Element("length").Value);
                var outflow = riverNode.Element("outflow").Value;

                int? drainageArea = GetXmlElementIntValue(riverNode, "drainage-area");
                int? averageDischarge = GetXmlElementIntValue(riverNode, "average-discharge");
                var countriesList = GetXmlElementColectionValue(riverNode, "countries");

                var river = new River()
                {
                    RiverName = name,
                    Length = length,
                    Outflow = outflow,
                    DrainageArea = drainageArea,
                    AverageDischarge = averageDischarge
                };

                var context = new GeographyContext();
                foreach (var countryName in countriesList)
                {
                    var country = context.Countries
                        .FirstOrDefault(c => c.CountryName == countryName);
                    river.Countries.Add(country);
                }

                context.Rivers.Add(river);
                context.SaveChanges();
            }
        }

        private static List<string> GetXmlElementColectionValue(XElement riverNode, string elementName)
        {
            var countries = new List<string>();
            if (riverNode.Element(elementName) != null)
            {
                var countryNodes = riverNode.XPathSelectElements("countries/country");
                countries = countryNodes.Select(c => c.Value).ToList();
            }

            return countries;
        }

        private static int? GetXmlElementIntValue(XElement riverNode, string elementName)
        {
            if (riverNode.Element(elementName) != null)
            {
                string value = riverNode.Element(elementName).Value;
                return int.Parse(value);
            }

            return null;
        }
    }
}
