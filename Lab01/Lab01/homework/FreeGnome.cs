using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.homework
{
    class FreeGnome : Gnome
    {
        public FreeGnome(string _name, int _age, string _occurancePlace, List<string> _food) : base(_name, _age, _occurancePlace, _food) { }
    }
}
