using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.HomeworkBasic
{
    class Plane : Vehicle
    {
        public Plane(String _engine, float _hp, String _model) : base(_engine, _hp, _model) { }
        public override String GetVehicleType()
        {
            return "Plane";
        }

        public override string ToString()
        {
            return "Vehicle type: " + GetVehicleType() + "\t Engine: " + engine + "\t Horse Power: " + hp + "\t Model: " + model;
        }
    }
}
