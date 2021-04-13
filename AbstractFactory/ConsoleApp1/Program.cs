using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCreamFactory iceCream = new IceCreamFactory(Day.Monday);
            IceCreamSeller seller = new IceCreamSeller(iceCream);
            Console.WriteLine(Day.Monday + "----------------------------");
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            iceCream.setProductionMode(Day.Tuesday);
            Console.WriteLine(Day.Tuesday + "----------------------------");
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            iceCream.setProductionMode(Day.Wednesday);
            Console.WriteLine(Day.Wednesday + "----------------------------");
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            iceCream.setProductionMode(Day.Thursday);
            Console.WriteLine(Day.Thursday + "----------------------------");
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            iceCream.setProductionMode(Day.Friday);
            Console.WriteLine(Day.Friday + "----------------------------");
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            iceCream.setProductionMode(Day.Saturday);
            Console.WriteLine(Day.Saturday + "----------------------------");
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            iceCream.setProductionMode(Day.Sunday);
            Console.WriteLine(Day.Sunday + "----------------------------");
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
            seller.suggestDailySpecial();
        }
    }
}
