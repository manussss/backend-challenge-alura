using BackendChallengeAlura.Data;
using BackendChallengeAlura.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BackendChallengeAlura.Services
{
    public class VideoRepository : IVideoRepository
    {

        private readonly VideoContext _context;

        public VideoRepository(VideoContext context)
        {
            _context = context;
        }

        public void AddVideo(Video video)
        {
            _context.Videos.Add(video);
            _context.SaveChanges();
        }

        public bool DeleteVideo(int id)
        {
            var video = _context.Videos.FirstOrDefault(video => video.Id == id);
            if(video != null)
            {
                _context.Remove(video);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Video> GetVideo()
        {
            return _context.Videos;
        }

        public Video GetVideo(int id)
        {
            var video = _context.Videos.FirstOrDefault(video => video.Id == id);
            return video;
        }

        public bool UpdateVideo(int id, Video newVideo)
        {
            var video = _context.Videos.FirstOrDefault(video => video.Id == id);
            if(video != null)
            { 
                video.Titulo = newVideo.Titulo;
                video.Descricao = newVideo.Descricao;
                video.Url = newVideo.Url;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
