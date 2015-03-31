namespace ProcessingJson
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml.Linq;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Formatting = Newtonsoft.Json.Formatting;

    class Program
    {
        static void Main()
        {
            // Problem 1.	Download the content of the SoftUni RSS feed
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(@"https://softuni.bg/Feed/News", "../../news.xml");

            XDocument newsXml = XDocument.Load("../../news.xml");

            // Problem 2.	Parse the XML from the feed to JSON
            string newsJson = JsonConvert.SerializeXNode(newsXml, Formatting.Indented);
            //Console.WriteLine(newsJson);

            // Problem 3.	Using LINQ-to-JSON select all the question titles and print them to the console
            var newsJsonObj = JObject.Parse(newsJson);
            var newsTitles = newsJsonObj["rss"]["channel"]["item"]
                .Select(item => item["title"])
                .ToList();

            Console.OutputEncoding = Encoding.UTF8;
            foreach (var title in newsTitles)
            {
                Console.WriteLine(title);
            }

            Console.WriteLine();

            // Problem 4.	Parse the JSON string to POCO
            var news = newsJsonObj["rss"]["channel"]["item"]
                .Select(n =>
                    JsonConvert.DeserializeObject<NewsItem>(n.ToString()))
                .ToList();

            //Console.WriteLine(string.Join("\n", news));

            // Problem 5.	Using the parsed objects create a HTML page that lists all questions from the RSS
            // their categories and a link to the question’s page
            CreateHtmlFile(news);
        }

        private static void CreateHtmlFile(List<NewsItem> news)
        {
            var result = new StringBuilder();
            result.Append("<!DOCTYPE html><html><head><meta charset=\"UTF-8\"/></head><body>");
            foreach (var newsItem in news)
            {
                result.Append(newsItem.ToString());
                result.Append("\n");
            }

            result.Append("</body></html>");
            File.WriteAllText("../../news-items.html", result.ToString());
        }
    }
}
