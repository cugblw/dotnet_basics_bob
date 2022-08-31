// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

DateTime now = DateTime.Now;
// Console.WriteLine(now.ToString());
// Console.WriteLine(now.ToShortDateString());
// Console.WriteLine(now.ToShortTimeString());
// Console.WriteLine(now.ToLongDateString());
// Console.WriteLine(now.ToLongTimeString());
// Console.WriteLine(now.AddDays(3).ToLongDateString());

// Console.WriteLine(now.AddHours(3).ToLongTimeString());
// Console.WriteLine(now.AddHours(-3).ToLongTimeString());

// Console.WriteLine(now.Month);

// DateTime myBirthday = new DateTime(1969, 12, 7);
// Console.WriteLine(myBirthday.ToShortDateString());

DateTime myBirthday = DateTime.Parse("12/7/1969");
TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
Console.WriteLine(myAge.TotalDays);