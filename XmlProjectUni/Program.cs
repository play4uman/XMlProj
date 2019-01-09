using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XmlProjectUni.ResourcesFolder;

namespace XmlProjectUni
{
    class Program
    {
        static void Main(string[] args)
        {
            var pawnShop = new PawnShop();
            pawnShop.Resources = new Resources();
            pawnShop.Resources.Electronics = new Electronics();
            pawnShop.Resources.Electronics.PCs.AddRange( new[] 
            {
                new PC
                {
                    Brand = "Acer",
                    Model = "69",
                    Price = 420,
                    CpuSpeed = 4.4
                },
                new PC
                {
                    Brand = "Hello",
                    Model = "There",
                    Price = 42,
                    CpuSpeed = 6.9
                }
            });

            pawnShop.Resources.WhiteAppliances = new WhiteAppliances();
            pawnShop.Resources.Electronics.Laptops.AddRange(new[]
            {
                new Laptop
                {
                    Brand = "Asus",
                    Model = "Nasus",
                    Price = 1999,
                    Weight = 2.3
                }
            });

            pawnShop.Resources.WhiteAppliances.Fridges.Add(new Fridge
            {
                Brand = "Mraz",
                Model = "332A",
                Price = 800,
                Capacity = 5.8
            });

            pawnShop.Resources.WhiteAppliances.WashingMashines.Add(new WashingMashine
            {
                Brand = "Philips",
                Model = "1a23B",
                Price = 333.33,
                SpinsPerMinute = 120
            });

            var sb = new StringBuilder();
            var ser = new XmlSerializer(typeof(PawnShop));
            using (var sw = new StringWriter(sb))
            {
                ser.Serialize(sw, pawnShop);
            }
            var res = sb.ToString();
        }
    }
}
