namespace calcextra;

class Program
{
    static void Main(string[] args)
    {
        float x1 = 50;
        float y1 = 50;
        float x2 = 60;
        float y2 = 50;
        float testlengt = 5;
        float dx = x2 - x1;
        float dy = y2 - y1;
        double length = Math.Sqrt((dx * dx) + (dy * dy));
        bool collide = length <= testlengt;
        Console.WriteLine(collide);
    }
}
