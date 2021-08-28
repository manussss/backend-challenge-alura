using Aluraflix.API.Validations.Interfaces;
using BackendChallengeAlura.Models;

namespace Aluraflix.API.Validations
{
    public class VideoValidation : IVideoValidation
    {
        public bool DoesVideoHaveCategoriaID(Video video)
        {
            if (string.IsNullOrEmpty(video.CategoriaId.ToString()) || video.CategoriaId == 0)
                return false;
            return true;
        }
    }
}
