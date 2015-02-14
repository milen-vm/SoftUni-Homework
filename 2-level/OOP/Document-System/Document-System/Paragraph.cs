using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Document_System
{
    public class Paragraph : CompositeElement
    {
        public Paragraph()
            : base()
        {

        }

        public Paragraph(string text, Font font = null)
            : this()
        {
            this.Add(new TextElement(text, font));
        }

        public override void RenderHtml(TextWriter writer)
        {
            writer.Write("<p>");
            base.RenderHtml(writer);
            writer.WriteLine("</p>");
        }
    }
}
