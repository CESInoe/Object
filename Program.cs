using Cours1;
namespace Objet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(1, 1, 0, 0);

            rectangle.Move(1, 1);

            Square square = new Square(2, 1, 1);

            Console.WriteLine($"Rectangle area : {rectangle.Area()}");
            Console.WriteLine("Square area : " + square.Area());
        }
    }
}