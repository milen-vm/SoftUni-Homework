namespace XMLProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    class Program
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            ExtractAlbumNames(doc);

            ExtractAllArtistsAlphabetically(doc);

            ExtractArtistsandNumberOfAlbumsDomParser(doc);

            ExtractArtistsandNumberOfAlbumsXpath(doc);

            CreateCheapAlbumsCatalog(doc);

            ExtractAlbumsPublishedSomeYearsAgo(5);

            ExtractAlbumsPublishedSomeYearsAgoLINQToXML(5);
        }

        private static void ExtractAlbumNames(XmlDocument doc)
        {
            PrintTaskHeader("Problem 2. DOM Parser: Extract Album Names", 42);

            var albumNodes = doc.DocumentElement.ChildNodes;
            foreach (XmlNode albumNode in albumNodes)
            {
                Console.WriteLine(albumNode["name"].InnerText);
            }
        }

        private static void ExtractAllArtistsAlphabetically(XmlDocument doc)
        {
            PrintTaskHeader("Problem 3. DOM Parser: Extract All Artists Alphabetically", 57);

            var albumNodes = doc.DocumentElement.ChildNodes;
            var artistNames = new SortedSet<string>();
            foreach (XmlNode albumNode in albumNodes)
            {
                var artistName = albumNode["artist"].InnerText;
                artistNames.Add(artistName);
            }

            Console.WriteLine(string.Join("\n", artistNames));
        }

        private static void ExtractArtistsandNumberOfAlbumsDomParser(XmlDocument doc)
        {
            PrintTaskHeader("Problem 4. DOM Parser: Extract Artists and Number of Albums", 59);

            var albumNodes = doc.DocumentElement.ChildNodes;
            var artistAlbumsCount = new Dictionary<string, int>();
            foreach (XmlNode albumNode in albumNodes)
            {
                var artistName = albumNode["artist"].InnerText;
                if (!artistAlbumsCount.ContainsKey(artistName))
                {
                    artistAlbumsCount.Add(artistName, 0);
                }

                ++artistAlbumsCount[artistName];
            }

            foreach (var artist in artistAlbumsCount)
            {
                Console.WriteLine("{0} - {1}", artist.Key, artist.Value);
            }
        }

        private static void ExtractArtistsandNumberOfAlbumsXpath(XmlDocument doc)
        {
            PrintTaskHeader("Problem 5. XPath: Extract Artists and Number of Albums", 54);

            var artistNodes = doc.SelectNodes("/music-catalog/album/artist");
            var artistAlbumsCount = new Dictionary<string, int>();
            foreach (XmlNode artistNode in artistNodes)
            {
                var artistName = artistNode.InnerText;
                if (!artistAlbumsCount.ContainsKey(artistName))
                {
                    artistAlbumsCount.Add(artistName, 0);
                }

                ++artistAlbumsCount[artistName];
            }

            foreach (var artist in artistAlbumsCount)
            {
                Console.WriteLine("{0} - {1}", artist.Key, artist.Value);
            }
        }

        private static void CreateCheapAlbumsCatalog(XmlDocument doc)
        {
            PrintTaskHeader("Problem 6. Cheap Albums", 23);

            string culture = doc.DocumentElement.Attributes["culture"].Value;
            CultureInfo numberFormat = new CultureInfo(culture);

            XmlNodeList albumNodes = doc.DocumentElement.ChildNodes;
            int count = 0;
            for (int i = albumNodes.Count - 1; i >= 0; i--)
            {
                var albumPrice = Decimal.Parse(albumNodes[i]["price"].InnerText, numberFormat);
                if (albumPrice > 20.0m)
                {
                    albumNodes[i].ParentNode.RemoveChild(albumNodes[i]);
                    ++count;
                }
            }

            doc.Save("../../cheap-albums-catalog.xml");
            Console.WriteLine("{0} albums with prise over 20", count);
        }

        private static void ExtractAlbumsPublishedSomeYearsAgo(int years)
        {
            PrintTaskHeader("Problem 7. DOM Parser and XPath: Old Albums", 43);

            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            var currentYear = DateTime.Now.Year;
            var albumNodes = doc.SelectNodes("/music-catalog/album");

            foreach (XmlNode albumNode in albumNodes)
            {
                int albumYear = int.Parse(albumNode["year"].InnerText);
                if (albumYear <= (currentYear - years))
                {
                    Console.WriteLine("Title: {0} Price: {1}",
                        albumNode["name"].InnerText,
                        albumNode["price"].InnerText);
                }
            }
        }

        private static void ExtractAlbumsPublishedSomeYearsAgoLINQToXML(int years)
        {
            PrintTaskHeader("Problem 8. LINQ to XML: Old Albums", 34);

            XDocument doc = XDocument.Load("../../catalog.xml");

            var currentYear = DateTime.Now.Year;
            var albums =
                from album in doc.Descendants("album")
                where int.Parse(album.Element("year").Value) <= currentYear - years
                select new
                {
                    Name = album.Element("name").Value,
                    Price = album.Element("price").Value
                };
            // the same with lambda expresions
                doc.Elements("albums").Elements("album")
                .Where(p => int.Parse(p.Element("year").Value) <= DateTime.Now.Year - years)
                .Select(a => new
                {
                    Title = a.Element("name").Value,
                    Price = decimal.Parse(a.Element("price").Value)
                });

            foreach (var album in albums)
            {
                Console.WriteLine("Title: {0} Price: {1}", album.Name, album.Price);
            }
        }

        private static void PrintTaskHeader(string headerContent, int count)
        {
            Console.WriteLine("\n{0}", headerContent);
            Console.WriteLine(new string('-', count));
        }
    }
}
