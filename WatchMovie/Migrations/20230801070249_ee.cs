using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WatchMovie.Migrations
{
    /// <inheritdoc />
    public partial class ee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "achives",
                columns: table => new
                {
                    AchivementId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_achives", x => x.AchivementId);
                });

            migrationBuilder.CreateTable(
                name: "durations",
                columns: table => new
                {
                    durationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    minute = table.Column<int>(type: "integer", nullable: true),
                    minut_per_episede = table.Column<int>(type: "integer", nullable: true),
                    season = table.Column<int>(type: "integer", nullable: true),
                    episode = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_durations", x => x.durationId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Achivements",
                columns: table => new
                {
                    AchivementsId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilmId = table.Column<int>(type: "integer", nullable: false),
                    AchivementId = table.Column<int>(type: "integer", nullable: false),
                    year = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achivements", x => x.AchivementsId);
                    table.ForeignKey(
                        name: "FK_Achivements_achives_AchivementId",
                        column: x => x.AchivementId,
                        principalTable: "achives",
                        principalColumn: "AchivementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "films",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    year = table.Column<int>(type: "integer", nullable: false),
                    producer = table.Column<string>(type: "text", nullable: false),
                    country = table.Column<string>(type: "text", nullable: false),
                    durationId = table.Column<int>(type: "integer", nullable: false),
                    type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_films", x => x.FilmId);
                    table.ForeignKey(
                        name: "FK_films_durations_durationId",
                        column: x => x.durationId,
                        principalTable: "durations",
                        principalColumn: "durationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikedFilms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilmId = table.Column<int>(type: "integer", nullable: false),
                    userid = table.Column<int>(type: "integer", nullable: false),
                    usersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedFilms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikedFilms_User_usersId",
                        column: x => x.usersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikedFilms_films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Viewedfilms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilmId = table.Column<int>(type: "integer", nullable: false),
                    userid = table.Column<int>(type: "integer", nullable: false),
                    usersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viewedfilms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viewedfilms_User_usersId",
                        column: x => x.usersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Viewedfilms_films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achivements_AchivementId",
                table: "Achivements",
                column: "AchivementId");

            migrationBuilder.CreateIndex(
                name: "IX_films_durationId",
                table: "films",
                column: "durationId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedFilms_FilmId",
                table: "LikedFilms",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedFilms_usersId",
                table: "LikedFilms",
                column: "usersId");

            migrationBuilder.CreateIndex(
                name: "IX_Viewedfilms_FilmId",
                table: "Viewedfilms",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Viewedfilms_usersId",
                table: "Viewedfilms",
                column: "usersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achivements");

            migrationBuilder.DropTable(
                name: "LikedFilms");

            migrationBuilder.DropTable(
                name: "Viewedfilms");

            migrationBuilder.DropTable(
                name: "achives");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "films");

            migrationBuilder.DropTable(
                name: "durations");
        }
    }
}
