using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }

        public double Wingspan { get; set; }
        public double Flightspeed { get; set; }
        public string FeatherColor { get; set; }
        public Boolean CanFly { get; set; }

    }
}
