using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.homework
{
    class Charlak : Human
    {
        string origin;
        public Charlak(string _firstName, string _surName, int _age, List<string> _food, string _origin) : base(_firstName, _surName, _age, _food)
        {
            origin = _origin;
        }
        public void MixturePrepare()
        {
            Console.WriteLine("Mixture has been prepared!");
        }
    }
}
