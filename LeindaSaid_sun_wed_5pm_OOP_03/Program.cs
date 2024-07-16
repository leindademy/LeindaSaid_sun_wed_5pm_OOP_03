using System.Reflection.Metadata.Ecma335;

namespace LeindaSaid_sun_wed_5pm_OOP_03
{
    internal class Program
    {
        public static bool validate(Point a, Point b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        public static Point Read_Point_From_User()
        {
            Console.WriteLine("Enter x, y, z: ");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                if (double.TryParse(Console.ReadLine(), out double y))
                {
                    if (double.TryParse(Console.ReadLine(), out double z))
                    {
                        Point p2 = new Point(x, y, z);
                        return p2;
                    }
                }
            }
            return new Point(0, 0, 0);
        }
        static void main(string[] args)
        {
            #region Question_one

            //Point p1 = Read_Point_From_User();
            //Point p2 = Read_Point_From_User();

            //if (p1 == p2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //Point[] points = { p1, p2 };
            //Array.Sort(points, (a, b) => (a.X == b.X) ? a.Y.CompareTo(b.Y) : a.X.CompareTo(b.X));

            //// print sorted array
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //p2 = (Point)p1.Clone();

            //Console.WriteLine(p2);

            #endregion

            #region Question_two
            IShape shape = new Circle(5);

            shape.DisplayShapeInfo();

            IShape shape2 = new Rectangle(5, 10);

            shape2.DisplayShapeInfo();
            #endregion

            #region Question_three
            #endregion
        }
    }
}
 


