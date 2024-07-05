using Microsoft.EntityFrameworkCore;
using Spotifried.Models;

namespace Spotifried.Data;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{

    public DbSet<ArtistModel> Artists { get; set; }
    public DbSet<AlbumModel> Albuns { get; set; }
    public DbSet<MusicModel> Musics { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<UserModel> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configurar relacionamento entre Artista e Album
        modelBuilder.Entity<AlbumModel>()
            .HasOne(a => a.Artist)
            .WithMany(a => a.Albuns)
            .HasForeignKey(a => a.ArtistId);

        // Configurar relacionamento entre Album e Musica
        modelBuilder.Entity<MusicModel>()
            .HasOne(m => m.Album)
            .WithMany(a => a.Musics)
            .HasForeignKey(m => m.AlbumId);

        // Configurar Generos como uma lista de strings
        modelBuilder.Entity<AlbumModel>()
            .Property(a => a.Genres)
            .HasConversion(
                g => string.Join(',', g),
                g => g.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
            );

        // Configurar relacionamento entre Musica e Rating
        modelBuilder.Entity<Rating>()
            .HasOne(r => r.User)
            .WithMany(u => u.Ratings)
            .HasForeignKey(r => r.UserId);

        modelBuilder.Entity<Rating>()
            .HasOne(r => r.Music)
            .WithMany(m => m.Ratings)
            .HasForeignKey(r => r.MusicId);
    }

}