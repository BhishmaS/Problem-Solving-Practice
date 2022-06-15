using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.OOPS
{
    public static class Constants
    {
        public const string Const = "const_variable";

        // Should not be visible, not thread safe
        private static string Static = "static_variable";

        public static readonly DateTime DateTime = DateTime.UtcNow;

        public static string GetConstant()
        {
            return Const;
        }

        public static string GetStatic()
        {
            Static = "";
            return Static;
        }
    }
}
