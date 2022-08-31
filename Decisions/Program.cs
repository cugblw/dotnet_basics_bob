// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Bob's Big Giveaway");
Console.WriteLine("Choose a door: 1, 2, or 3: ");
string userValue = Console.ReadLine();

string message = "";

if (userValue == "1")
    message = "You won a new car!";
    // Console.WriteLine(message);
else if (userValue == "2")
    message = "You won a new boat!";
    // Console.WriteLine(message);
else if (userValue == "3")
    message = "You won a new cat!";
    // Console.WriteLine(message);
else
    message = "Sorry, we didn't understand. You lose.";
    // Console.WriteLine(message);
Console.WriteLine(message); */

Console.WriteLine("Bob's Big Giveaway");
Console.WriteLine("Choose a door: 1, 2, or 3: ");
string userValue = Console.ReadLine();

string message = (userValue == "1") ? "boat" : "strand of lint";
Console.WriteLine("You won a {0}.", message);