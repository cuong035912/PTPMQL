using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMvc.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    cancuoccongdan = table.Column<string>(type: "TEXT", nullable: false),
                    hoten = table.Column<string>(type: "TEXT", nullable: false),
                    quequan = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.cancuoccongdan);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    TenLop = table.Column<string>(type: "TEXT", nullable: false),
                    MaLop = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.TenLop);
                });
        }
    }
}
