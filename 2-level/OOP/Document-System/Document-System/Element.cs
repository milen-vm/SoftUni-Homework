using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_System
{
    public abstract class Element : IHtmlRendere
    {

        public abstract void RenderHtml(TextWriter writer);

        public string AsHTML
        {
            get
            {
                StringWriter writer = new StringWriter();
                this.RenderHtml(writer);

                return writer.ToString();
            }
        }
       
    }
}
