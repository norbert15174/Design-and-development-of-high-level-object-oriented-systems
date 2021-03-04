using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.zad1
{
    public class Bird : Animal
    {
        private int eggs = 0;
        private int numberOfFeathers;
        public Bird() { }
        public Bird(string _name, int _weight, int _feathers) : base(_name,_weight) {
            numberOfFeathers = _feathers;
        }

        public void getName()
        {
// public -> still public
            Console.WriteLine(name);
        }
        public void getAge()
        {
//private -> still private
 //           Console.WriteLine(_age); 
        }
        public void getWeight()
        {
//protected -> public
            Console.WriteLine(weight);
        }
        public void LayEggs(int number)
        {
            Console.WriteLine("eggs have been layed, eggs amount: " + number);
        }
    }
}
