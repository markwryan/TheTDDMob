

namespace TheTDDMob
{
    /// <summary>
    /// Given a Point (X,Y) and a Rectangle (X1,X2,Y1,Y2)
    /// Write a method that will check if the point lies within the rectangle described
    /// </summary>
    public class Task1
    {
        public static bool IsInRectangle(Point p, Rectangle r)
        {
            return false;
        }
    }

    public class Point
    {
        public int x;
        public int y;
    }

    public class Rectangle
    {
        public int x1, x2, y1, y2;

        public Rectangle(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
    }
}