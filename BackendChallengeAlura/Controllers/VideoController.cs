using BackendChallengeAlura.Data;
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
        private VideoContext _context;

        public VideoController(VideoContext context)
        {
            _context = context;
        }
        
        [HttpPost]
        public IActionResult AddVideo([FromBody] Video video)
        {
            _context.Videos.Add(video);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetVideo), new { id = video.Id }, video);
        }

        [HttpGet]
        public IEnumerable<Video> GetVideo()
        {
            return _context.Videos;
        }

        [HttpGet("{id}")]
        public IActionResult GetVideo(int id)
        {
            var video = _context.Videos.FirstOrDefault(video => video.Id == id);
            return Ok(video);
        }


    }
}
