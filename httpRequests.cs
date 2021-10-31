using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace weather_api
{
    public class HttpRequests
    {
        static readonly HttpClient Client = new HttpClient();
        
        public async Task Execute()
        {
            try	
            {
                HttpResponseMessage response = await Client.GetAsync(Config.ApiToken);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");	
                Console.WriteLine("Message :{0} ",e.Message);
            }
        }
    }
}