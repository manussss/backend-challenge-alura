using BackendChallengeAlura.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendChallengeAlura.Data
{
    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }

        public VideoContext(DbContextOptions<VideoContext> options) : base(options)
        {

        }
    }
}
