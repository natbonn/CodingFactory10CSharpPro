using PointApp.Model;

namespace PointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new(15);
            Point2D p2 = new(10, 20);
            Point3D p3 = new(5, 10, 15);

            // Subtype polymorphism
            Point p4 = new(10);
            Point p5 = new Point2D(2, 7);
            Point p6 = new Point3D(1, 2, 3);

            // At runtime, late binding 
            DoMove5(p1);
            DoMove5(p2);
            DoMove5(p3);
        }

        // Polymorphic method to move point by 5 units
        public static void DoMove5(Point p)
        {
            p.Move5();
        }

        public static void DoPrint(Point p)
        {
            Console.WriteLine(p);   // Calls the overridden ToString() method
        }
    }
}
