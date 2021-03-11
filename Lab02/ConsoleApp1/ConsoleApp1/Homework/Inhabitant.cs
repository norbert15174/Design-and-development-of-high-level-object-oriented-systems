using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Homework
{
    public abstract class Inhabitant
    {
        private int foodAmount = 0;

        public Inhabitant() { }
        public Inhabitant(int _foodAmount) {
            if (_foodAmount > 0) foodAmount = _foodAmount;
            else foodAmount = 0;
        }
        public string AddSomeFood(int _amount)
        {
            if (_amount > 0) {
                foodAmount += _amount;
                return "Food has been added";
            }
            else
            {
                return "It is forbidden to collect food while recharging!";
            }           
        }

        public string EatSomeFood(int _amount)
        {
            if (foodAmount - _amount > 0)
            {
                foodAmount -= _amount;
                return "Food has been eaten";
            }
            else
            {
                return "You don't have enough food!";
            }
        }

        public string EnoughFood()
        {
            if (foodAmount >= Eat()) return "Inhabitant has got enough food to live";
            return "Inhabitant has too little food! He must collect more to survive!";
        }

        public int Eat()
        {
            return 5;
        }

    }
}
