using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        //api key is 6d056eab11773a5e998752c9c36f95ba
        //https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={API key}
        // The latitude of Trussville is 33.619N. The longitude is -86.608W.
        public static void TrussvilleWeather()
        {
            HttpClient client = new HttpClient();
            var apiKey = "6d056eab11773a5e998752c9c36f95ba";
            var cityName = "Trussville";
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial"; ;
            var weatherResponse = client.GetStringAsync(weatherURL).Result;
            var weatherLocal = JObject.Parse(weatherResponse);      
            Console.WriteLine($"The weather in {cityName} is {weatherLocal["main"]["temp"]} degrees Fahrenheit");



        }
    }
}
