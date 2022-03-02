using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapOuPasCap.UsesCase.Tools
{
    public static class Tools
    {
        public static bool IsNullOrEmpty(this string me)
        {
            return string.IsNullOrEmpty(me);
        }
    }
}
