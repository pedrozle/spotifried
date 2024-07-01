using Microsoft.EntityFrameworkCore;
using Spotifried.Models;

namespace Spotifried.Data;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{

    public DbSet<MusicModel> Music { get; set; }

    public DbSet<UserModel> Users { get; set; }

}