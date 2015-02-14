using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_System
{
    public interface IHtmlRendere
    {
        void RenderHtml(TextWriter writer);
    }
}
