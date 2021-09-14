using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class newDatabaseInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    StudentTempId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                values: new object[] { "ba566e0f-3d52-4967-a62c-1965b9f1e251", "f1816529-f3fb-44c7-8f0b-26e54a693ace", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1b824f5d-01b1-411b-8e44-5b05003ef81e", 0, "f6b546d1-ae31-4fce-8217-f7e08a6069a4", "admin@fileprocessor.co.za", true, false, null, "ADMIN@FILEPROCESSOR.CO.ZA", "MYUSER", "AQAAAAEAACcQAAAAECPvajvHFOEOdDvHMMPLFNoGMRrwie6svFQF/0RR7BcMaYSqdBuaar9/JgC9HW2s5g==", "0413743172", true, "c367ae51-e860-4ea1-9023-33aabf085c9b", false, "myuser" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("e2faf3fd-85bd-4444-b49b-a76d258eeb53"), new DateTime(2021, 9, 14, 9, 47, 20, 723, DateTimeKind.Local).AddTicks(6505), "F", "Female", false },
                    { new Guid("2fef4204-344a-48be-82ba-4acfcebacb4e"), new DateTime(2021, 9, 14, 9, 47, 20, 724, DateTimeKind.Local).AddTicks(4665), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("3f6ad0a5-d462-4866-b678-5ba3f7b70483"), "G", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5418), "10G", 10, false },
                    { new Guid("2917af15-88d0-4d9c-838d-46abda684c91"), "A", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5420), "11A", 11, false },
                    { new Guid("a84b91dd-3935-438d-a7d0-323d1c749c6f"), "B", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5422), "11B", 11, false },
                    { new Guid("f54215a6-83d0-4d94-bbef-11a18919c901"), "C", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5424), "11C", 11, false },
                    { new Guid("e9089b8f-a728-4fc5-b88d-e0888b4daa44"), "D", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5425), "11D", 11, false },
                    { new Guid("d05dcfa2-6498-48c1-ae6e-d98191b3dc1a"), "E", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5427), "11E", 11, false },
                    { new Guid("d93be269-866a-4aa2-acb0-2e382e9056ff"), "F", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5429), "11F", 11, false },
                    { new Guid("b823a31a-eeeb-4f6f-b81f-5ac10ba450bb"), "A", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5435), "12A", 12, false },
                    { new Guid("4aff3f1b-b8fc-4e06-b20d-da81a1709dc7"), "E", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5410), "10E", 10, false },
                    { new Guid("387e5659-96e6-4b37-a5fc-d0851c98cb77"), "B", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5436), "12B", 12, false },
                    { new Guid("3e8db05c-c5fe-4a2b-98eb-2054ca0b0609"), "C", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5438), "12C", 12, false },
                    { new Guid("2794a3ca-beca-44d4-b279-991ced4de48c"), "D", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5440), "12D", 12, false },
                    { new Guid("10460e0e-5750-4956-9258-a2a0f7692f71"), "E", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5442), "12E", 12, false },
                    { new Guid("6d9edf7e-9947-4ca6-b926-10473fcd7863"), "F", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5444), "12F", 12, false },
                    { new Guid("87dbad9c-0d8d-4d3e-b9e4-daa38f5e7ea3"), "G", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5445), "12G", 12, false },
                    { new Guid("4c35498f-0423-40c2-a014-bfacf1bb9e3b"), "G", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5432), "11G", 11, false },
                    { new Guid("d7c20edc-cd28-4692-a497-2becda6292b6"), "D", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5408), "10D", 10, false },
                    { new Guid("bd9a7165-3fb0-4cbe-8c84-f6ce7ecfe452"), "F", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5417), "10F", 10, false },
                    { new Guid("26729663-d062-43d9-b81e-5efa30c8178d"), "B", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5405), "10B", 10, false },
                    { new Guid("739267dd-d115-42f9-9bb9-f57c4c9682b7"), "A", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5357), "8A", 8, false },
                    { new Guid("ae32c125-3daf-44e1-8c0a-148775c9b1b6"), "B", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5367), "8B", 8, false },
                    { new Guid("147574c4-f652-4bd4-9054-0140e4839088"), "C", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5370), "8C", 8, false },
                    { new Guid("44b27aec-c3ba-40a4-8f42-b41345f2e111"), "D", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5380), "8D", 8, false },
                    { new Guid("7f3de78c-5731-4afe-bfa0-a85926b81b43"), "C", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5407), "10C", 10, false },
                    { new Guid("bb8232bb-fada-42fd-b1d8-d28ce1219300"), "F", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5384), "8F", 8, false },
                    { new Guid("7ee64972-92f6-4fb4-94ee-e8330acfd0bd"), "G", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5386), "8G", 8, false },
                    { new Guid("536948ff-9442-4946-bbd5-1a8541e69376"), "A", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5388), "9A", 9, false },
                    { new Guid("3feecbdf-1e5b-4b13-b229-bb2a9e47785b"), "E", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5382), "8E", 8, false },
                    { new Guid("2a842127-357c-4cac-bf80-96467cf21122"), "C", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5391), "9C", 9, false },
                    { new Guid("fd110450-f61b-4d56-b795-58e316f55118"), "D", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5393), "9D", 9, false },
                    { new Guid("263630e8-fb37-473e-bcbf-a0748ae81990"), "E", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5397), "9E", 9, false },
                    { new Guid("70283a29-3797-407c-8187-d108fae25cc1"), "F", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5399), "9F", 9, false },
                    { new Guid("835a09d7-cf33-4bfd-9b9a-10aee2f10bc2"), "G", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5401), "9G", 9, false },
                    { new Guid("79c91924-45ee-477c-9ba7-0e25204b7109"), "A", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5403), "10A", 10, false },
                    { new Guid("48971a93-6fa2-4728-9ab7-fd7de943d587"), "B", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5389), "9B", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("4806b1f3-9bef-4204-98b0-ca6521d0375c"), "Gold", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(3624), false },
                    { new Guid("b15da3a0-e97f-4e32-b09f-73945d1e363e"), "Scarlet", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(3637), false },
                    { new Guid("68344e92-1ff4-4ee3-9c4f-029ef7a5cc2a"), "Unassigned", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(3639), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("1ce5a107-bb19-4fa2-80db-5479de93fe67"), new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(6836), "G4", "G", 4, false },
                    { new Guid("9bb5f7d2-729e-4a58-8d90-a47dfd452b04"), new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(6789), "G1", "G", 1, false },
                    { new Guid("4b32ed04-8fa0-45c1-8fba-7071a2aabcf9"), new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(6798), "G2", "G", 2, false },
                    { new Guid("2a2dd538-beda-4c77-bdb0-684db17f72c6"), new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(6800), "G3", "G", 3, false },
                    { new Guid("b2ae0335-b5c8-4db3-a683-9458394ebe9f"), new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(6838), "G5", "G", 5, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ba566e0f-3d52-4967-a62c-1965b9f1e251", "1b824f5d-01b1-411b-8e44-5b05003ef81e" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "StudentTemps");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "StudentClasses");

            migrationBuilder.DropTable(
                name: "StudentColors");

            migrationBuilder.DropTable(
                name: "StudentGroups");
        }
    }
}