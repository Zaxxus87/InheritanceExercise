using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile()
        {

        }

        public double GroundSpeed { get; set; }
        public Boolean ColdBlooded { get; set; }
        public string ScaleColor { get; set; }
        public Boolean HasTail { get; set; }

    }
}
