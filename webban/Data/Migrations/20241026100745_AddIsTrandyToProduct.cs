using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webban.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsTrandyToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTrandy",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTrandy",
                table: "Products");
        }
    }
}
