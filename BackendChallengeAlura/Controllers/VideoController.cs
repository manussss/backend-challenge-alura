using BackendChallengeAlura.Models;
using BackendChallengeAlura.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<VideoController> logger;

        public VideoController(IVideoRepository videoRepository, ILogger<VideoController> logger)
        {
            _videoRepository = videoRepository;
            this.logger = logger;
        }
        
        [HttpPost]
        public IActionResult AddVideo([FromBody] Video video)
        {
            _videoRepository.AddVideo(video);
            logger.LogInformation($"Adding Video object, DT: {DateTime.Now}");
            return CreatedAtAction(nameof(GetVideo), new { id = video.Id }, video);
        }

        [HttpGet]
        public IEnumerable<Video> GetVideo()
        {
            logger.LogInformation($"Return Video collection, DT: {DateTime.Now}");
            return _videoRepository.GetVideo();
        }

        [HttpGet("{id}")]
        public IActionResult GetVideo(int id)
        {
            var video = _videoRepository.GetVideo(id);
            logger.LogInformation($"Return Video by ID, DT: {DateTime.Now}");
            return Ok(video);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVideo(int id, [FromBody] Video newVideo)
        {
            var isUpdated = _videoRepository.UpdateVideo(id, newVideo);
            if(isUpdated == false)
            {
                logger.LogInformation($"Updating Video, DT: {DateTime.Now}");
                return NotFound();
            }
            logger.LogInformation($"Tried to update Video, but no Video with such id was found, DT: {DateTime.Now}");
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideo(int id)
        {
            var isDeleted = _videoRepository.DeleteVideo(id);
            if (isDeleted == false)
            {
                logger.LogInformation($"Deleting Video, DT: {DateTime.Now}");
                return NotFound();
            }
            logger.LogInformation($"Tried to delete Video, but no Video with such id was found, DT: {DateTime.Now}");
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
            {
                logger.LogInformation($"Returning Videos by Categoria, DT: {DateTime.Now}");
                return Ok(videos);
            }
            logger.LogInformation($"Tried to return Videos by Categoria, " +
                $"but no Video with such CategoriaId was found, DT: {DateTime.Now}");
            return NotFound();
        }
    }
}
