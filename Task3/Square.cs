using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Square
    {
        public double Area { get; private set; }

        public Square() { }

  
        public Square(double a)
        {
            this.Area = a*a;
        }
    }
}
