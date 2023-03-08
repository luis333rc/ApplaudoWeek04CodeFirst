using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplaudoWeek04CodeFirst.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstMidName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    PosterUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    TrailerUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Available = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieCopies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCopies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieCopies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieLikes",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieLikes", x => new { x.MovieId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_MovieLikes_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieLikes_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieTags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieTags", x => new { x.MovieId, x.TagId });
                    table.ForeignKey(
                        name: "FK_MovieTags_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    MovieCopyId = table.Column<int>(type: "int", nullable: false),
                    RentalDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 3, 7, 19, 59, 30, 703, DateTimeKind.Local).AddTicks(9823)),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rentals_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rentals_MovieCopies_MovieCopyId",
                        column: x => x.MovieCopyId,
                        principalTable: "MovieCopies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "FirstMidName", "LastName" },
                values: new object[,]
                {
                    { 1, "Max", "Jones" },
                    { 2, "Eve", "Jackson" },
                    { 3, "Mike", "Thompson" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Available", "Description", "PosterUrl", "Price", "Stock", "Title", "TrailerUrl" },
                values: new object[,]
                {
                    { 1, true, "Cuatro años después de la destrucción de Isla Nublar, los dinosaurios conviven – y cazan – con los seres humanos en todo el mundo. Este frágil equilibrio cambiará el futuro y decidirá, de una vez por todas, si los seres humanos seguirán en la cúspide de los depredadores en un planeta que comparten con los animales más temibles de la creación.", "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/VEZtsEQwsItZUoIdqzMwjvkwxI.jpg", 5.0, 10, "Jurassic World: Dominion", "https://youtu.be/9m9yRauMJIQ" },
                    { 2, true, "El cómico estadounidense Kevin Hart quiere ser una estrella de acción, pero para conseguir un papel que cambie su vida, primero tiene que aprender a ser un héroe de acción.", "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/xz91Gre0w7tyl99jGEh5oGc8DQ7.jpg", 4.0, 2, "Duro de entrenar", "https://youtu.be/kAYOmh5Kh2U" },
                    { 3, true, "Otto Anderson (Tom Hanks) es un viudo cascarrabias y muy obstinado. Cuando una alegre joven familia se muda a la casa de al lado, Otto encuentra la horma de su zapato en la espabilada, y muy embarazada, Marisol, lo que conlleva a una muy improbable amistad que pondrá su mundo patas arriba. Remake de la película sueca 'A Man Called Ove' de 2015.", "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/8bNLrZt9lrmnt6LsaGG8GfDfgYR.jpg", 5.0, 3, "El peor vecino del mundo", "https://youtu.be/SC6CHBZa4Xg" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Horror" },
                    { 3, "Comedy" },
                    { 4, "Thriller" },
                    { 5, "Mystery" },
                    { 6, "Drama" },
                    { 7, "Fantasy" },
                    { 8, "G" },
                    { 9, "PG" },
                    { 10, "PG-14" },
                    { 11, "R" }
                });

            migrationBuilder.InsertData(
                table: "MovieCopies",
                columns: new[] { "Id", "Available", "MovieId" },
                values: new object[,]
                {
                    { 1, true, 1 },
                    { 2, true, 1 },
                    { 3, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "MovieCopies",
                columns: new[] { "Id", "MovieId" },
                values: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "MovieCopies",
                columns: new[] { "Id", "Available", "MovieId" },
                values: new object[] { 5, true, 2 });

            migrationBuilder.InsertData(
                table: "MovieCopies",
                columns: new[] { "Id", "MovieId" },
                values: new object[] { 6, 3 });

            migrationBuilder.InsertData(
                table: "MovieCopies",
                columns: new[] { "Id", "Available", "MovieId" },
                values: new object[,]
                {
                    { 7, true, 3 },
                    { 8, true, 3 }
                });

            migrationBuilder.InsertData(
                table: "MovieLikes",
                columns: new[] { "CustomerId", "MovieId", "Likes" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 1, 3 },
                    { 3, 1, 5 },
                    { 1, 2, 2 },
                    { 2, 2, 3 },
                    { 3, 2, 5 },
                    { 1, 3, 4 },
                    { 2, 3, 5 },
                    { 3, 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "MovieTags",
                columns: new[] { "MovieId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 9 },
                    { 2, 2 },
                    { 2, 4 },
                    { 2, 8 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 5 },
                    { 3, 10 }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "CustomerId", "MovieCopyId", "RentalDate", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 1, 5, 10, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 6, 11, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 2, new DateTime(2023, 1, 5, 14, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 7, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, 3, new DateTime(2023, 1, 6, 10, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 16, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, 4, new DateTime(2023, 1, 7, 18, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 9, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 3, 5, new DateTime(2023, 1, 10, 8, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 11, 18, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, 6, new DateTime(2023, 1, 11, 9, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 12, 14, 40, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, 7, new DateTime(2023, 1, 13, 16, 50, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 3, 8, new DateTime(2023, 1, 14, 18, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 16, 13, 50, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_FirstMidName_LastName",
                table: "Customers",
                columns: new[] { "FirstMidName", "LastName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovieCopies_MovieId",
                table: "MovieCopies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieLikes_CustomerId",
                table: "MovieLikes",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Title",
                table: "Movies",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovieTags_TagId",
                table: "MovieTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CustomerId",
                table: "Rentals",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_MovieCopyId",
                table: "Rentals",
                column: "MovieCopyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_Name",
                table: "Tags",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieLikes");

            migrationBuilder.DropTable(
                name: "MovieTags");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "MovieCopies");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
