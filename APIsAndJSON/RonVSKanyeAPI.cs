using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void Convo()
        {
             HttpClient client = new HttpClient();
                      
            for (int i = 0; i < 6; i++)
            {        
                string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                var ronResponse = client.GetStringAsync(ronURL).Result;
                var ronQuote = JArray.Parse(ronResponse);

                string kanyeURL = "https://api.kanye.rest/";
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var kanyeQuote = JObject.Parse(kanyeResponse);
                Console.WriteLine($"Ron:{ronQuote[0]}");
                Console.WriteLine();
                Console.WriteLine($"Kanye:{kanyeQuote["quote"]}.");
                Console.WriteLine();
            }
        }
    }  
}
