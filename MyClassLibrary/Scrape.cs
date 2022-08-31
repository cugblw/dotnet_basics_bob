using System.Net;
namespace MyClassLibrary;
public class Scrape
{
    public string ScrapeWebpage(string url)
    {
        return GetWebpage(url);
    }

    public string ScrapeWebpage(string url, string filePath)
    {
        string reply = GetWebpage(url);
        File.WriteAllText(filePath, reply);
        return reply;
    }

    private string GetWebpage(string url)
    {
        WebClient client = new WebClient();
        return client.DownloadString(url);
        // HttpClient client = new HttpClient();
        // return client.GetStringAsync(url);
    }
}
