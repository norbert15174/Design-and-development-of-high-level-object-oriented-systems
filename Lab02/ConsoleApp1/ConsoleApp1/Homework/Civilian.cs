using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Homework
{
    class Civilian : Inhabitant
    {

        public Civilian(int _foodAmount) : base(_foodAmount) { }
        public Civilian() { }


        public override string ToString()
        {
            return "I'm Pikemen";
        }
    }
}
