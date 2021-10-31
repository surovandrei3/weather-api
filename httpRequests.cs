using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace weather_api
{
    public class HttpRequests
    {
        private static readonly HttpClient Client = new HttpClient();
        public static string jsonString { get; set; }
        public async Task Execute()
        {
            try	
            {
                HttpResponseMessage response = await Client.GetAsync(Config.ApiToken);
                response.EnsureSuccessStatusCode();
                jsonString = await response.Content.ReadAsStringAsync();
                
                //Console.WriteLine(jsonString);
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");	
                Console.WriteLine("Message :{0} ",e.Message);
            }
        }
    }
}