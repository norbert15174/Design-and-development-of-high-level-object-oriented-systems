using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.zad1
{
    class Flamingo : Bird
    {
        public Flamingo() { }
        public void Incubation(int number, int days)
        {
            LayEggs(number);
            Console.WriteLine("Eggs will be hatching " + days + " days");
        }
        public void access()
        {
            Console.WriteLine(name);
            Console.WriteLine(weight);
        }
    }
}
