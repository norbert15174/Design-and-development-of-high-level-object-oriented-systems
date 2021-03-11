using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.HomeworkBasic
{
    public class Train : Vehicle
    {
        public Train()
        {

        }
        public Train(String _engine, float _hp, String _model) : base(_engine, _hp, _model) { }
        public override String GetVehicleType()
        {
            return "Train";
        }

        public override string ToString()
        {
            return "Vehicle type: " + GetVehicleType() + "\t Engine: " + engine + "\t Horse Power: " + hp + "\t Model: " + model;
        }
    }
}
