namespace operators;

class Program
{
    static void Main(string[] args)
    {
        /*
        int plus = 9;
        Console.WriteLine("plus start op " + plus);
        plus++;
        Console.WriteLine("Plus is nu " + plus);
        plus--;
        Console.WriteLine("Plus is nu " + plus);
        plus--;
        Console.WriteLine("Plus is nu " + plus);
        */

        int voorbeeld1 = 20;
        voorbeeld1 += 10;
        Console.WriteLine("voorbeeld1  is nu 30, zie " + voorbeeld1);

        int voorbeeld2 = 20;
        int result = voorbeeld2 + 10;
        Console.WriteLine("voorbeeld2  is nu 20, zie " + voorbeeld2 + " wie is wel 30");
        //waarom is voorbeeld2 niet 30 terwijl we er 10 bij optellen?
        //omdat de variable result niet geprint word

        int voorbeeld3 = 20;
        int result2 = voorbeeld3 + 10;
        Console.WriteLine("voorbeeld3  is nu 30, zie " + voorbeeld3 + " result2 ook " + result2);


        int A = 100;
        A -= 50;
        Console.WriteLine(A);
        double B = 100;
        B *= 2;
        Console.WriteLine(B);
        float C = 100;
        C /= 2;
        Console.WriteLine(C);
    }
}
