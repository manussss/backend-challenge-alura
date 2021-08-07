using BackendChallengeAlura.Controllers;
using BackendChallengeAlura.Models;
using BackendChallengeAlura.Services;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Aluraflix.API.Tests
{
    public class VideoControllerTest
    {

        [Fact]
        public void AddVideo()
        {
            var repo = new Mock<IVideoRepository>();
            repo.Setup(r => r.AddVideo(It.IsAny<Video>()));

            var videoController = new VideoController(repo.Object);
            videoController.AddVideo(new Video());

            repo.Verify(repo => repo.AddVideo(It.IsAny<Video>()), Times.Once);
        }

        [Fact]
        public void GetVideoById()
        {
            var repo = new Mock<IVideoRepository>();
            repo.Setup(r => r.GetVideo(It.IsAny<int>()));

            var videoController = new VideoController(repo.Object);
            videoController.GetVideo(1);

            repo.Verify(repo => repo.GetVideo(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void GetVideo()
        {
            var repo = new Mock<IVideoRepository>();
            repo.Setup(r => r.GetVideo()).Returns(new List<Video>());

            var videoController = new VideoController(repo.Object);
            videoController.GetVideo();

            repo.Verify(repo => repo.GetVideo(), Times.Once);
        }

        [Fact]
        public void UpdateVideo()
        {
            var repo = new Mock<IVideoRepository>();
            repo.Setup(r => r.UpdateVideo(It.IsAny<int>(), It.IsAny<Video>()));

            var videoController = new VideoController(repo.Object);
            videoController.UpdateVideo(1, new Video());

            repo.Verify(repo => repo.UpdateVideo(It.IsAny<int>(), It.IsAny<Video>()), Times.Once);
        }

        [Fact]
        public void DeleteVideo()
        {
            var repo = new Mock<IVideoRepository>();
            repo.Setup(r => r.DeleteVideo(It.IsAny<int>()));

            var videoController = new VideoController(repo.Object);
            videoController.DeleteVideo(1);

            repo.Verify(repo => repo.DeleteVideo(It.IsAny<int>()), Times.Once);
        }
    }
}
