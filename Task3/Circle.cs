using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Circle
    {
        public double Radius { get; private set; }

        public Circle() { }

        public Circle(double d)
        {
            this.Radius = Math.PI * d*d;
        }
    }
}
