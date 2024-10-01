using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMvc.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Employe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "TEXT",
                maxLength: 8,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");
        }
    }
}
