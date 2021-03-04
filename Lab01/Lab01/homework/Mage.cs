using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.homework
{
    class Mage : Human
    {
        string origin;
        string rod;
        public Mage(string _firstName, string _surName, int _age, List<string> _food, string _origin, string _rod) : base(_firstName,_surName,_age, _food)
        {
            origin = _origin;
            rod = _rod;
        }
        public void MixturePrepare(string _potion)
        {
            Console.WriteLine( _potion + " mixture has been prepared!");
        }
        public void CastSpell(string _spell)
        {
            Console.WriteLine(_spell + " has been cast!");
        }
    }
}
