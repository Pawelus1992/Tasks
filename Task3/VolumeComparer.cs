using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class VolumeComparer
    {
        public VolumeComparer() { }

        public int Compare(double x, double y)
        {
            if (x > y)
                return -1;
            else if (x < y)
                return 1;
            else
                return 0;
        }
    }
}
