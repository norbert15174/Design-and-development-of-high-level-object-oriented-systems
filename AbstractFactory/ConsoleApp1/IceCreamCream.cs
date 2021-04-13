using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IceCreamCream : IceCream
    {

        private bool waffle { get; set; }
        private bool chocolate { get; set; }
        private bool icing { get; set; }

        public IceCreamCream(bool waffle, bool chocolate, bool icing)
        {
            this.waffle = waffle;
            this.chocolate = chocolate;
            this.icing = icing;
        }

        

        public override String getFlavor()
        {
            return "Cream";
        }

        public override int getPrice()
        {
            return 3;
        }

        public override string ToString()
        {
            return "Flavor: " + getFlavor() + " ,Price: " + getPrice() + " ,Waffle: " + waffle + " Chocolate: " + chocolate + " icing: " + icing; 
        }
    }
}
