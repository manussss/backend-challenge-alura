using Aluraflix.WebApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
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

        public async Task<Video> GetVideoAsync(int id)
        {
            Video video = new Video();
            var response = await _httpClient.GetAsync($"video/{id}");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                video = JsonConvert.DeserializeObject<Video>(result);
            }
            return video;
        }

        public async Task PostVideoAsync(Video video)
        {
            var response = await _httpClient.PostAsJsonAsync<Video>($"video", video);
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
