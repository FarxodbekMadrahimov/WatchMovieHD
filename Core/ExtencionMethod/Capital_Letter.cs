using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.ExtencionMethod
{
    public static class ExtensionMethod
    {
        public static  string Capital_Latter(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }
            return $"{name[0].ToString().ToUpper()}{name.Substring(1)}";

        }
    }
}
