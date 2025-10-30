namespace math;

class Program
{
    static void Main(string[] args)
    {
        void min()
        {
            double kleiner = 9;
            double groter = 19;
            double welkeIsKleiner = Math.Min(kleiner, groter);
            Console.WriteLine(welkeIsKleiner + " is de kleinste van " + kleiner + " en " + groter);
        }
        void max()
        {
            double kleiner = 9;
            double groter = 14;
            double welkeIsGroter = Math.Max(kleiner, groter);
            Console.WriteLine(welkeIsGroter + " is de grootste van " + kleiner + " en " + groter);
        }

        min();
        max();
    }
}
