using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class newDatabase : Migration
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
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    StudentNr = table.Column<int>(type: "int", nullable: true),
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RowNumber = table.Column<int>(type: "int", nullable: true),
                    RowType = table.Column<string>(type: "nvarchar(1)", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentTemps_StudentClasses_StudentClassId",
                        column: x => x.StudentClassId,
                        principalTable: "StudentClasses",
                        principalColumn: "StudentClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentTemps_StudentColors_StudentColorId",
                        column: x => x.StudentColorId,
                        principalTable: "StudentColors",
                        principalColumn: "StudentColorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentTemps_StudentGroups_StudentGroupId",
                        column: x => x.StudentGroupId,
                        principalTable: "StudentGroups",
                        principalColumn: "StudentGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentScreening",
                columns: table => new
                {
                    StudentScreeningId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QRCodeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralSenseWellbeing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WearingAMask = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HighRiskTravel14Days = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CloseContactInfectedPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CloseContactProbableInfectedPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttendHealthFacility14Days = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdmittedSeverPneumonia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SufferFromChronicDisease = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnyOfTheFollowingSymptoms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScrenningTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentScreening", x => x.StudentScreeningId);
                    table.ForeignKey(
                        name: "FK_StudentScreening_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentScreeningTemps",
                columns: table => new
                {
                    StudentScreeningTempId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QRCodeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralSenseWellbeing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WearingAMask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighRiskTravel14Days = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloseContactInfectedPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloseContactProbableInfectedPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttendHealthFacility14Days = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmittedSeverPneumonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SufferFromChronicDisease = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyOfTheFollowingSymptoms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScrenningTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowNumber = table.Column<int>(type: "int", nullable: true),
                    RowType = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentScreeningTemps", x => x.StudentScreeningTempId);
                    table.ForeignKey(
                        name: "FK_StudentScreeningTemps_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba566e0f-3d52-4967-a62c-1965b9f1e251", "9059a526-56fb-417b-8c4c-543308efaf9b", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1b824f5d-01b1-411b-8e44-5b05003ef81e", 0, "b4626ff7-34f3-4ce2-9791-be5cdf9e443a", "admin@fileprocessor.co.za", true, false, null, "ADMIN@FILEPROCESSOR.CO.ZA", "MYUSER", "AQAAAAEAACcQAAAAENPdbh+dqONuoPvs9DK3wR2Al79M7Dolsjele76wGZKE0z+w1RzUNsaejZd2p8Ub4w==", "0413743172", true, "7059d4d9-bdab-4c7f-ae98-6266eca090c0", false, "myuser" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("f1311288-58a7-4c4d-9e3f-4aa5a6011183"), new DateTime(2021, 9, 17, 18, 26, 55, 69, DateTimeKind.Local).AddTicks(5133), "F", "Female", false },
                    { new Guid("87a9ae29-4986-4e7f-abcf-7690f6fd02d0"), new DateTime(2021, 9, 17, 18, 26, 55, 70, DateTimeKind.Local).AddTicks(2260), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("bf311bb5-b371-4bf4-bfe6-eaead4988522"), "G", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2402), "10G", 10, false },
                    { new Guid("ce7bc3e3-da30-4811-a82a-497936774c6e"), "A", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2404), "11A", 11, false },
                    { new Guid("e6aaa27f-eefc-4b70-b38c-8b49d8ee9613"), "B", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2406), "11B", 11, false },
                    { new Guid("e720f16a-e68b-4f8c-ae1a-269eb6840c46"), "C", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2408), "11C", 11, false },
                    { new Guid("df782962-399b-4581-8e99-a579f0a12bb7"), "D", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2411), "11D", 11, false },
                    { new Guid("85c69b91-3efd-45db-8624-becce1e6fd44"), "E", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2413), "11E", 11, false },
                    { new Guid("8811caff-fab7-431e-9260-a5034428ab82"), "F", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2417), "11F", 11, false },
                    { new Guid("5651210e-b87e-4ca8-860d-59e44bf7a8dd"), "A", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2420), "12A", 12, false },
                    { new Guid("1b13e3f3-c180-4c5e-9931-c2793f3392ac"), "E", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2398), "10E", 10, false },
                    { new Guid("8cf8eed2-f13a-4ea4-8244-3ccc39074b6e"), "B", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2422), "12B", 12, false },
                    { new Guid("1bf4a277-bfe5-48de-b91c-d0e6382a13a3"), "C", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2424), "12C", 12, false },
                    { new Guid("e8b2de3a-ed07-46eb-8dbf-f4c390506032"), "D", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2425), "12D", 12, false },
                    { new Guid("bdea7654-3e26-4920-985e-f6a2c131af75"), "E", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2427), "12E", 12, false },
                    { new Guid("69aaa886-fecf-4356-b1b4-a208a3d4f9c1"), "F", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2428), "12F", 12, false },
                    { new Guid("002a3274-96bc-4b34-9713-ad6ec9603bb9"), "G", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2432), "12G", 12, false },
                    { new Guid("1c1a8792-6097-4133-a3d8-a0cc6a38a855"), "G", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2418), "11G", 11, false },
                    { new Guid("d9548917-e032-47b3-9f66-bd5c0b305aba"), "D", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2394), "10D", 10, false },
                    { new Guid("605ce483-3978-444f-8d59-841e5e0aec56"), "F", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2400), "10F", 10, false },
                    { new Guid("c692ae4a-dc36-42b3-ae7c-aaf5704436a8"), "B", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2390), "10B", 10, false },
                    { new Guid("7c9dc483-6388-4848-9392-01b18d31964f"), "A", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2343), "8A", 8, false },
                    { new Guid("8a2ae3a5-1530-4027-87ff-3585acf03ea9"), "B", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2353), "8B", 8, false },
                    { new Guid("29387efe-6af6-491b-ae44-b72a53759f82"), "C", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2365), "8C", 8, false },
                    { new Guid("b1b57195-9868-4e89-a7ab-9fc3855234bf"), "D", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2367), "8D", 8, false },
                    { new Guid("9dfdf5d3-d3de-4f28-81ba-b15a516cd8ff"), "C", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2391), "10C", 10, false },
                    { new Guid("5cd9d438-4fcb-4e21-b4cc-86bacde19c18"), "F", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2371), "8F", 8, false },
                    { new Guid("8da29c56-9830-417c-9c69-064b96d4bfb1"), "G", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2373), "8G", 8, false },
                    { new Guid("0cda8333-1583-4c71-bc2d-5b59236ebc46"), "A", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2374), "9A", 9, false },
                    { new Guid("5b4d6256-4d76-4afa-8ca7-d62c3e82e358"), "E", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2369), "8E", 8, false },
                    { new Guid("3e7fd04d-6047-4d5f-9551-d40203369d15"), "C", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2378), "9C", 9, false },
                    { new Guid("76a7b4dc-c1bf-4a0b-a28f-de859591edd4"), "D", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2381), "9D", 9, false },
                    { new Guid("4fc55796-7ab1-450a-ad35-31d5c228d8ce"), "E", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2383), "9E", 9, false },
                    { new Guid("593874ab-1941-4d25-9eec-3367123895cd"), "F", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2385), "9F", 9, false },
                    { new Guid("f108810b-0dc9-49aa-a8f8-a89c11dcea15"), "G", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2386), "9G", 9, false },
                    { new Guid("f75c6065-8425-49d8-9608-4b83859d940d"), "A", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2388), "10A", 10, false },
                    { new Guid("82b4fbc0-d4ea-4462-8c0d-54a45dd30b59"), "B", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(2376), "9B", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("f7e67224-b161-41ed-bf08-43e0c2294033"), "Gold", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(836), false },
                    { new Guid("5bcbc6f8-596a-49cd-b219-81d096b4d267"), "Scarlet", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(850), false },
                    { new Guid("e1c107ae-2573-42b7-8958-66cd5c352738"), "Unassigned", new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(852), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("f7ffcfbb-6f9f-4627-b2a2-cbb5dfe9d5cd"), new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(3707), "G4", "G", 4, false },
                    { new Guid("851d53b4-6a9b-4776-b72d-63935db21a9c"), new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(3694), "G1", "G", 1, false },
                    { new Guid("06d02722-609b-492a-9300-a76f8c7a9ab1"), new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(3703), "G2", "G", 2, false },
                    { new Guid("3e27533d-43fd-454c-a6bb-de42a0bafeee"), new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(3705), "G3", "G", 3, false },
                    { new Guid("407e350a-a541-4086-ab0d-2979ae9723ff"), new DateTime(2021, 9, 17, 18, 26, 55, 71, DateTimeKind.Local).AddTicks(3709), "G5", "G", 5, false }
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
                name: "IX_StudentScreening_StudentId",
                table: "StudentScreening",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentScreeningTemps_StudentId",
                table: "StudentScreeningTemps",
                column: "StudentId");

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
                name: "StudentScreening");

            migrationBuilder.DropTable(
                name: "StudentScreeningTemps");

            migrationBuilder.DropTable(
                name: "StudentTemps");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Students");

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
