using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Birth = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Birth", "LastName", "Name" },
                values: new object[,]
                {
                    { 1, 21, new DateOnly(2002, 11, 19), "Valerio", "Mattia" },
                    { 2, 30, new DateOnly(1991, 1, 1), "Rossi", "Mario" },
                    { 3, 25, new DateOnly(1996, 5, 5), "Bianchi", "Luca" },
                    { 4, 40, new DateOnly(1981, 2, 2), "Verdi", "Luca" },
                    { 5, 25, new DateOnly(1996, 10, 10), "Doe", "John" },
                    { 6, 22, new DateOnly(1999, 5, 5), "Doe", "Jane" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
