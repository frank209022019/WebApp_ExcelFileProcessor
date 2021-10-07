using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class databaseInit : Migration
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
                name: "Audits",
                columns: table => new
                {
                    AuditLogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColumnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audits", x => x.AuditLogId);
                    table.ForeignKey(
                        name: "FK_Audits_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                values: new object[] { "ba566e0f-3d52-4967-a62c-1965b9f1e251", "47fbf4e9-5b23-41ee-8181-f4fbdc44c9e0", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1b824f5d-01b1-411b-8e44-5b05003ef81e", 0, "cfee6c86-be39-45c2-9d43-c49a8541bbc9", "admin@fileprocessor.co.za", true, false, null, "ADMIN@FILEPROCESSOR.CO.ZA", "MYUSER", "AQAAAAEAACcQAAAAEKC50B723lmqm4r6CLYt4TbhChZb8i84CA1I8Oj6Ty68YONqitevU1vcDb4mdafFDg==", "0413743172", true, "f4664248-19de-4834-8f6c-5fc58f9e3495", false, "myuser" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("85a2e699-3e34-486d-9edc-746d291940d2"), new DateTime(2021, 10, 7, 8, 48, 51, 518, DateTimeKind.Local).AddTicks(6776), "F", "Female", false },
                    { new Guid("82722b81-31c2-4399-9aeb-3d2fff2bb3ff"), new DateTime(2021, 10, 7, 8, 48, 51, 519, DateTimeKind.Local).AddTicks(8602), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("19336177-91e7-41d2-90d3-074e3d0cecd1"), "G", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6222), "10G", 10, false },
                    { new Guid("9f2d1044-eea1-4608-8e8f-c6f8c82eac57"), "A", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6225), "11A", 11, false },
                    { new Guid("8bbd47c0-12f7-4664-9be8-f37670016583"), "B", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6227), "11B", 11, false },
                    { new Guid("fd0b21fd-5f1f-461d-bf61-570f3b0005fa"), "C", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6230), "11C", 11, false },
                    { new Guid("fd36ae90-739c-47f8-9522-2fc358522d10"), "D", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6232), "11D", 11, false },
                    { new Guid("9e6d2eb5-426f-487f-9928-ab5766e387fa"), "E", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6235), "11E", 11, false },
                    { new Guid("4bf20a81-ccf9-4348-8e49-c19ac86c309f"), "F", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6240), "11F", 11, false },
                    { new Guid("74bc138f-fd4d-45b2-aecb-5ad3482337a8"), "A", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6246), "12A", 12, false },
                    { new Guid("3782b536-8974-4601-a717-43c507b0b920"), "E", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6217), "10E", 10, false },
                    { new Guid("add58ffd-df3f-4242-93f1-a6b9a1a40fd9"), "B", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6249), "12B", 12, false },
                    { new Guid("7e634387-1f46-457b-a6ba-621a197fffae"), "C", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6251), "12C", 12, false },
                    { new Guid("43d9ea66-98a7-4a43-af8e-35b7829fa79f"), "D", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6254), "12D", 12, false },
                    { new Guid("6170a01d-4a90-41d1-96bd-845c79b636c3"), "E", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6256), "12E", 12, false },
                    { new Guid("83c3e60d-950c-406b-9716-83b53ad504b1"), "F", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6259), "12F", 12, false },
                    { new Guid("1be368a0-7df4-49d0-b579-b59b0bcb40ad"), "G", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6264), "12G", 12, false },
                    { new Guid("cdb7cb95-6de7-4188-b7eb-d4628642af55"), "G", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6243), "11G", 11, false },
                    { new Guid("c8b16da7-2964-46f2-ac50-e6e8a5e78b20"), "D", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6212), "10D", 10, false },
                    { new Guid("a7764eb5-6c4d-4156-b456-78c1b56eac29"), "F", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6220), "10F", 10, false },
                    { new Guid("782aa0f9-21d4-4b08-a8fa-85f1de89289d"), "B", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6206), "10B", 10, false },
                    { new Guid("5905826a-96bb-4575-baf6-cdf94e75b42d"), "A", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6044), "8A", 8, false },
                    { new Guid("41299f0f-2420-4ce1-b919-bf743fe7fd41"), "B", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6068), "8B", 8, false },
                    { new Guid("af91420c-0baa-4985-86f3-fe07ca7944e0"), "C", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6085), "8C", 8, false },
                    { new Guid("dfee429b-c198-40af-a848-87f7378b7c49"), "D", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6089), "8D", 8, false },
                    { new Guid("a888ed77-dc85-4350-9388-c972777ae814"), "C", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6208), "10C", 10, false },
                    { new Guid("b95e720a-8319-4645-92a2-6dc634f74c00"), "F", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6096), "8F", 8, false },
                    { new Guid("780a83c8-9f7a-495f-809e-1a2f8b62ca9d"), "G", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6099), "8G", 8, false },
                    { new Guid("debbdd1e-b355-4e59-b8f0-f7c297c30315"), "A", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6102), "9A", 9, false },
                    { new Guid("b13fbac4-0094-46a7-8297-fe3e510f81d1"), "E", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6092), "8E", 8, false },
                    { new Guid("16d71a8b-1083-4c32-82ff-2e00945dc540"), "C", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6182), "9C", 9, false },
                    { new Guid("c3d1ced6-060f-4de0-9931-643bc4c59bcc"), "D", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6192), "9D", 9, false },
                    { new Guid("f43696e2-bb4e-4993-a690-53dbbd286fe5"), "E", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6195), "9E", 9, false },
                    { new Guid("e797177b-a13d-420f-ba14-ec1de4f9b62c"), "F", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6197), "9F", 9, false },
                    { new Guid("b23e47b2-ecc3-4859-ad29-c3746ea4e9f7"), "G", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6200), "9G", 9, false },
                    { new Guid("85f99ee9-d1bf-4dd2-84ae-e4c1ed0d30db"), "A", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6203), "10A", 10, false },
                    { new Guid("f67c0a73-ba5b-4cf8-b462-f58e7bf7edf4"), "B", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(6177), "9B", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("b72f6191-9fe4-4853-bbed-0e7d1f5263dd"), "Gold", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(3486), false },
                    { new Guid("8c10abee-f732-45cc-84dc-bba03243f23e"), "Scarlet", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(3515), false },
                    { new Guid("f5ec8f2d-b160-4170-8508-ba3b10d30e04"), "Unassigned", new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(3518), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("bab8f0f0-2322-4f8b-91dc-d70d44957d9a"), new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(8213), "G4", "G", 4, false },
                    { new Guid("142e559a-188f-421b-9fec-aa0ec5b129c9"), new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(8193), "G1", "G", 1, false },
                    { new Guid("31bc931f-42dd-4ce4-99d0-86eec0d3e6ff"), new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(8207), "G2", "G", 2, false },
                    { new Guid("db60edee-1756-459a-8588-7a200ce1bcd6"), new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(8210), "G3", "G", 3, false },
                    { new Guid("2eb86bd5-9f1c-474f-8559-d21de0e7311e"), new DateTime(2021, 10, 7, 8, 48, 51, 521, DateTimeKind.Local).AddTicks(8215), "G5", "G", 5, false }
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
                name: "Audits");

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
