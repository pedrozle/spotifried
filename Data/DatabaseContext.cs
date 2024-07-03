using Microsoft.EntityFrameworkCore;
using Spotifried.Data.Map;
using Spotifried.Models;

namespace Spotifried.Data;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{

    public DbSet<MusicModel> Music { get; set; }

    public DbSet<UserModel> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AlbumMap());
        modelBuilder.ApplyConfiguration(new MusicMap());
        modelBuilder.Entity<MusicModel>()
            .HasMany(m => m.Ratings)
            .WithOne(r => r.MusicModel)
            .HasForeignKey(r => r.MusicModelId);
        base.OnModelCreating(modelBuilder);
    }

}