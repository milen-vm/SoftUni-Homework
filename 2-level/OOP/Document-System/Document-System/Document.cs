using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_System
{
    class Document : CompositeElement
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public override void RenderHtml(TextWriter writer)
        {
            writer.WriteLine("<!DOCTYPE html>");
            writer.WriteLine("<html>");
            writer.WriteLine("<head>");
            if (this.Title != null)
            {
                writer.WriteLine("<title>{0}</title>", this.Title.HtmlEncode());
            }
            if (this.Author != null)
            {
                writer.WriteLine("<meta name='author' content='{0}' />", this.Author.HtmlEncode());
            }
            writer.WriteLine("</head>");
            writer.WriteLine("<body>");
            base.RenderHtml(writer);
            writer.WriteLine("</body>");
            writer.WriteLine("</html>");
        }
    }
}
