using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            var kanyeUrl = "https://api.kanye.rest";

            var client = new HttpClient();

            var kanyeResponse = client.GetStringAsync(kanyeUrl).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine(kanyeQuote);
            Console.ReadLine();
            var swansonUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var clientTwo = new HttpClient();

            var ronResponse = clientTwo.GetStringAsync(swansonUrl).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine(ronQuote);
            Console.ReadLine();
        }
    }
}
