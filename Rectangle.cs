namespace Cours1
{
    public class Rectangle : Shape
    {
        protected int length;
        protected int width;

        public Rectangle(int length, int width, int x, int y)
        {
            this.length = length;
            this.width = width;
            this.x = x;
            this.y = y;
        }

        public int Area()
        {
            return length * width;
        }
    }
}
