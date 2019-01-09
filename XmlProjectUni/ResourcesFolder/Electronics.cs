using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlProjectUni.ResourcesFolder
{
    public class Electronics
    {
        public Electronics()
        {
            PCs = new List<PC>();
            Laptops = new List<Laptop>();
        }
        public List<PC> PCs { get; set; }
        public List<Laptop> Laptops { get; set; }
    }

    public class PC : Resource
    {
        public double CpuSpeed { get; set; }
    }

    public class Laptop : Resource
    {
        public double Weight { get; set; }
    }
}
