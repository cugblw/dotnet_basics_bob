// Console.WriteLine("Hello, World!");

// string myString = "my \"so-called\" life.";
// string myString = "What if I need a\n  new line?";
// string myString = "Go to your c:\\ drive";
// string myString = @"Go to your C:\ drive";

// string myString = String.Format("{0} = {1}", "Hello", "World");

// string myString = string.Format("{0:C}", 123.45);
// string myString = string.Format("{0:N}", 1234567890);
// string myString = string.Format("Percentage: {0:P}", .123);
// string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);

// string myString = " That summer we took threes across the board  ";

// myString = myString.Substring(6, 14); 
// myString = myString.ToUpper();
// myString = myString.Replace(" ", "--");
// myString = myString.Remove(6, 14);
// myString = myString.Insert(6, "--");
// myString = myString.Trim();
// myString = String.Format("Length before: {0} -- After: {1}", myString.Length, myString.Trim().Length);

// string myString = "";
// for (int i = 0; i < 100; i++)
// {
//     myString += "--" + i.ToString();
// }
using System;
using System.Text;
internal partial class Program
{
    private static void Main(string[] args)
    {
        StringBuilder myString = new StringBuilder();
        for (int i = 0; i < 100; i++)
        {
            myString.Append("--");
            myString.Append(i);
        }



        Console.WriteLine(myString);
    }
}