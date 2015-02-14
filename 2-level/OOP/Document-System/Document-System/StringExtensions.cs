using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Document_System
{
    public static class StringExtensions
    {
        public static string HtmlEncode(this string str)
        {
            return HttpUtility.HtmlEncode(str);
        }
    }
}
