

namespace TheTDDMob
{
    /// <summary>
    /// Given a Point (X,Y) and a Rectangle (X1,X2,Y1,Y2)
    /// Write a method that will check if the point lies within the rectangle described
    /// </summary>
    public class Task1
    {
        public static bool IsInRectangle(Point point, Rectangle rectangle)
        {
            return point.x >= rectangle.x1 &&
                   point.x <= rectangle.x2 &&
                   point.y >= rectangle.y1 &&
                   point.y <= rectangle.y2;
        }
    }

    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Rectangle
    {
        public int x1;
        public int x2;
        public int y1;
        public int y2;

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
    }
}