
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spotifried.Models;

namespace Spotifried.Data.Map;

public class MusicMap : IEntityTypeConfiguration<MusicModel>
{
    public void Configure(EntityTypeBuilder<MusicModel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Album);
    }
}