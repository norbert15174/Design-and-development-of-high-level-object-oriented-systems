using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Homework
{
    class Crossbowman : Defender
    {
        public Crossbowman(int _foodAmount) : base(_foodAmount) { }
        public Crossbowman() { }

        public override string ReadyToFight()
        {
            return "Crossbow is ready to fight";
        }
        public override string ToString()
        {
            return "I'm Crossbowman";
        }
    }
}
