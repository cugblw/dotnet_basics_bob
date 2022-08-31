internal class Program
{
    private static void Main(string[] args)
    {
        // HelloWorld(); 
    }
    private static void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }

    private static string ReverseString(string message)
    {
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);
        return String.Concat(messageArray);
    }
}