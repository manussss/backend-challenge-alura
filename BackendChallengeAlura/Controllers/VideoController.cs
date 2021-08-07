using BackendChallengeAlura.Data;
using BackendChallengeAlura.Models;
using BackendChallengeAlura.Services;
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
        private readonly IVideoRepository _videoRepository;

        public VideoController(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }
        
        [HttpPost]
        public IActionResult AddVideo([FromBody] Video video)
        {
            _videoRepository.AddVideo(video);
            return CreatedAtAction(nameof(GetVideo), new { id = video.Id }, video);
        }

        [HttpGet]
        public IEnumerable<Video> GetVideo()
        {
            return _videoRepository.GetVideo();
        }

        [HttpGet("{id}")]
        public IActionResult GetVideo(int id)
        {
            var video = _videoRepository.GetVideo(id);
            return Ok(video);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVideo(int id, [FromBody] Video newVideo)
        {
            var isUpdated = _videoRepository.UpdateVideo(id, newVideo);
            if(isUpdated == false)
                return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideo(int id)
        {
            var isDeleted = _videoRepository.DeleteVideo(id);
            if (isDeleted == false)
                return NotFound();
            return NoContent();
        }

        [HttpGet]
        [Route("{id}/categoria")]
        public IActionResult GetVideosByCategoria(int id)
        {
            var videos = _videoRepository
                .GetVideo()
                .Where(v => v.CategoriaId == id);

            if (videos != null)
                return Ok(videos);
            return NotFound();
        }
    }
}
