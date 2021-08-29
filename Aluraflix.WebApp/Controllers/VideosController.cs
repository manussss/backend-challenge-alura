using Aluraflix.WebApp.HttpClients;
using Microsoft.AspNetCore.Mvc;

namespace Aluraflix.WebApp.Controllers
{
    public class VideosController : Controller
    {
        private readonly VideoApiClient _api;

        public VideosController(VideoApiClient api)
        {
            _api = api;
        }

        public IActionResult Videos()
        {
            var videos = _api.GetVideoAsync();
            return View(videos.Result);
        }
    }
}
