// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
HelloWorld helloApp = new HelloWorld();
helloApp.Hello();


void sayHello()
{
    Console.WriteLine("Hello, World!");
}

sayHello();

string firstName = "John";
string lastName = "Doe";
Console.WriteLine($"{firstName} {lastName}");
Console.ReadLine();

class HelloWorld
{
    public void Hello()
    {
        Console.WriteLine("Hello, Lee!");Console.WriteLine("Hello, Again!");
    }
}