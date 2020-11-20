using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressoApi.Migrations
{
    public partial class addproficiency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proficiency",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proficiency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProficiencyGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ProficiencyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProficiencyGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProficiencyGroup_Proficiency_ProficiencyId",
                        column: x => x.ProficiencyId,
                        principalTable: "Proficiency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProficiencyGroup_ProficiencyId",
                table: "ProficiencyGroup",
                column: "ProficiencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProficiencyGroup");

            migrationBuilder.DropTable(
                name: "Proficiency");
        }
    }
}
