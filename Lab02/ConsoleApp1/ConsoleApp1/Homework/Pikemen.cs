using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Homework
{
    class Pikemen : Defender
    {
        public Pikemen(int _foodAmount) : base(_foodAmount) { }
        public Pikemen() { }

        public override string ReadyToFight()
        {
            return "Sword is ready to fight";
        }

        public override string ToString()
        {
            return "I'm Pikemen";
        }
    }
}
