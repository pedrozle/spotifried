using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spotifried.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlFile = Path.Combine("Migrations", "SQL", "initial_data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE Music");
            migrationBuilder.Sql("TRUNCATE TABLE AlbumModel");
            migrationBuilder.Sql("TRUNCATE TABLE ArtistModel");
        }
    }
}
