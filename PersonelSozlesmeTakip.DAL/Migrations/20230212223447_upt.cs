using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelSozlesmeTakip.DAL.Migrations
{
    public partial class upt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Campuses_Id",
                table: "Faculties");

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_CampusId",
                table: "Faculties",
                column: "CampusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Campuses_CampusId",
                table: "Faculties",
                column: "CampusId",
                principalTable: "Campuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Campuses_CampusId",
                table: "Faculties");

            migrationBuilder.DropIndex(
                name: "IX_Faculties_CampusId",
                table: "Faculties");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Campuses_Id",
                table: "Faculties",
                column: "Id",
                principalTable: "Campuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
