using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.homework
{
    class Human : Character {

        protected string firstName;
        protected string surName;

    
        public Human(string _firstName,string _surName, int _age, List<string> _food ) : base(_age, _food)
        {
            firstName = _firstName;
            surName = _surName;
        }
        public override void IntroduceYourSelf()
        {
            Console.WriteLine("Hi, I am " + firstName + ' ' + surName);
        }

    }

}
