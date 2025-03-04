using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HauiRedo.Domain.Migrations
{
    /// <inheritdoc />
    public partial class _3addfieldnoteforcomputertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Computer");
        }
    }
}
