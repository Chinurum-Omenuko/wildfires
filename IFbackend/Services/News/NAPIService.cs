using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IFbackend.Services.News
{
    public class NAPIService: INAPIService
    {
        private readonly IHttpClientFactory _clientFactory;

        public NAPIService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IEnumerable<Models.News>> GetNewsAsync()
        {
            var client = _clientFactory.CreateClient("NewsAPI");
            var response = await client.GetAsync(requestUri: "");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var news = JsonConvert.DeserializeObject<List<Models.News>>(json);
#pragma warning disable CS8603 // Possible null reference return.
                return news;
#pragma warning restore CS8603 // Possible null reference return.
            }
            
            else
            {
                throw new Exception($"Error: {response.StatusCode}");
            }
        }
    }
}