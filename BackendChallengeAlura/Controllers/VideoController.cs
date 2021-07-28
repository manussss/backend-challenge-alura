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
        public IActionResult AddVideo([FromBody] Video video)
        {
            videos.Add(video);
            return CreatedAtAction(nameof(GetVideo), new { id = video.Id }, video);
        }

        [HttpGet]
        public IActionResult GetVideo()
        {
            return Ok(videos);
        }

        [HttpGet("{id}")]
        public IActionResult GetVideo(int id)
        {
            var video = videos.FirstOrDefault(video => video.Id == id);
            return Ok(video);
        }


    }
}
