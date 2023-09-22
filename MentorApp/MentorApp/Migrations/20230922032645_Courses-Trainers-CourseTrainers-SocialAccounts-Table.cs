using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentorApp.Migrations
{
    public partial class CoursesTrainersCourseTrainersSocialAccountsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SocialAccountId",
                table: "Trainers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SocialAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialAccounts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_SocialAccountId",
                table: "Trainers",
                column: "SocialAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_SocialAccounts_SocialAccountId",
                table: "Trainers",
                column: "SocialAccountId",
                principalTable: "SocialAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_SocialAccounts_SocialAccountId",
                table: "Trainers");

            migrationBuilder.DropTable(
                name: "SocialAccounts");

            migrationBuilder.DropIndex(
                name: "IX_Trainers_SocialAccountId",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "SocialAccountId",
                table: "Trainers");
        }
    }
}
