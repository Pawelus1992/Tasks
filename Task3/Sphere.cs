using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Sphere
    {
        public double Area { get; private set; }
        public double Volume { get; private set; }

        public Sphere() { }

        public Sphere(double d)
        {
            this.Area = 4 * Math.PI * d * d;
            this.Volume = 4 / 3 * (Math.PI*d*d*d);
        }
    }
}
