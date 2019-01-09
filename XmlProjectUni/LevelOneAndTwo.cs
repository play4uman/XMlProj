using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlProjectUni.ResourcesFolder;

namespace XmlProjectUni
{
    public class PawnShop
    {
        public Resources Resources { get; set; }
        public Sales Sales { get; set; }
        public Personnel Personnel { get; set; }
    }

    public class Resources
    {
        public Electronics Electronics { get; set; }
        public WhiteAppliances WhiteAppliances { get; set; }
        public BlackAppliances BlackAppliances { get; set; }
    }

    public class Sales
    { }

    public class Personnel
    { }
}
