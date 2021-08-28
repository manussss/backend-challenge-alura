using BackendChallengeAlura.Models;

namespace Aluraflix.API.Validations.Interfaces
{
    public interface IVideoValidation
    {
        bool DoesVideoHaveCategoriaID(Video video);
    }
}
