using LeindaSaid_sun_wed_5pm_OOP_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeindaSaid_sun_wed_5pm_OOP_03
{
    public class Circle : ICircle
    {
        public double Radius { get; set; }
        public double _area { get; set; }
        public double Area { get => _area; set => _area = value; }

        private void Calculate_Area()
        {
            _area = Math.PI * this.Radius;
        }
        public Circle(double radius)
        {
            this.Radius = radius;
            Calculate_Area();
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius: {this.Radius} Area: {this.Area}");
        }
    }
}
