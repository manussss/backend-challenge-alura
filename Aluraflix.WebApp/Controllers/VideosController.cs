using Aluraflix.WebApp.HttpClients;
using Microsoft.AspNetCore.Mvc;

namespace Aluraflix.WebApp.Controllers
{
    [Route("[controller]")]
    public class VideosController : Controller
    {
        private readonly VideoApiClient _api;

        public VideosController(VideoApiClient api)
        {
            _api = api;
        }

        [Route("todos-videos")]
        public IActionResult GetVideos()
        {
            var videos = _api.GetVideoAsync();
            return View(videos.Result);
        }

        [Route("video/{id}")]
        public IActionResult GetVideo(int id)
        {
            var video = _api.GetVideoAsync(id);
            return View(video.Result);
        }
    }
}
