// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

try 
{
    string content = File.ReadAllText(@"example.txt");
    Console.WriteLine(content);    
}
catch (FileNotFoundException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Make sure the name of the file is named correctly: example.txt.");
}
catch (DirectoryNotFoundException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Make sure the directory exists.");
}
catch(Exception e)
{
    Console.WriteLine("There was a problem reading the file.");
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Closing application now ...");
}
