using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class newDatabaseNoSeeder : Migration
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
                name: "ExcelDownload",
                columns: table => new
                {
                    ExcelDownloadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileByteArray = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelDownload", x => x.ExcelDownloadId);
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
                    MondayModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MondaySubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TuesdayModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TuesdaySubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WednesdayModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WednesdaySubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThursdayModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ThursdaySubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FridayModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FridaySubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extra1ModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Extra1SubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extra2ModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Extra2SubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extra3ModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Extra3SubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        name: "FK_Students_ModuleCodes_Extra1ModuleCodeId",
                        column: x => x.Extra1ModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_ModuleCodes_Extra2ModuleCodeId",
                        column: x => x.Extra2ModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_ModuleCodes_Extra3ModuleCodeId",
                        column: x => x.Extra3ModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_ModuleCodes_FridayModuleCodeId",
                        column: x => x.FridayModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_ModuleCodes_MondayModuleCodeId",
                        column: x => x.MondayModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_ModuleCodes_ThursdayModuleCodeId",
                        column: x => x.ThursdayModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_ModuleCodes_TuesdayModuleCodeId",
                        column: x => x.TuesdayModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_ModuleCodes_WednesdayModuleCodeId",
                        column: x => x.WednesdayModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
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
                    GradeString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentNr = table.Column<int>(type: "int", nullable: true),
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MondayModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MondaySubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TuesdayModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TuesdaySubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WednesdayModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WednesdaySubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThursdayModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ThursdaySubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FridayModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FridaySubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extra1ModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Extra1SubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extra2ModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Extra2SubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extra3ModuleCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Extra3SubjString = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        name: "FK_StudentTemps_ModuleCodes_Extra1ModuleCodeId",
                        column: x => x.Extra1ModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentTemps_ModuleCodes_Extra2ModuleCodeId",
                        column: x => x.Extra2ModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentTemps_ModuleCodes_Extra3ModuleCodeId",
                        column: x => x.Extra3ModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentTemps_ModuleCodes_FridayModuleCodeId",
                        column: x => x.FridayModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentTemps_ModuleCodes_MondayModuleCodeId",
                        column: x => x.MondayModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentTemps_ModuleCodes_ThursdayModuleCodeId",
                        column: x => x.ThursdayModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentTemps_ModuleCodes_TuesdayModuleCodeId",
                        column: x => x.TuesdayModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentTemps_ModuleCodes_WednesdayModuleCodeId",
                        column: x => x.WednesdayModuleCodeId,
                        principalTable: "ModuleCodes",
                        principalColumn: "ModuleCodeId",
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
                name: "IX_Students_Extra1ModuleCodeId",
                table: "Students",
                column: "Extra1ModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Extra2ModuleCodeId",
                table: "Students",
                column: "Extra2ModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Extra3ModuleCodeId",
                table: "Students",
                column: "Extra3ModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FridayModuleCodeId",
                table: "Students",
                column: "FridayModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GenderId",
                table: "Students",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_MondayModuleCodeId",
                table: "Students",
                column: "MondayModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentClassId",
                table: "Students",
                column: "StudentClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentGroupId",
                table: "Students",
                column: "StudentGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ThursdayModuleCodeId",
                table: "Students",
                column: "ThursdayModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TuesdayModuleCodeId",
                table: "Students",
                column: "TuesdayModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_WednesdayModuleCodeId",
                table: "Students",
                column: "WednesdayModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentScreening_StudentId",
                table: "StudentScreening",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentScreeningTemps_StudentId",
                table: "StudentScreeningTemps",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_Extra1ModuleCodeId",
                table: "StudentTemps",
                column: "Extra1ModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_Extra2ModuleCodeId",
                table: "StudentTemps",
                column: "Extra2ModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_Extra3ModuleCodeId",
                table: "StudentTemps",
                column: "Extra3ModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_FridayModuleCodeId",
                table: "StudentTemps",
                column: "FridayModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_GenderId",
                table: "StudentTemps",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_MondayModuleCodeId",
                table: "StudentTemps",
                column: "MondayModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_StudentClassId",
                table: "StudentTemps",
                column: "StudentClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_StudentGroupId",
                table: "StudentTemps",
                column: "StudentGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_ThursdayModuleCodeId",
                table: "StudentTemps",
                column: "ThursdayModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_TuesdayModuleCodeId",
                table: "StudentTemps",
                column: "TuesdayModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_WednesdayModuleCodeId",
                table: "StudentTemps",
                column: "WednesdayModuleCodeId");
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
                name: "ExcelDownload");

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
                name: "Students");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "ModuleCodes");

            migrationBuilder.DropTable(
                name: "StudentClasses");

            migrationBuilder.DropTable(
                name: "StudentGroups");
        }
    }
}
