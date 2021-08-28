using Aluraflix.API.Validations.Interfaces;
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
        private readonly IVideoValidation _videoValidation;

        public VideoController(IVideoRepository videoRepository, ILogger<VideoController> logger, IVideoValidation videoValidation)
        {
            _videoRepository = videoRepository;
            this.logger = logger;
            _videoValidation = videoValidation;
        }

        /// <summary>
        /// Adicionar um vídeo.
        /// </summary>
        /// <param name="video">Vídeo que será adicionado.</param>
        /// <response code="201">Um novo vídeo foi adicionado com sucesso.</response>
        [HttpPost]
        public IActionResult AddVideo([FromBody] Video video)
        {
            if (!_videoValidation.DoesVideoHaveCategoriaID(video))
                video.CategoriaId = 1;
            _videoRepository.AddVideo(video);
            logger.LogInformation($"Adding Video object, DT: {DateTime.Now}");
            return CreatedAtAction(nameof(GetVideo), new { id = video.Id }, video);
        }

        /// <summary>
        /// Obter todos os vídeos.
        /// </summary>
        /// <response code="200">A lista de vídeos foi obtida com sucesso.</response>
        [HttpGet]
        public IEnumerable<Video> GetVideo()
        {
            logger.LogInformation($"Return Video collection, DT: {DateTime.Now}");
            return _videoRepository.GetVideo();
        }

        /// <summary>
        /// Obter vídeo por id.
        /// </summary>
        /// <param name="id">ID do vídeo.</param>
        /// <response code="200">O vídeo foi obtido com sucesso.</response>
        [HttpGet("{id}")]
        public IActionResult GetVideo(int id)
        {
            var video = _videoRepository.GetVideo(id);
            logger.LogInformation($"Return Video by ID, DT: {DateTime.Now}");
            return Ok(video);
        }

        /// <summary>
        /// Alterar um vídeo.
        /// </summary>
        /// <param name="id">ID do vídeo.</param>
        /// <param name="newVideo">Novo vídeo.</param>
        /// <response code="204">O vídeo foi alterado com sucesso.</response>
        /// <response code="404">Não foi encontrado vídeo com este ID.</response>
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

        /// <summary>
        /// Deletar um vídeo.
        /// </summary>
        /// <param name="id">ID do vídeo.</param>
        /// <response code="204">O vídeo foi deletado com sucesso.</response>
        /// <response code="404">Não foi encontrado vídeo com este ID.</response>
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

        /// <summary>
        /// Obter vídeo por categoria.
        /// </summary>
        /// <param name="id">ID da categoria.</param>
        /// <response code="200">A lista de vídeos por categoria foi obtida com sucesso.</response>
        /// <response code="404">Não foram encontrados vídeos com esta categoria.</response>
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
