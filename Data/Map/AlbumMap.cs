
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spotifried.Models;

namespace Spotifried.Data.Map;

public class AlbumMap : IEntityTypeConfiguration<AlbumModel>
{
    public void Configure(EntityTypeBuilder<AlbumModel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Artist);
    }
}