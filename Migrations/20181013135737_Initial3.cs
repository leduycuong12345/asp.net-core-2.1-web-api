using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Edmin",
                columns: table => new
                {
                    edminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    edminName = table.Column<string>(nullable: true),
                    edminrPass = table.Column<string>(nullable: true),
                    edminMail = table.Column<string>(nullable: true),
                    edminPhone = table.Column<string>(nullable: true),
                    edminAddress = table.Column<string>(nullable: true),
                    edminImageLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edmin", x => x.edminId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Edmin");
        }
    }
}
