using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class OneToOneAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FavouriteAlbumId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FavouriteAlbums",
                columns: table => new
                {
                    FavouriteAlbumId = table.Column<int>(type: "INTEGER", nullable: false),
                    FavouriteAlbumName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteAlbums", x => x.FavouriteAlbumId);
                    table.ForeignKey(
                        name: "FK_FavouriteAlbums_AspNetUsers_FavouriteAlbumId",
                        column: x => x.FavouriteAlbumId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavouriteAlbums");

            migrationBuilder.DropColumn(
                name: "FavouriteAlbumId",
                table: "AspNetUsers");
        }
    }
}
