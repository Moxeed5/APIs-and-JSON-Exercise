using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static async Task getWeatherAsync()
        {

            HttpClient client = new HttpClient();

            string apiKey = "c51e589d81c43e9974ad0ce2ffcaaa28\r\n";

            Console.WriteLine("Enter a city: ");
            var cityName = Console.ReadLine();


            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}";

            var weatherResponse = client.GetStringAsync(url).Result;

            var weatherObject = JObject.Parse(weatherResponse).GetValue("main");

            Console.WriteLine("Weather Object");
            Console.WriteLine(weatherObject);
            Console.WriteLine();




        }
    }
}
