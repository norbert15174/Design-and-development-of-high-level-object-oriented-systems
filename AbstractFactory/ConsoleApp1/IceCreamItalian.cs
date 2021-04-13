using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IceCreamItalian : IceCream
    {
        public IceCreamItalian(bool waffle, bool chocolate)
        {
            this.waffle = waffle;
            this.chocolate = chocolate;
        }

        private bool waffle { get; set; }
        private bool chocolate { get; set; }


        public override string getFlavor()
        {
            return "Italian";
        }

        public override int getPrice()
        {
            return 5;
        }

        public override string ToString()
        {
            return "Flavor: " + getFlavor() + " ,Price: " + getPrice() + " ,waffle" + waffle + " Chocolate: " + chocolate;
        }
    }
}
