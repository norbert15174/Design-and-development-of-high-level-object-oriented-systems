using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IceCreamSorbet : IceCream
    {
        public IceCreamSorbet()
        {
        }

        public override string getFlavor()
        {
            return "Sorbert";
        }

        public override int getPrice()
        {
            return 2;
        }

        public override string ToString()
        {
            return "Flavor: " + getFlavor() + " ,Price: " + getPrice();
        }
    }
}
