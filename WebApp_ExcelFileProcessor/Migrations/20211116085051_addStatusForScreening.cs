using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class addStatusForScreening : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ScreeningStatusId",
                table: "StudentScreeningTemps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ScreeningStatusId",
                table: "StudentScreening",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ScreeningStatuses",
                columns: table => new
                {
                    ScreeningStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScreeningStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreeningStatuses", x => x.ScreeningStatusId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentScreeningTemps_ScreeningStatusId",
                table: "StudentScreeningTemps",
                column: "ScreeningStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentScreening_ScreeningStatusId",
                table: "StudentScreening",
                column: "ScreeningStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentScreening_ScreeningStatuses_ScreeningStatusId",
                table: "StudentScreening",
                column: "ScreeningStatusId",
                principalTable: "ScreeningStatuses",
                principalColumn: "ScreeningStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentScreeningTemps_ScreeningStatuses_ScreeningStatusId",
                table: "StudentScreeningTemps",
                column: "ScreeningStatusId",
                principalTable: "ScreeningStatuses",
                principalColumn: "ScreeningStatusId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentScreening_ScreeningStatuses_ScreeningStatusId",
                table: "StudentScreening");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentScreeningTemps_ScreeningStatuses_ScreeningStatusId",
                table: "StudentScreeningTemps");

            migrationBuilder.DropTable(
                name: "ScreeningStatuses");

            migrationBuilder.DropIndex(
                name: "IX_StudentScreeningTemps_ScreeningStatusId",
                table: "StudentScreeningTemps");

            migrationBuilder.DropIndex(
                name: "IX_StudentScreening_ScreeningStatusId",
                table: "StudentScreening");

            migrationBuilder.DropColumn(
                name: "ScreeningStatusId",
                table: "StudentScreeningTemps");

            migrationBuilder.DropColumn(
                name: "ScreeningStatusId",
                table: "StudentScreening");
        }
    }
}
