using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Cube
    {
        public double Area { get; private set; }
        public double Volume { get; private set; }

        public Cube() { }

        public Cube(double d)
        {
            this.Area = 6 * d * d;
            this.Volume = d * d * d;
        }
    }
}
