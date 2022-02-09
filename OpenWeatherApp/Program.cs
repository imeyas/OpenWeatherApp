using Newtonsoft.Json.Linq;
using System;

namespace OpenWeatherApp

{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIkey = JObject.Parse(key).GetValue("OpenWeatherApiKey").ToString();

            Console.WriteLine($"\nHello there! I was created to help you get the temperature of your current location. But, I need your help...\n");

            Thread.Sleep(3000);

            Console.WriteLine("Enter the zip code of your current location\n");
            var zipCode = Console.ReadLine();

            string apiCall = $"http://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIkey}";

            Thread.Sleep(1500);

            Console.WriteLine($"\nIt is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location\n");
        }

        
    }
}
