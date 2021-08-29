using Aluraflix.WebApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Aluraflix.WebApp.HttpClients
{
    public class VideoApiClient
    {
        private readonly HttpClient _httpClient;

        public VideoApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IList<Video>> GetVideoAsync()
        {
            IList<Video> videos = new List<Video>();
            var response = await _httpClient.GetAsync($"video");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                videos = JsonConvert.DeserializeObject<List<Video>>(result);
            }
            return videos;
        }
    }
}
