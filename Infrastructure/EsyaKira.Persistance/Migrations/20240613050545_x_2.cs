using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EsyaKira.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class x_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AppUsers",
                newName: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "AppUsers",
                newName: "Id");
        }
    }
}
