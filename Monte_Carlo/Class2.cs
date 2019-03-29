using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlo
{
    class Class2
    {
    }

    public struct Coordinate
    {
        private double x, y;

        public double X { get => X; set => X = value; }
        public double Y { get => Y; set => Y = value; }

        public Coordinate (double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Coordinate(Random random)
        {
            this.x = random.NextDouble();
            this.y = random.NextDouble();
        }

        public double Hypotenuse()
        {
            return Math.Sqrt(Math.Pow(this.x, 2 + Math.Pow(this.y, 2)));
        }
    }
}