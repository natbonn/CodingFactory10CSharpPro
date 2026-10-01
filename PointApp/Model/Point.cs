namespace PointApp.Model;

internal class Point
{
    public int X { get; set; }

    public Point()
    {

    }

    public Point(int x)
    {
        X = x;
    }

    // Override is the method that overrides virtual methods
    public override string ToString() => $"Point: {X}";

    // Virtual are the methods that can be overridden in derived classes.
    public virtual void Move5()
    {
        X += 5;
    }
}

