using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.HomeworkBasic
{
    public abstract class Vehicle
    {
        protected String engine { get; set; }
        protected float hp { get; set; }
        protected String model { get; set; }


        public Vehicle() { }
        public Vehicle(String _engine, float _hp, String _model)
        {
            engine = _engine;
            hp = _hp;
            model = _model;
        }
        virtual public String GetVehicleType()
        {
            return "unspecifed vehicle";
        }



    }
}
