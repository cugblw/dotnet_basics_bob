// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using MyClassLibrary;

Scrape scrape = new Scrape();
string reply = scrape.ScrapeWebpage("https://docs.microsoft.com/zh-cn/");
Console.WriteLine(reply);