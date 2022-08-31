using System;
internal class Program
{
    private static string k = "";
    private static void Main(string[] args)
    {
        string j = "";
        for (int i = 0; i < 10; i++)
        {
            j = i.ToString();
            k = i.ToString();
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
        }
        // Console.WriteLine(j);
        Console.WriteLine("Outside of the for: " + j);
        Console.WriteLine("Outside of the for: " + k);

        HelperMethod();
    }

    static void HelperMethod()
    {
        Console.WriteLine("Inside of the HelperMethod: " + k);
    }
}