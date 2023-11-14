namespace Cours1
{
    public abstract class Shape
    {
        protected int x;
        protected int y;

        public void Move(int x, int y)
        {
            this.x = this.x + x;
            this.y = this.y + y;
        }
    }
}
