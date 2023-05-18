using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code_First.Migrations
{
    /// <inheritdoc />
    public partial class Kathe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Section",
                table: "Grade");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Grade",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
