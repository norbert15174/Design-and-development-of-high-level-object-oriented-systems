using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.homework
{
    class HalfHuman : Character
    {
        protected string name;
        public string occurancePlace;
        public HalfHuman(string _name, int _age, string _occurancePlace, List<string> _food) : base(_age, _food){
            name = _name;
            occurancePlace = _occurancePlace;
        }
        public override void IntroduceYourSelf()
        {
            Console.WriteLine("Hi, I am " + name);
        }
    }
}
