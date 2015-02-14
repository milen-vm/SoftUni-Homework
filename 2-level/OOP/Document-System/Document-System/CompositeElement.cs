using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_System
{
    public class CompositeElement : Element
    {
        public IList<Element> ChildElements { get; set; }

        public CompositeElement()
        {
            this.ChildElements = new List<Element>();
        }

        public CompositeElement(params Element[] elements)
            : this()
        {
            this.Add(elements);
        }

        public void Add(params Element[] elements)
        {
            foreach (var element in elements)
            {
                this.ChildElements.Add(element);
            }
        }

        public override void RenderHtml(TextWriter writer)
        {
            foreach (var element in this.ChildElements)
            {
                element.RenderHtml(writer);
            }
        }
    }
}
