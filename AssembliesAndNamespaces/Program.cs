
using System.Net;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello World!");

// string text =
//     "A class is the most powerful data type in C#. Like a structure, " +
//     "a class defines the data and behavior of the data type. ";

// await File.WriteAllTextAsync("WriteText.txt", text);

WebClient client = new WebClient();
string reply = client.DownloadString("https://www.baidu.com");

Console.WriteLine(reply);