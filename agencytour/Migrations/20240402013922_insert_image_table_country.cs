using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace agencytour.Migrations
{
    /// <inheritdoc />
    public partial class insert_image_table_country : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Countries",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Countries");
        }
    }
}
