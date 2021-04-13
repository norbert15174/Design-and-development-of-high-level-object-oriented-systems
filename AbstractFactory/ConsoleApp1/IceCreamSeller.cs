using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IceCreamSeller
    {
        private IceCreamFactory factory;

        public IceCreamSeller(IceCreamFactory factory)
        {
            this.factory = factory;
        }

        public void suggestDailySpecial()
        {
            Console.WriteLine(factory.daySpecial().ToString());
        }
    }
}
