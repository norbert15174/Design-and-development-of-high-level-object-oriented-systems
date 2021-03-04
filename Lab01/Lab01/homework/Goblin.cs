using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.homework
{
    class Goblin : HalfHuman
    {
        private List<string> createdItems;
        public Goblin(string _name, int _age, string _occurancePlace, List<string> _food, List<string> _createdItems) : base(_name, _age, _occurancePlace, _food) {
            createdItems = _createdItems;
        }
        public void CreateItem(string _item)
        {
            Console.WriteLine("The " + _item + " has been created, you can find it in your createdItems package");
            createdItems.Add(_item);
        }
        public void ShowCreatedItemsPackage() {
            Console.Write("List of items: ");
            createdItems.ForEach((item) => Console.Write(' ' + item + '|'));
        
        }

    }
}
