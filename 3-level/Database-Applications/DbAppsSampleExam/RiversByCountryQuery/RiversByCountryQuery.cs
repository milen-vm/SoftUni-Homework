namespace RiversByCountryQuery
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using System.Xml.XPath;
    using EntityFrameworkMappings;

    class RiversByCountryQuery
    {
        static void Main()
        {
            var xmlDoc = XDocument.Load("../../rivers-query.xml");
            var queryNodes = xmlDoc.XPathSelectElements("/queries/query");

            var xmlResults = new XElement("results");
            foreach (var queryNode in queryNodes)
            {
                var maxResults = GetXmlElementAttributeValue(queryNode, "max-results");
                var countriesList = GetXmlElementColectionValue(queryNode, "country");
                var rivers = GetRiverNamesForAllCountries(countriesList);

                var xmlRivers = new XElement("rivers");
                var totalCount = rivers.Count;
                xmlRivers.Add(new XAttribute("total-count", totalCount));

                var listedCount = (maxResults == null || totalCount < maxResults) ? totalCount : maxResults;
                xmlRivers.Add(new XAttribute("listed-count", listedCount));

                for (int i = 0; i < listedCount; i++)
                {
                    var xmlRiver = new XElement("river", rivers[i]);
                    xmlRivers.Add(xmlRiver);
                }

                xmlResults.Add(xmlRivers);
            }

            var xmlDocResults = new XDocument();
            xmlDocResults.Add(xmlResults);
            xmlDocResults.Save("../../result-rivers.xml");
        }

        private static List<string> GetRiverNamesForAllCountries(List<string> countriesList)
        {
            var context = new GeographyContext();

            var rivers = context.Rivers
                .OrderBy(r => r.RiverName)
                .Where(r => countriesList.All(name => r.Countries.Any(c => c.CountryName == name)))
                .Select(r => r.RiverName)
                .ToList();

            return rivers;
        }

        private static List<string> GetXmlElementColectionValue(XElement queryNode, string elementName)
        {
            var countries = new List<string>();
            if (queryNode.Element(elementName) != null)
            {
                var countriesNode = queryNode.XPathSelectElements(elementName);
                countries = countriesNode.Select(c => c.Value).ToList();
            }

            return countries;
        }

        private static int? GetXmlElementAttributeValue(XElement queryNode, string attributeName)
        {
            int? value = null;
            if (queryNode.Attribute(attributeName) != null)
            {
                value = int.Parse(queryNode.Attribute(attributeName).Value);
            }

            return value;
        }
    }
}
