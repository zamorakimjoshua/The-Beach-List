

namespace mainprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calbum one = new Calbum
            {
                cname = "Bad Touch",
                mainingredients = "2 Bronson Ext 2 Pwd Delta 2 Flanergide 4 Alcohol",
                prep = "On the Rocks and Mixed",
                flavor = "Sour",
                type1 = "Classy",
                type2 = "Vintage",
            };

            Calbum two = new Calbum
            {
                cname = "Fluffy Dream",
                mainingredients = "3 Adelhyde 3 Pwd Delta (optional) Alcohol",
                prep = "Aged and Mixed",
                flavor = "Sour",
                type1 = "Girly",
                type2 = "Soft",
            };
            Calbum three = new Calbum
            {
                cname = "Gut Punch",
                mainingredients = "5 Bronson Ext 1 Flanergide (optional) Alcohol",
                prep = "Aged and Mixed",
                flavor = "Bitter",
                type1 = "Manly",
                type2 = "Strong",
            };
            Calbum four = new Calbum
            {
                cname = "Cobalt Velvet",
                mainingredients = "2 Adelhyde 3 Flanergide 5 Alcohol",
                prep = "On the Rocks and Mixed",
                flavor = "Bubbly",
                type1 = "Classy",
                type2 = "Burning",
            };
            Calbum five = new Calbum
            {
                cname = "Mercuryblast",
                mainingredients = "1 Adelhyde 1 Bronson Ext 3 Pwd Delta 3 Flanergide 2 Alcohol",
                prep = "On the Rocks and Blended",
                flavor = "Sour",
                type1 = "Classy",
                type2 = "Burning",
            };

            CLib Drinktionary = new CLib();
            CLib show = new CLib();

            Drinktionary.Addtolist(one);
            Drinktionary.Addtolist(two);
            Drinktionary.Addtolist(three);
            Drinktionary.Addtolist(four);
            Drinktionary.Addtolist(five);

            Console.WriteLine("WELCOME TO VA-11-HALL-A");
            Console.WriteLine("Choose your Drink");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Bad Touch");
            Console.WriteLine("2. Fluffy Dream");
            Console.WriteLine("3. Gut Punch");
            Console.WriteLine("4. Cobalt Velvet");
            Console.WriteLine("5. Mercuryblast");
            Console.WriteLine("------------------");

            int drinknumber = Convert.ToInt32(Console.ReadLine());
            switch (drinknumber)
            {
                case 1:
                    show.ShowHistory(one);
                    break;
                case 2:
                    show.ShowHistory(two);
                    break;
                case 3:
                    show.ShowHistory(three);
                    break;
                case 4:
                    show.ShowHistory(four);
                    break;
                case 5:
                    show.ShowHistory(five);
                    break;
                default:
                    Console.WriteLine("UNIDENTIFIED DRINK NUMBER");
                    break;
            }



        }

    }
}