using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocktaillist
{
    public class CLib
    {

        List<Calbum> cocktails = new List<Calbum>();

        public void Addtolist(Calbum cocktail)
        {
            cocktails.Add(cocktail);
        }
        public void SearchCocktail(string cname)
        {
            foreach (var cocktail in cocktails)
            {
                if (cocktail.cname.Contains(cname))
                {
                    Console.WriteLine("Enjoy your Drink^_^...");
                    ShowHistory(cocktail);
                }
            }
        }
        public void ShowHistory(Calbum cocktail)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Here's your Drink!");
            Console.WriteLine(cocktail.cname);
            Console.WriteLine(cocktail.mainingredients);
            Console.WriteLine(cocktail.prep);
            Console.WriteLine(cocktail.flavor);
            Console.WriteLine(cocktail.type1);
            Console.WriteLine(cocktail.type2);
            Console.WriteLine("-----------------------");

        }

    }
}