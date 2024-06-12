using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Inheritance_Polymorphism.Entities
{
    public class Employee
    {
        private string _name { get; set; }
        private int _hours { get; set; }
        private double _valuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHour)
        {
            _name = name;
            _hours = hours;
            _valuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return _hours * _valuePerHour;
        }

        public string GetName()
        { 
            return _name;
        }
    }
}
