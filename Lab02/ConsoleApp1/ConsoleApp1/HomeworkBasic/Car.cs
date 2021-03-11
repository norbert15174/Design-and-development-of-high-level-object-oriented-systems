using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.HomeworkBasic
{
    class Car : Vehicle
    {
        public Car() { }
        public Car(String _engine, float _hp, String _model) : base(_engine, _hp, _model) { }
        public override String GetVehicleType()
        {
            return "Car";
        }

        public override string ToString()
        {
            return "Vehicle type: " + GetVehicleType() + "\t Engine: " + engine + "\t Horse Power: " + hp + "\t Model: " + model;
        }
    }
}
