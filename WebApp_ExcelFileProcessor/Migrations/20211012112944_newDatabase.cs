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
                name: "ModuleCodes",
                columns: table => new
                {
                    ModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModuleCodeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleCodes", x => x.ModuleCodeId);
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
                name: "Audits",
                columns: table => new
                {
                    AuditId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffectedColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audits", x => x.AuditId);
                    table.ForeignKey(
                        name: "FK_Audits_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GradeModuleRoster",
                columns: table => new
                {
                    GradeModuleRosterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    GradeInt = table.Column<int>(type: "int", nullable: false),
                    ModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeModuleRoster", x => x.GradeModuleRosterId);
                    table.ForeignKey(
                        name: "FK_GradeModuleRoster_ModuleCodes_ModuleCodeId",
                        column: x => x.ModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
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
                    ScreeningTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    ScreeningTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                values: new object[] { "ba566e0f-3d52-4967-a62c-1965b9f1e251", "692c9f46-6f32-45f5-a37c-2ee5cbd8af26", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1b824f5d-01b1-411b-8e44-5b05003ef81e", 0, "2529ed61-82c4-415b-864b-8c948568da6d", "admin@fileprocessor.co.za", true, false, null, "ADMIN@FILEPROCESSOR.CO.ZA", "MYUSER", "AQAAAAEAACcQAAAAECgIok6zJYLhlrww2Qk9yxl03G0L4dvIV8gkJndP2n9xNa9SRY4Or8tZB/3LtaAafA==", "0413743172", true, "ec5091d8-9530-4c19-bbd2-bee3b39fe9b5", false, "myuser" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("d2be1264-55d6-46c0-845d-3f298f8fd8c7"), new DateTime(2021, 10, 12, 13, 29, 43, 135, DateTimeKind.Local).AddTicks(7439), "F", "Female", false },
                    { new Guid("e8cba006-00e4-4f77-83dc-0818e77fa6a9"), new DateTime(2021, 10, 12, 13, 29, 43, 136, DateTimeKind.Local).AddTicks(6782), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "ModuleCodes",
                columns: new[] { "ModuleCodeId", "DateCreated", "IsDeleted", "ModuleCodeName" },
                values: new object[,]
                {
                    { new Guid("3c56022e-141c-44e5-9ccd-843efb0f0439"), new DateTime(2021, 10, 12, 13, 29, 43, 178, DateTimeKind.Local).AddTicks(26), false, "EXAM" },
                    { new Guid("3dd031d1-f007-4197-9e20-12277c3aff79"), new DateTime(2021, 10, 12, 13, 29, 43, 178, DateTimeKind.Local).AddTicks(22), false, "LO" },
                    { new Guid("a4db6b39-dfc2-4bb6-baa9-0714d2ffb628"), new DateTime(2021, 10, 12, 13, 29, 43, 178, DateTimeKind.Local).AddTicks(19), false, "AFR/XHO" },
                    { new Guid("a28196f1-2219-4849-b37c-6bc5680272f0"), new DateTime(2021, 10, 12, 13, 29, 43, 177, DateTimeKind.Local).AddTicks(9998), false, "ABCP" },
                    { new Guid("72100cc1-f93a-432c-afaf-d0364440c622"), new DateTime(2021, 10, 12, 13, 29, 43, 178, DateTimeKind.Local).AddTicks(2), false, "ENG" },
                    { new Guid("21254de8-8102-4ab0-95a0-2a8fbe5a89ce"), new DateTime(2021, 10, 12, 13, 29, 43, 177, DateTimeKind.Local).AddTicks(9992), false, "LHC" },
                    { new Guid("59d47df0-f253-47ef-9fb4-1dd087e4714f"), new DateTime(2021, 10, 12, 13, 29, 43, 177, DateTimeKind.Local).AddTicks(9978), false, "MML" },
                    { new Guid("a25586d6-8245-424d-ba62-6951f1d1100b"), new DateTime(2021, 10, 12, 13, 29, 43, 177, DateTimeKind.Local).AddTicks(9423), false, "BASE" },
                    { new Guid("0d1790b3-b704-4ade-83f6-04d7fb627cd3"), new DateTime(2021, 10, 12, 13, 29, 43, 177, DateTimeKind.Local).AddTicks(9995), false, "AGCLM" }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("2fff3a91-196b-40b3-82b5-e75183e744f9"), "E", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(8049), "11E", 11, false },
                    { new Guid("c13d7b91-0c18-4ab6-97a6-b5a8a947dada"), "G", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(7223), "10G", 10, false },
                    { new Guid("907672ab-bc67-411f-9b3b-93f0373761c2"), "A", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(7933), "11A", 11, false },
                    { new Guid("8c1d3f2c-d6fc-4b8d-9751-f12f6474c1bf"), "B", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(7969), "11B", 11, false },
                    { new Guid("6bd3cb0a-b914-49b7-835a-485f6a34a0bf"), "C", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(7995), "11C", 11, false },
                    { new Guid("ee945959-d79d-42f2-b3d4-a6346d9aa78f"), "D", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(8022), "11D", 11, false },
                    { new Guid("92d17ecb-2b27-4351-b636-a93f3d96ef5c"), "F", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(8078), "11F", 11, false },
                    { new Guid("ed8dc3b0-68c3-44c0-b87b-01a1b2777cc0"), "F", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(8291), "12F", 12, false },
                    { new Guid("ae55753c-0bf9-4962-91f6-47127f86fa27"), "A", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(8162), "12A", 12, false },
                    { new Guid("7ebb500e-4c12-4719-ae34-16edb5d2e2c6"), "B", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(8186), "12B", 12, false },
                    { new Guid("a314113e-ab32-431d-b8c6-4390c7e5173f"), "C", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(8209), "12C", 12, false },
                    { new Guid("2864a931-0f53-458f-93f9-2ddbb1d82e4e"), "D", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(8238), "12D", 12, false },
                    { new Guid("60f8746c-eefa-476c-ba92-0c825b547931"), "E", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(8264), "12E", 12, false },
                    { new Guid("ebb7dce1-6bdf-4cb6-82a9-42e91915200c"), "F", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(7175), "10F", 10, false },
                    { new Guid("c204f59d-0de5-4bec-b132-1eefd2e72a15"), "G", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(8319), "12G", 12, false },
                    { new Guid("67235d9f-98f9-4f0e-b2ab-21e35b185cc9"), "G", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(8101), "11G", 11, false },
                    { new Guid("7cd13a8d-da16-4785-8426-cedb8d595e6b"), "E", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(7151), "10E", 10, false },
                    { new Guid("aded5ce9-a1c8-4df9-923d-03905c022c33"), "G", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(7032), "9G", 9, false },
                    { new Guid("93d4eb8e-9bf5-4e1c-ba96-5869c2f7e11c"), "C", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(7101), "10C", 10, false },
                    { new Guid("ab8b8cd8-7316-4d46-ba22-393f9cd651e2"), "A", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(6402), "8A", 8, false },
                    { new Guid("18b9391d-7a7b-409d-b906-47e9feb9eb57"), "B", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(6605), "8B", 8, false },
                    { new Guid("b3d167cf-0271-44ba-9d18-eda5c54ebbb3"), "C", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(6636), "8C", 8, false },
                    { new Guid("6ef26141-6f1f-41d2-8784-cb8b19f2be1c"), "D", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(6658), "8D", 8, false },
                    { new Guid("c45c7268-6a57-45aa-810d-5eb3b0fe04c1"), "E", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(6766), "8E", 8, false },
                    { new Guid("9f92bad8-49b6-4540-a570-62ce59154413"), "F", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(6799), "8F", 8, false },
                    { new Guid("b1c327ea-21da-4912-81d1-7cfd01b358e8"), "D", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(7127), "10D", 10, false },
                    { new Guid("60cfa115-78e9-4182-a73c-edfbf79e2633"), "A", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(6850), "9A", 9, false },
                    { new Guid("362bb274-1ad6-41a8-9320-3b53b5566694"), "G", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(6825), "8G", 8, false },
                    { new Guid("176fe53e-e0e5-4f10-9605-c11f7eed67c1"), "C", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(6905), "9C", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("fc53eb19-7494-424b-80f1-885ed99a0970"), "D", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(6932), "9D", 9, false },
                    { new Guid("c0ef0133-3e32-43eb-b027-8672bd29d66b"), "E", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(6959), "9E", 9, false },
                    { new Guid("94899af3-857c-4896-a6cb-69f6bfedf5ab"), "F", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(7008), "9F", 9, false },
                    { new Guid("85b2f77e-b70d-446b-9826-15a285405bae"), "A", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(7056), "10A", 10, false },
                    { new Guid("f9db02b4-1b13-4108-8287-0b85ec166846"), "B", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(7078), "10B", 10, false },
                    { new Guid("6019d5fa-0eed-441f-88c4-2ce0d2a70d5b"), "B", new DateTime(2021, 10, 12, 13, 29, 43, 143, DateTimeKind.Local).AddTicks(6877), "9B", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("019a4086-2082-449c-8af1-2b9f543f1c29"), new DateTime(2021, 10, 12, 13, 29, 43, 146, DateTimeKind.Local).AddTicks(4236), "G4", "G", 4, false },
                    { new Guid("f4fa618c-6604-444e-8b89-f5fb452e5e7e"), new DateTime(2021, 10, 12, 13, 29, 43, 146, DateTimeKind.Local).AddTicks(3955), "G1", "G", 1, false },
                    { new Guid("cf8c6403-5c2a-4271-a573-76e05b8f51b0"), new DateTime(2021, 10, 12, 13, 29, 43, 146, DateTimeKind.Local).AddTicks(4168), "G2", "G", 2, false },
                    { new Guid("7e8f7647-419d-4337-acf0-f3221eb8a62f"), new DateTime(2021, 10, 12, 13, 29, 43, 146, DateTimeKind.Local).AddTicks(4207), "G3", "G", 3, false },
                    { new Guid("df0d2a29-ced0-47b3-872c-96f0d81ff742"), new DateTime(2021, 10, 12, 13, 29, 43, 146, DateTimeKind.Local).AddTicks(4263), "G5", "G", 5, false }
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
                name: "IX_Audits_UserId",
                table: "Audits",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeModuleRoster_ModuleCodeId",
                table: "GradeModuleRoster",
                column: "ModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GenderId",
                table: "Students",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentClassId",
                table: "Students",
                column: "StudentClassId");

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
                name: "Audits");

            migrationBuilder.DropTable(
                name: "GradeModuleRoster");

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
                name: "ModuleCodes");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "StudentClasses");

            migrationBuilder.DropTable(
                name: "StudentGroups");
        }
    }
}
