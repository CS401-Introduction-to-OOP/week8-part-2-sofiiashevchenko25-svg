namespace ConcoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value type demo
            Point p1 = new Point { X = 1, Y = 2 };
            Point p2 = p1;

            p2.X = 3;
            p1.Print();
            p2.Print();

            // Reference type demo
            PointRef r1 = new PointRef { X = 1, Y = 2 };
            PointRef r2 = r1;

            r2.X = 4;
            r1.Print();
            r2.Print();

            // Boxing demo
            BoxingTester.Test();
        }
    }
}