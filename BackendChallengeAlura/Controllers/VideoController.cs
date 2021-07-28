using BackendChallengeAlura.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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
        }

        [HttpGet]
        public ICollection<Video> GetVideo()
        {
            return videos;
        }

        [HttpGet("{id}")]
        public Video GetVideo(int id)
        {
            var video = videos.FirstOrDefault(video => video.Id == id);
            return video;
        }


    }
}
