using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Age",
                value: 22);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Age",
                value: 33);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Age",
                value: 28);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Age",
                value: 43);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5,
                column: "Age",
                value: 28);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6,
                column: "Age",
                value: 25);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Age",
                value: 21);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Age",
                value: 30);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                column: "Age",
                value: 25);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                column: "Age",
                value: 40);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5,
                column: "Age",
                value: 25);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6,
                column: "Age",
                value: 22);
        }
    }
}
