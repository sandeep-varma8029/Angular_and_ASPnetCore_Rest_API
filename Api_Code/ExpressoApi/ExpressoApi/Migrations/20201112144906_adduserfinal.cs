using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressoApi.Migrations
{
    public partial class adduserfinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserFinal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Skill = table.Column<string>(nullable: true),
                    Proficiency = table.Column<string>(nullable: true),
                    Id_UserSkills = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFinal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFinal_UserSkills_Id_UserSkills",
                        column: x => x.Id_UserSkills,
                        principalTable: "UserSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFinal_Id_UserSkills",
                table: "UserFinal",
                column: "Id_UserSkills");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFinal");
        }
    }
}
