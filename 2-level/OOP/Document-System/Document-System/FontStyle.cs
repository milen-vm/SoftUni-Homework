using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Document_System
{
    [Flags]

    public enum FontStyle
    {
        Normal = 0,
        Bold = 1,
        Italic = 2,
        BoldItalic = Bold | Italic
    }
}
