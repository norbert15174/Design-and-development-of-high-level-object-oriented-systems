using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IceCreamFactory
    {

        private Day productionMode;

        public IceCreamFactory(Day day)
        {
            productionMode = day;
        }

        public IceCream daySpecial()
        {
    
            IceCream iceCream = productionMode switch
            {
                Day.Monday => new IceCreamCream(true, true, true),
                Day.Tuesday => new IceCreamFruit(true, false),
                Day.Wednesday => new IceCreamItalian(true, false),
                Day.Thursday => new IceCreamSorbet(),
                Day.Friday => new IceCreamFruit(true, true),
                Day.Saturday => new IceCreamCream(false, false, false),
                Day.Sunday => new IceCreamItalian(true, true),
                _ => new IceCreamCream(false, false, false)
            };
            return iceCream;
        }

        public void setProductionMode(Day day)
        {
            productionMode = day;
        }
    }
}
