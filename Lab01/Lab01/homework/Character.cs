using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.homework
{
    abstract class Character
    {
        public int age;
        protected List<string> food;


        public Character() { }
        public Character(int _age, List<string> _food)
        {
            age = _age;
            food = _food;
        }


        public bool Eat(string _food)
        {
            bool isEaten = false;
            food.ForEach((item) => {
                if (item == _food)
                {
                    Console.WriteLine("Character's eating " + _food);
                    Console.WriteLine(_food + " has been eaten");
                    isEaten = true;
                }
            });

            if (!isEaten)
                Console.WriteLine(_food + " does not exist in character's package");
            else
                food.Remove(_food);
            return isEaten;
        }
        public void Fight(string _enemy)
        {
            Console.WriteLine("Character's fighting with " + _enemy);
        }
        public void AddFood(string _food)
        {
            Console.WriteLine(_food + " has been added to package");
            food.Add(_food);
        }
        public abstract void IntroduceYourSelf();

    }
}
