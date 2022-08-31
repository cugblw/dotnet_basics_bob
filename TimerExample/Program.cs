using System.Timers;
// using System.Threading.Tasks;
// Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        System.Timers.Timer myTimer = new System.Timers.Timer(2000);

        myTimer.Elapsed += MyTimer_Elapsed;
        myTimer.Elapsed += MyTimer_Elapsed1;

        myTimer.Start();

    }
    private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Elapsed: {0:HH:mm:ss:fff}", e.SignalTime);
    }

    private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Elapsed: {0:HH:mm:ss:fff}", e.SignalTime);
    }
}