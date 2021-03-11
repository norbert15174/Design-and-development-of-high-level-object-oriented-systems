using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Homework
{
    public abstract class Defender : Inhabitant
    {
        public Defender(int _foodAmount) : base(_foodAmount) { }
        public Defender() { }

        public abstract String ReadyToFight();

        public override String ToString()
        {
            return "I'm Defender";
        }
    }
}
