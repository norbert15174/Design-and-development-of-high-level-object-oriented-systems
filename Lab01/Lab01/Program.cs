using Lab01.homework;
using Lab01.zad1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{

    class Program
    {

        static void Main(string[] args)
        {
            List<string> food = new List<string> { "apple", "onion", "pork" };
            List<string> items = new List<string> {"Big sword","Small sword"};
            //Test data for Charlak
            /*        Charlak charlak = new Charlak("Norbert","Faron",22,food,"Faron");
                        charlak.Fight("thief");
                        charlak.Eat("apple");
                        charlak.Eat("apple");
                        charlak.Eat("banana");
                        charlak.AddFood("banana");
                        charlak.AddFood("banana");
                        charlak.Eat("banana");
                        charlak.Eat("banana");
                        charlak.Eat("banana");
            */
            //Test data for Mage
            /*
                        Mage mage = new Mage("Norbert", "Faron", 22, food, "Faron" , "black-rod");
                        mage.CastSpell("abrakadabra");
                        mage.MixturePrepare("health");
                        mage.Fight("Covid");
            */
            //Test data for goblin
            /*
            Goblin goblin = new Goblin("Repungnant Alguff",100,"Bank",food, items);
            goblin.IntroduceYourSelf();
            Console.WriteLine(goblin.occurancePlace);s
            goblin.CreateItem("Rod of ages");
            goblin.ShowCreatedItemsPackage();
            
            */
            GnomeSlave gnomeSlave = new GnomeSlave("Zgredek", 100, "Owner hause", food, "Lucius Malfoy");
            gnomeSlave.IntroduceYourSelf();
            gnomeSlave.Serve();
            gnomeSlave.Charm("abrakadabra");
            Console.ReadLine();

        }


    }
}
