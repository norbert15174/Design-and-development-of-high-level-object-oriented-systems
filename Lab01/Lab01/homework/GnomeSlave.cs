using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.homework
{
    class GnomeSlave : Gnome
    {
        private string owner;
        public GnomeSlave(string _name, int _age, string _occurancePlace, List<string> _food,string _owner) : base(_name, _age, _occurancePlace, _food) {
            owner = _owner;
        }
        public void Serve()
        {
            Console.WriteLine(name + " serves his master " + owner);
        }
    }
}
