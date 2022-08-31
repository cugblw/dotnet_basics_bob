Car myCar = new Car();

/* 
myCar.Make = "Oldsmobile";
myCar.Model = "Cutlas Supreme";
myCar.Year = 1986;
myCar.Color = "Silver"; 
*/

Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

Car myAnotherCar;
myAnotherCar = myCar;

Console.WriteLine($"{myAnotherCar.Make} {myAnotherCar.Model} {myAnotherCar.Year} {myAnotherCar.Color}");

myAnotherCar.Model = "98";

Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year} {myCar.Color}");

// myAnotherCar = null;

// Console.WriteLine($"{myAnotherCar.Make} {myAnotherCar.Model} {myAnotherCar.Year} {myAnotherCar.Color}");

Console.WriteLine($"{myThirdCar.Make} {myThirdCar.Model} {myThirdCar.Year} {myThirdCar.Color}");


class Car{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public Car()
    {
        Make = "Nissan";
    }

    public Car(string make, string model, int year, string color)
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
    }
} 