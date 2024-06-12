using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BootCamp_Inheritance_Polymorphism.Entities
{
    public class OutsourcedEmployee : Employee
    {
        private double _additionalCharge { get; set; }
        public OutsourcedEmployee(double additionalCharge, string name, int hours, double valuePerHour) : base(name, hours, valuePerHour)
        {
            _additionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            double finalPayment = base.Payment() + _additionalCharge;
            return finalPayment += finalPayment * 0.16;
        }
    }
}
