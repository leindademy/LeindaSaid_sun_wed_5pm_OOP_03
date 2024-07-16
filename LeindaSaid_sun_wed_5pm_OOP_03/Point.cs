using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeindaSaid_sun_wed_5pm_OOP_03
{
    public class Point : ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point(double x)
        {
            this.X = x;
        }
        public Point(double x, double y) : this(x)
        {
            this.Y = y;
        }
        public Point(double x, double y, double z) : this(x, y)
        {
            this.Z = z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

        public object Clone()
        {
            return new Point(X, Y, Z);
        }
    }
}
