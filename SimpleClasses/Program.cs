internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        Car myCar = new Car();
        myCar.Make = "Oldsmobile";
        myCar.Model = "Cutlas Supreme";
        myCar.Year = 1986;
        myCar.Color = "Silver";

        Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year} {myCar.Color}.");
        decimal value = DetermineMarketValue();
        Console.WriteLine("{0:C}", value);
        System.Console.WriteLine("{0:C}",myCar.DetermineMarketValue());
    }

    private static decimal DetermineMarketValue()
    {
        decimal carValue = 100.0M;

        // Someday I might look up the car 
        // online webservice to get more
        // accurate value.

        return carValue;
    }
}

class Car 
{ 
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public decimal DetermineMarketValue()
    {
        decimal carValue;

        if (Year > 1990)
            carValue = 10000;
        else
            carValue = 2000;

        return carValue;
    }
}