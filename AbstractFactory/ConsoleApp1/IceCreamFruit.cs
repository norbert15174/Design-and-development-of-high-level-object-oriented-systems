using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IceCreamFruit : IceCream
    {
        public IceCreamFruit(bool waffle, bool icing)
        {
            this.waffle = waffle;
            this.icing = icing;
        }

        private bool waffle { get; set; }
        private bool icing { get; set; }
        



        public override string getFlavor()
        {
            return "Fruit";
        }

        public override int getPrice()
        {
            return 4;
        }

        public override string ToString()
        {
            return "Flavor: " + getFlavor() + " ,Price: " + getPrice() + " ,Waffle: "+ waffle + " Chocolate: " + " icing:" + icing;
        }
    }
}
