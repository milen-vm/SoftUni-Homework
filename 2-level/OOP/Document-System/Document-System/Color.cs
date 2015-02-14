using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Document_System
{
    public class Color : IHtmlRendere
    {
        public static Color Red { get { return new Color(255, 50, 50); } }
        public static Color Green { get { return new Color(50, 255, 50); } }
        public static Color Blue { get { return new Color(50, 50, 255); } }
        public static Color White { get { return new Color(255, 255, 255); } }
        public static Color Black { get { return new Color(0, 0, 0); } }

        public byte RedValue { get; set; }

        public byte GreenValue { get; set; }

        public byte BlueValue { get; set; }

        public Color(byte red, byte green, byte blue)
        {
            this.RedValue = red;
            this.GreenValue = green;
            this.BlueValue = blue;
        }



        public void RenderHtml(TextWriter writer)
        {
            writer.Write("#" +
                this.RedValue.ToString("X2") +
                this.GreenValue.ToString("X2") +
                this.BlueValue.ToString("X2"));
        }
    }
}
