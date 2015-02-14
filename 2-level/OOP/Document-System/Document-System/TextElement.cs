using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Document_System
{
    public class TextElement : Element
    {
        public string Text { get; set; }

        public Font Font { get; set; }

        public TextElement(string text, Font font = null)
        {
            this.Text = text;
            this.Font = font;
        }

        public override void RenderHtml(TextWriter writer)
        {
            if (this.Font != null)
            {
                writer.Write("<span style='");
                this.Font.RenderHtml(writer);
                writer.Write("'>");
            }
            writer.Write(this.Text.HtmlEncode());
            if (this.Font != null)
            {
                writer.Write("</span>");
            }
        }
    }
}
