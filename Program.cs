using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace weather_api
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpRequests httpRequests = new HttpRequests();
            await httpRequests.Execute();

            string jsonStr = HttpRequests.jsonString;
            
            WeatherForecast weatherForecast = 
                JsonSerializer.Deserialize<WeatherForecast>(jsonStr);

            if (weatherForecast != null)
            {
                Console.WriteLine("City name: " + weatherForecast.name);
                Console.WriteLine("Temperature: " + weatherForecast.main.temp);
                Console.WriteLine("Max temperature: " + weatherForecast.main.temp_max);
                Console.WriteLine("Min temperature: " + weatherForecast.main.temp_min);
                Console.WriteLine("Feels like: " + weatherForecast.main.feels_like);
            }
        }
    }
}