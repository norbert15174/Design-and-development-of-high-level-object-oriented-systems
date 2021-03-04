using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.zad1
{
    public class Animal
    {



        public string name = "Norbert";
        protected int weight = 10;
        private int age = 20;

        public Animal() { }
        public Animal(string _name, int _weight) {
            name = _name;
            weight = _weight;
        }


    }
}
