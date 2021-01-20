using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaComparer = new AreaComparer();
            var volumeComparer = new VolumeComparer();

            var result1 = areaComparer.Compare(new Circle(7).Radius, new Square(7.0).Area);
            var result2 = volumeComparer.Compare(new Cube(10.0).Volume, new Sphere(10).Volume);
            
        }
    }
}
