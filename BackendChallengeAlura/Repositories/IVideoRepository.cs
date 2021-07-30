using BackendChallengeAlura.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallengeAlura.Services
{
    public interface IVideoRepository
    {
        void AddVideo(Video video);
        IEnumerable<Video> GetVideo();
        Video GetVideo(int id);
        bool UpdateVideo(int id, Video video);
        bool DeleteVideo(int id);
    }
}
