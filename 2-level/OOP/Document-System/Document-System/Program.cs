using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_System
{
    class Program
    {
        static void Main()
        {
            Document doc = new Document();
            doc.Title = "My first document.";
            doc.Author = "Nakov";
            doc.Add(new Paragraph("I am a paragraph."));
            doc.Add(new Paragraph("I am another paragraph."));
            Paragraph paragraph = new Paragraph();
            paragraph.Add(new TextElement("Default Font", Font.DefaultFont));
            paragraph.Add(new TextElement("Second Red", new Font(color: Color.Red)));
            paragraph.Add(new TextElement("Green Italic", new Font(color: Color.Green, style: FontStyle.Italic)));
            paragraph.Add(new TextElement("Consolas Bold Blue Italic",
                new Font(color: Color.Blue, style: FontStyle.BoldItalic, name: "Consolas")));
            doc.Add(paragraph);
            doc.Add(Image.CreateFromFile("../../logo.png"));
            doc.Add(paragraph);

            File.WriteAllText("document.html", doc.AsHTML);
            Console.WriteLine(doc.AsHTML);
        } 
    }
}
