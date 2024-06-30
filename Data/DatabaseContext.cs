using Microsoft.EntityFrameworkCore;
using Spotifried.Models;

namespace Spotifried.Data;

class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{

    public DbSet<MusicModel> Music { get; set; }

}