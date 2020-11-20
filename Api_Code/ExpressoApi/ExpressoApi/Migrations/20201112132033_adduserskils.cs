using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressoApi.Migrations
{
    public partial class adduserskils : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserSkills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSkillGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Skill = table.Column<string>(nullable: true),
                    Proficiency = table.Column<string>(nullable: true),
                    UserSkillsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkillGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSkillGroup_UserSkills_UserSkillsId",
                        column: x => x.UserSkillsId,
                        principalTable: "UserSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSkillGroup_UserSkillsId",
                table: "UserSkillGroup",
                column: "UserSkillsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSkillGroup");

            migrationBuilder.DropTable(
                name: "UserSkills");
        }
    }
}
