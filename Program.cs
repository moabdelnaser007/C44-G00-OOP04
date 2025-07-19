namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IShape c = new Circle(5);

            IShape r = new Rectangle(2,4);

            c.DisplayShapeInfo();

            r.DisplayShapeInfo();

        }
    }
}
