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

        [HttpPut("{id}")]
        public IActionResult UpdateVideo(int id, [FromBody] Video newVideo)
        {
            var video = _context.Videos.FirstOrDefault(video => video.Id == id);
            if(video == null)
                return NotFound();

            video.Titulo = newVideo.Titulo;
            video.Descricao = newVideo.Descricao;
            video.Url = newVideo.Url;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideo(int id)
        {
            var video = _context.Videos.FirstOrDefault(video => video.Id == id);
            if (video == null)
                return NotFound();

            _context.Remove(video);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
