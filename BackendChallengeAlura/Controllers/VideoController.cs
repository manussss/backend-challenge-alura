using BackendChallengeAlura.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BackendChallengeAlura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoController : ControllerBase
    {
        private static IList<Video> videos = new List<Video>();
        
        [HttpPost]
        public void AddVideo([FromBody] Video video)
        {
            videos.Add(video);
            Console.WriteLine($"O video recebido é: {video.Titulo}");
        }


    }
}
