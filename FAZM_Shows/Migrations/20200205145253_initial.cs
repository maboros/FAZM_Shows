using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAZM_Shows.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Show",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    section = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    date = table.Column<string>(type: "nvarchar(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Show", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Show");
        }
    }
}
