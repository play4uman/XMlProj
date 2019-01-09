using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlProjectUni.ResourcesFolder
{
    public class WhiteAppliances
    {
        public WhiteAppliances()
        {
            Fridges = new List<Fridge>();
            WashingMashines = new List<WashingMashine>();
        }
        public List<Fridge> Fridges { get; set; }
        public List<WashingMashine> WashingMashines { get; set; }
    }

    public class Fridge : Resource
    {
        public double Capacity { get; set; }
    }

    public class WashingMashine : Resource
    {
        public int SpinsPerMinute { get; set; }
    }
}
