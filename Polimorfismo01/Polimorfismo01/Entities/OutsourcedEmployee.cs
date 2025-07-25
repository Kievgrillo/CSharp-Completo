﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo01.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }
        public OutsourcedEmployee(string name, int hours, double valueHour, double additionalCharge) : base(name, hours, valueHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
