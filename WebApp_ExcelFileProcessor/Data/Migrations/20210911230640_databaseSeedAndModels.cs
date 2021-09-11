using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace WebApp_ExcelFileProcessor.Data.Migrations
{
    public partial class databaseSeedAndModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderChar = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "StudentClasses",
                columns: table => new
                {
                    StudentClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GradeInt = table.Column<int>(type: "int", nullable: false),
                    ClassChar = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClasses", x => x.StudentClassId);
                });

            migrationBuilder.CreateTable(
                name: "StudentColors",
                columns: table => new
                {
                    StudentColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentColors", x => x.StudentColorId);
                });

            migrationBuilder.CreateTable(
                name: "StudentGroups",
                columns: table => new
                {
                    StudentGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupChar = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    GroupInt = table.Column<int>(type: "int", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGroups", x => x.StudentGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentNr = table.Column<int>(type: "int", nullable: false),
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_StudentClasses_StudentClassId",
                        column: x => x.StudentClassId,
                        principalTable: "StudentClasses",
                        principalColumn: "StudentClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_StudentColors_StudentColorId",
                        column: x => x.StudentColorId,
                        principalTable: "StudentColors",
                        principalColumn: "StudentColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_StudentGroups_StudentGroupId",
                        column: x => x.StudentGroupId,
                        principalTable: "StudentGroups",
                        principalColumn: "StudentGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentTemps",
                columns: table => new
                {
                    StudentTempId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentNr = table.Column<int>(type: "int", nullable: false),
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    RowType = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTemps", x => x.StudentTempId);
                    table.ForeignKey(
                        name: "FK_StudentTemps_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTemps_StudentClasses_StudentClassId",
                        column: x => x.StudentClassId,
                        principalTable: "StudentClasses",
                        principalColumn: "StudentClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTemps_StudentColors_StudentColorId",
                        column: x => x.StudentColorId,
                        principalTable: "StudentColors",
                        principalColumn: "StudentColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTemps_StudentGroups_StudentGroupId",
                        column: x => x.StudentGroupId,
                        principalTable: "StudentGroups",
                        principalColumn: "StudentGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba566e0f-3d52-4967-a62c-1965b9f1e251", "77dfb63c-75c4-4b07-9ca7-60e20c442745", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1b824f5d-01b1-411b-8e44-5b05003ef81e", 0, "e2192038-6caf-4cf3-a30e-b8bca259fedd", "admin@fileprocessor.co.za", true, false, null, "ADMIN@FILEPROCESSOR.CO.ZA", "MYUSER", "AQAAAAEAACcQAAAAEMpytmv4iR3gFrImQ0lz8Q51XpudjdeCCdiHNgPsxjRYS4J+Cw+WEnL2fAVSgAh4Kg==", "0413743172", true, "e1098674-9488-42d1-8ec5-c970d066ec2d", false, "myuser" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("44a4c41a-9fbc-488e-a87e-819895c7d236"), new DateTime(2021, 9, 12, 1, 6, 39, 683, DateTimeKind.Local).AddTicks(5570), "F", "Female", false },
                    { new Guid("d7d5019e-d112-4606-94f2-3427e501a826"), new DateTime(2021, 9, 12, 1, 6, 39, 684, DateTimeKind.Local).AddTicks(2883), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("aead13d6-53e1-491a-83e2-3d28bdf242df"), "G", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2454), "10G", 10, false },
                    { new Guid("085fa5e2-d1ed-43ea-b0c0-d53eb0af3764"), "A", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2456), "11A", 11, false },
                    { new Guid("c071ad73-7df3-428a-b182-554418ad30d5"), "B", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2458), "11B", 11, false },
                    { new Guid("a754f527-5e8f-4eb6-8035-20f1d48a5749"), "C", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2459), "11C", 11, false },
                    { new Guid("947947fb-b35f-47a5-aa41-789a256e5fd4"), "D", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2463), "11D", 11, false },
                    { new Guid("a612cf51-5f97-4ef1-8626-554d4ce41782"), "E", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2466), "11E", 11, false },
                    { new Guid("ba52f91a-4ca9-46c4-a378-6b562bfea6b6"), "F", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2468), "11F", 11, false },
                    { new Guid("aaa10f0a-d42b-4754-ba7f-72c0739f4e3c"), "A", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2471), "12A", 12, false },
                    { new Guid("c779495e-2145-416c-b4b0-b73e76ecd27d"), "E", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2450), "10E", 10, false },
                    { new Guid("60820ea7-7fc2-430b-b730-f0d4237ce952"), "B", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2473), "12B", 12, false },
                    { new Guid("95e96de4-de4e-4b71-bed1-88e7381d0a18"), "C", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2475), "12C", 12, false },
                    { new Guid("659181e1-31f4-4378-8b21-502998a3ffbc"), "D", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2476), "12D", 12, false },
                    { new Guid("9deb2238-2120-405e-81d3-b62137f33d8b"), "E", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2478), "12E", 12, false },
                    { new Guid("9bc5fb4f-8619-4232-b2e3-ff22da853b6b"), "F", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2481), "12F", 12, false },
                    { new Guid("6bfbacac-3276-47ac-b0a7-090de42aa5eb"), "G", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2483), "12G", 12, false },
                    { new Guid("ad2d2514-a140-4894-a5ed-44d7e9271763"), "G", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2470), "11G", 11, false },
                    { new Guid("38e899f7-a630-4b62-8dfb-f887b96749a0"), "D", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2449), "10D", 10, false },
                    { new Guid("5fc5e4a3-6e81-4e51-8e5e-6cbe2321d244"), "F", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2452), "10F", 10, false },
                    { new Guid("8e8ea55c-6044-4cf2-9541-74de522ec643"), "B", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2444), "10B", 10, false },
                    { new Guid("2be0c387-f85d-4650-ab38-99d11a45a2d5"), "A", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2392), "8A", 8, false },
                    { new Guid("38126536-acb4-4124-8820-d8407e8dd59d"), "B", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2409), "8B", 8, false },
                    { new Guid("de4939d4-b456-4c5b-a5ae-7ee328e855b7"), "C", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2412), "8C", 8, false },
                    { new Guid("a991260e-b821-484e-84d3-8cc3944687be"), "D", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2413), "8D", 8, false },
                    { new Guid("4dd18416-7515-4225-b159-bbec5f11244a"), "C", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2445), "10C", 10, false },
                    { new Guid("a460d5cf-d703-4b7f-b258-5a44e626bf2c"), "F", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2418), "8F", 8, false },
                    { new Guid("09feb31a-342e-426b-a4cc-b62baa5fe5b6"), "G", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2419), "8G", 8, false },
                    { new Guid("2cc7235a-a1ca-4a2d-b691-556641a1c247"), "A", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2421), "9A", 9, false },
                    { new Guid("e697ed08-d88a-4c6f-9c68-45a8cc173464"), "E", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2415), "8E", 8, false },
                    { new Guid("fa7222f1-beaf-445c-8e71-1056943155e4"), "C", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2428), "9C", 9, false },
                    { new Guid("4011a853-12b2-4e81-8782-7aa08ef76253"), "D", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2430), "9D", 9, false },
                    { new Guid("9e84a944-3d8b-4737-8f7c-d09da2231f08"), "E", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2436), "9E", 9, false },
                    { new Guid("9af79d1c-96f7-4ac7-aff3-913e0f6aaba2"), "F", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2438), "9F", 9, false },
                    { new Guid("41e36fa5-de46-422a-a4f1-3bef505294c8"), "G", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2439), "9G", 9, false },
                    { new Guid("b42408a6-3ce8-4c7b-9db0-d7af31e0869e"), "A", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2442), "10A", 10, false },
                    { new Guid("b18ee44e-f8b5-4c8d-9c28-d8e0ce43a263"), "B", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(2425), "9B", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("750152ca-95fb-42ed-9e46-b2cdf6c2f133"), "Gold", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(1077), false },
                    { new Guid("5345b169-384e-4f23-845b-0b007807b84f"), "Scarlet", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(1089), false },
                    { new Guid("e63c09c3-2250-49e7-99e7-937144fb232e"), "Unassigned", new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(1092), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("cd313ca3-5e43-40f6-adfc-24c08295f7b6"), new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(3859), "G4", "G", 4, false },
                    { new Guid("8df86f32-d4a5-4944-9530-3a811c06310e"), new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(3845), "G1", "G", 1, false },
                    { new Guid("b76860e1-96ff-4f57-8ed9-93f02c4ca6c2"), new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(3855), "G2", "G", 2, false },
                    { new Guid("96eb1aca-5c71-44a5-b741-d0e1a8b1b559"), new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(3857), "G3", "G", 3, false },
                    { new Guid("5d7f019a-5543-4d95-9d85-7e2a664212db"), new DateTime(2021, 9, 12, 1, 6, 39, 685, DateTimeKind.Local).AddTicks(3860), "G5", "G", 5, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ba566e0f-3d52-4967-a62c-1965b9f1e251", "1b824f5d-01b1-411b-8e44-5b05003ef81e" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_GenderId",
                table: "Students",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentClassId",
                table: "Students",
                column: "StudentClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentColorId",
                table: "Students",
                column: "StudentColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentGroupId",
                table: "Students",
                column: "StudentGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_GenderId",
                table: "StudentTemps",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_StudentClassId",
                table: "StudentTemps",
                column: "StudentClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_StudentColorId",
                table: "StudentTemps",
                column: "StudentColorId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_StudentGroupId",
                table: "StudentTemps",
                column: "StudentGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "StudentTemps");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "StudentClasses");

            migrationBuilder.DropTable(
                name: "StudentColors");

            migrationBuilder.DropTable(
                name: "StudentGroups");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba566e0f-3d52-4967-a62c-1965b9f1e251", "1b824f5d-01b1-411b-8e44-5b05003ef81e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e");
        }
    }
}