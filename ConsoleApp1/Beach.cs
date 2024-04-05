using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHBeaches
{
    public class Beach
    {
        public string name;
        List<ListBeach> beaches = new List<ListBeach>();
        private readonly string beachname;


        public void AddBeach(ListBeach beach)
        {
            beaches.Add(beach);
        }
        public void SearchBeaches(string beach)
        {
           

        }
        public void DisplayInfo(ListBeach beach)
        {
            Console.WriteLine("Beach name: " + beach.name);
            Console.WriteLine("Place: " + beach.place);
            Console.WriteLine("   ");
        }
         public void DeleteBeach(ListBeach beach)
        {
            beaches.Remove(beach);
        }

        private void Remove(Beach beach)
        {
            throw new NotImplementedException();
        }
    }
}
