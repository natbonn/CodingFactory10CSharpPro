namespace InterfacesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new() { X = 1};     // Object initializer syntax

            p1.Move5();        // from abstract class AbstractPoint
            p1.Move10();
        }
    }
}
