using BackendChallengeAlura.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendChallengeAlura.Data
{
    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public VideoContext(DbContextOptions<VideoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
