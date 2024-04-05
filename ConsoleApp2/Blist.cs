using PHBeaches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PHBeaches
{
    public class Blist
    {
        static void Main(string[] args)
        {
            Beach theBeachList = new Beach();
            theBeachList.name = "List of Beaches: ";

            ListBeach one = new ListBeach()
            {
                name = "Boracay",
                place = "Aklan",
                
            };

            ListBeach two = new ListBeach()
            {
                name = "Alona Beach",
                place = "Bohol-Panglao",

            };
            ListBeach three = new ListBeach()
            {
                name = "El Nido",
                place = "Miniloc Island",

            };
            ListBeach four = new ListBeach()
            {
                name = "Saud Beach",
                place = "Pagudpod",

            };
            ListBeach five = new ListBeach()
            {
                name = "Coron",
                place = "Palawan",

            };

            theBeachList.DisplayInfo(one);
            theBeachList.DisplayInfo(two);
            theBeachList.DisplayInfo(three);
            theBeachList.DisplayInfo(four);
            theBeachList.DisplayInfo(five);
            
        }
    }
}
