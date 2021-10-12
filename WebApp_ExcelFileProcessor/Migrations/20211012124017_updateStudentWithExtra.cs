using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class updateStudentWithExtra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("abcb0f75-0631-4fe9-b1e1-8673b4d0a488"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("bb1c1655-a9eb-4f02-b052-68071aeef596"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("12295b16-3a6f-49e4-9da6-daea89031580"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("20bd8200-ca15-4ecd-ba9f-f1f99db9e3d6"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("4c93cfaf-5014-42d3-9b84-0310dae04fb2"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("65f37a7c-3a7e-4f16-a503-238342214f1f"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("7893d497-5df5-452c-a141-d9762ed9e54a"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("a724eb99-b210-4588-abbf-79c9c05c74ff"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("bb622047-14da-4ede-a60f-0e8dcc30487c"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("c7e03075-8bb7-4c9c-9bf9-0202101e400d"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("ddf06097-da1f-4d14-913a-d46debc82f8f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("0178daa8-444b-46f4-9fdf-b5155147347d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("01bae10d-b8c1-46a3-a288-5ced5fec6538"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("042d7452-fe40-4def-8771-c9032ecd4f85"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("10433110-4396-4d9a-b716-00bb24699691"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("250d1198-ed6a-4004-8fe1-af08244284c6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("27b262d0-b323-4819-9de7-753094038762"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("427d1b1a-ecd9-4d9b-aa48-ad6214ecf46c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("473d7fca-6310-4b8c-b649-a21a6a93e30e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("49da1bbe-8c24-4016-87ab-0ea4fcd1589e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4fdaf040-f3ac-45e6-9648-dc1fccf551fc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("503f7445-cb38-4dd9-ac50-9d19523f8572"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5206e546-6ed4-49e0-bbd8-7c1060369ad5"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("526fc815-293e-4396-b31e-234ee38e5db0"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("64edadd4-f6ea-4708-861c-a1a48be1feec"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6aa56b1f-636a-4540-a636-0b6ada2761be"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("723af282-e085-4e0d-aceb-bb31d2a6dbbe"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("73decb29-fb64-4cb5-b650-646658d679b6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7421c8a3-7785-4f6f-8499-7e995a435300"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("75e30f22-ae8a-4349-88ab-335560b42420"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("75f62bc3-f335-423b-8d16-c8a1639e0615"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("82ffe70b-b14b-4e52-9412-1330c05394c4"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9b9c7f3f-d1b5-41bc-9104-a44b0c5b3b7f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a174a676-6658-4ae3-a948-0991adcb4bb0"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a9242c73-183c-469d-ad54-968112facada"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b367c2b8-324a-4970-b1b1-a0ca6f3502b6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("bf26d63c-1c3c-4c49-a3d4-381b849aa284"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("cc44e400-90a9-40c3-916c-0a159d8b781d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d924b3c7-b3da-4df3-b527-4a5c1ff980e3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("dfc88e17-3cab-4fe4-bea0-dde19091c362"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e794ca6f-c75d-41ba-ad34-1ab36f6a9d7a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e8d96040-81b2-41b9-a122-006c25f77243"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f6f95b50-3fa8-4dd0-9475-416d4463a5de"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f804b2f7-770c-43da-b965-c435b920bd09"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f91af98b-6312-421a-9720-4cd0578e6ab3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fd507904-5e9e-446c-b783-ba79a94ab716"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("1044a153-9212-4bd3-a66f-c8e429a3cb53"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("3dfdd8ea-2f68-4cfa-ad5c-2c398a06b07f"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("4f370279-12da-4248-8922-a3db3c231f8a"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("7aedd19c-65bb-4379-82ae-f11a056f6bd8"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("fd8b7eaa-7cdd-43e6-b815-3d32a8fa8e33"));

            migrationBuilder.AddColumn<Guid>(
                name: "Extra1ModuleCodeId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Extra1SubjString",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Extra2ModuleCodeId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Extra2SubjString",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Extra3ModuleCodeId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Extra3SubjString",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FridayModuleCodeId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FridaySubjString",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MondayModuleCodeId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MondaySubjString",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ThursdayModuleCodeId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThursdaySubjString",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TuesdayModuleCodeId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TuesdaySubjString",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WednesdayModuleCodeId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WednesdaySubjString",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "3e92b254-12f4-44dc-ae07-5bcfea697427");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40a955fa-06f5-46ff-8129-cf360f6006f2", "AQAAAAEAACcQAAAAEM2FBDnHziQtpGx3WpifIimaR+NXgA8FcAjzp2mLDPiBFdyIc9Y34xxmJonz7sPfdA==", "a1edeaab-ca9a-451a-956e-f63dab69b3d9" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("9419f976-b406-4140-a67c-a0e291f5d3c2"), new DateTime(2021, 10, 12, 14, 40, 16, 562, DateTimeKind.Local).AddTicks(2915), "F", "Female", false },
                    { new Guid("10c2f63c-7708-4574-a036-623d5938efe8"), new DateTime(2021, 10, 12, 14, 40, 16, 563, DateTimeKind.Local).AddTicks(8965), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "ModuleCodes",
                columns: new[] { "ModuleCodeId", "DateCreated", "IsDeleted", "ModuleCodeName" },
                values: new object[,]
                {
                    { new Guid("905bec96-8915-4b75-b61b-2df918682439"), new DateTime(2021, 10, 12, 14, 40, 16, 586, DateTimeKind.Local).AddTicks(402), false, "MML" },
                    { new Guid("7d646813-e2b8-42f7-8195-b9decfcee6b7"), new DateTime(2021, 10, 12, 14, 40, 16, 586, DateTimeKind.Local).AddTicks(419), false, "LHC" },
                    { new Guid("7cae3435-4a0a-4d06-b580-1a822b5a627d"), new DateTime(2021, 10, 12, 14, 40, 16, 586, DateTimeKind.Local).AddTicks(425), false, "AGCLM" },
                    { new Guid("2038e304-d38d-48fc-9b5d-63080b883aad"), new DateTime(2021, 10, 12, 14, 40, 16, 586, DateTimeKind.Local).AddTicks(429), false, "ABCP" },
                    { new Guid("b6150676-5cba-4920-a091-9788e835300d"), new DateTime(2021, 10, 12, 14, 40, 16, 586, DateTimeKind.Local).AddTicks(433), false, "ENG" },
                    { new Guid("e5c6dd71-3d19-4ad5-b38b-aa31eb266746"), new DateTime(2021, 10, 12, 14, 40, 16, 586, DateTimeKind.Local).AddTicks(453), false, "AFR/XHO" },
                    { new Guid("172daea1-ee24-43f3-a246-7568dd2bec27"), new DateTime(2021, 10, 12, 14, 40, 16, 586, DateTimeKind.Local).AddTicks(457), false, "LO" },
                    { new Guid("170927b9-b687-4114-ad8b-88c28ad70823"), new DateTime(2021, 10, 12, 14, 40, 16, 586, DateTimeKind.Local).AddTicks(462), false, "EXAM" },
                    { new Guid("f3de7852-940b-40d0-9b4c-6a2a1c59e07a"), new DateTime(2021, 10, 12, 14, 40, 16, 585, DateTimeKind.Local).AddTicks(9813), false, "BASE" }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("f90686d8-b18f-479e-aa47-bf71cc302975"), "G", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2666), "10G", 10, false },
                    { new Guid("d029e38a-6a78-4596-8ca3-167e2c07c8ec"), "A", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2668), "11A", 11, false },
                    { new Guid("245b6882-ecc2-4b7a-8d30-c7bf20d50ec5"), "B", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2673), "11B", 11, false },
                    { new Guid("839218ac-8cef-477f-84de-ca9a3dbf5b10"), "C", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2675), "11C", 11, false },
                    { new Guid("f74e03bd-11f8-44ca-abb0-d3ba5f98ec2a"), "D", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2677), "11D", 11, false },
                    { new Guid("9c88e7b4-652b-4ab7-84ad-395bce0a8f26"), "E", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2680), "11E", 11, false },
                    { new Guid("2ec6a424-833f-4f0c-a165-059eda4fbaa2"), "C", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2693), "12C", 12, false },
                    { new Guid("8142ed26-97a0-4aab-a159-f4281cefeef9"), "G", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2684), "11G", 11, false },
                    { new Guid("b83570ad-a950-442c-a1c7-a29e396d994d"), "A", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2686), "12A", 12, false },
                    { new Guid("e6d8d9b7-f137-4703-b287-c656a6fbb9f2"), "B", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2688), "12B", 12, false },
                    { new Guid("4c30dd43-1ee1-4351-98e5-e1de2f4650c1"), "D", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2695), "12D", 12, false },
                    { new Guid("ca2e906e-a86c-4263-abfe-b0199e7dac66"), "E", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2697), "12E", 12, false },
                    { new Guid("1c56d388-6adb-4706-be12-350f2d5cef1e"), "F", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2699), "12F", 12, false },
                    { new Guid("132a786f-59ed-481a-b894-0c303f3513fe"), "G", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2701), "12G", 12, false },
                    { new Guid("a8cdec52-89ca-4870-95b0-978b45cfcaf9"), "F", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2682), "11F", 11, false },
                    { new Guid("0cf70d9c-0a7c-4327-ba47-0ddd31a8b1f8"), "F", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2664), "10F", 10, false },
                    { new Guid("ce9aea06-5726-4e27-8bfa-500cdcedc0cb"), "C", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2657), "10C", 10, false },
                    { new Guid("262e8fa1-7635-4720-9061-99577b940402"), "D", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2659), "10D", 10, false },
                    { new Guid("61690ab1-0eb0-40b4-ad08-d13121969679"), "A", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2577), "8A", 8, false },
                    { new Guid("f1fa680f-56fd-4bf2-9e15-621c4f88aa94"), "B", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2611), "8B", 8, false },
                    { new Guid("48680a2a-e656-47e7-89c2-a0ee9945a609"), "C", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2615), "8C", 8, false },
                    { new Guid("ad0380be-723b-4bc0-a433-5ab9910fd846"), "D", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2617), "8D", 8, false },
                    { new Guid("f547486d-e4de-4e6c-9098-fa0a3a4dfe02"), "E", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2661), "10E", 10, false },
                    { new Guid("098f4c2d-f7c1-4e49-9bd6-a4d7d788b93a"), "F", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2621), "8F", 8, false },
                    { new Guid("9fe14608-8661-4fe7-9828-d0c2c357fe82"), "G", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2633), "8G", 8, false },
                    { new Guid("8f774f0a-f8d6-4826-9275-90619c61f444"), "E", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2619), "8E", 8, false },
                    { new Guid("0b317356-d7e7-4b89-9a1d-e037dc70687c"), "B", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2637), "9B", 9, false },
                    { new Guid("efb3e9f9-f71a-440c-8ffe-d1a7cb9f2011"), "C", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2639), "9C", 9, false },
                    { new Guid("c758a601-efa2-4fb9-8850-1113ed04c012"), "D", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2641), "9D", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("06b0c827-6632-4085-b3f3-e874ee11d29c"), "E", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2643), "9E", 9, false },
                    { new Guid("a2b86ff0-2b14-4231-8aac-8193dc9e538b"), "F", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2645), "9F", 9, false },
                    { new Guid("86a8d298-a796-4cf2-9f95-5b117463f3fb"), "G", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2648), "9G", 9, false },
                    { new Guid("6da33d17-4cd0-428f-b108-8e297b68c357"), "A", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2652), "10A", 10, false },
                    { new Guid("447d1164-8b32-49a7-a370-f29436359b3d"), "A", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2635), "9A", 9, false },
                    { new Guid("e7d7a90d-3420-4408-bc51-fa6e847d482a"), "B", new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(2654), "10B", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("1e114edc-e597-48d7-8ce8-0a96728f64a5"), new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(4721), "G1", "G", 1, false },
                    { new Guid("0366175c-6929-49b7-b373-8237c40268a2"), new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(4737), "G2", "G", 2, false },
                    { new Guid("80c38876-25d9-429b-98dd-cd1bfc5aa488"), new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(4739), "G3", "G", 3, false },
                    { new Guid("5fec4d46-3396-4914-bb4c-bd293dac4d89"), new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(4747), "G4", "G", 4, false },
                    { new Guid("54525236-1d4a-4cb7-8366-55ce99b839a9"), new DateTime(2021, 10, 12, 14, 40, 16, 565, DateTimeKind.Local).AddTicks(4749), "G5", "G", 5, false }
                });

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
                name: "IX_Students_MondayModuleCodeId",
                table: "Students",
                column: "MondayModuleCodeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ModuleCodes_Extra1ModuleCodeId",
                table: "Students",
                column: "Extra1ModuleCodeId",
                principalTable: "ModuleCodes",
                principalColumn: "ModuleCodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ModuleCodes_Extra2ModuleCodeId",
                table: "Students",
                column: "Extra2ModuleCodeId",
                principalTable: "ModuleCodes",
                principalColumn: "ModuleCodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ModuleCodes_Extra3ModuleCodeId",
                table: "Students",
                column: "Extra3ModuleCodeId",
                principalTable: "ModuleCodes",
                principalColumn: "ModuleCodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ModuleCodes_FridayModuleCodeId",
                table: "Students",
                column: "FridayModuleCodeId",
                principalTable: "ModuleCodes",
                principalColumn: "ModuleCodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ModuleCodes_MondayModuleCodeId",
                table: "Students",
                column: "MondayModuleCodeId",
                principalTable: "ModuleCodes",
                principalColumn: "ModuleCodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ModuleCodes_ThursdayModuleCodeId",
                table: "Students",
                column: "ThursdayModuleCodeId",
                principalTable: "ModuleCodes",
                principalColumn: "ModuleCodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ModuleCodes_TuesdayModuleCodeId",
                table: "Students",
                column: "TuesdayModuleCodeId",
                principalTable: "ModuleCodes",
                principalColumn: "ModuleCodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ModuleCodes_WednesdayModuleCodeId",
                table: "Students",
                column: "WednesdayModuleCodeId",
                principalTable: "ModuleCodes",
                principalColumn: "ModuleCodeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_ModuleCodes_Extra1ModuleCodeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ModuleCodes_Extra2ModuleCodeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ModuleCodes_Extra3ModuleCodeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ModuleCodes_FridayModuleCodeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ModuleCodes_MondayModuleCodeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ModuleCodes_ThursdayModuleCodeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ModuleCodes_TuesdayModuleCodeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ModuleCodes_WednesdayModuleCodeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Extra1ModuleCodeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Extra2ModuleCodeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Extra3ModuleCodeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_FridayModuleCodeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_MondayModuleCodeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ThursdayModuleCodeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_TuesdayModuleCodeId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_WednesdayModuleCodeId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("10c2f63c-7708-4574-a036-623d5938efe8"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("9419f976-b406-4140-a67c-a0e291f5d3c2"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("170927b9-b687-4114-ad8b-88c28ad70823"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("172daea1-ee24-43f3-a246-7568dd2bec27"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("2038e304-d38d-48fc-9b5d-63080b883aad"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("7cae3435-4a0a-4d06-b580-1a822b5a627d"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("7d646813-e2b8-42f7-8195-b9decfcee6b7"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("905bec96-8915-4b75-b61b-2df918682439"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("b6150676-5cba-4920-a091-9788e835300d"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("e5c6dd71-3d19-4ad5-b38b-aa31eb266746"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("f3de7852-940b-40d0-9b4c-6a2a1c59e07a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("06b0c827-6632-4085-b3f3-e874ee11d29c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("098f4c2d-f7c1-4e49-9bd6-a4d7d788b93a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("0b317356-d7e7-4b89-9a1d-e037dc70687c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("0cf70d9c-0a7c-4327-ba47-0ddd31a8b1f8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("132a786f-59ed-481a-b894-0c303f3513fe"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1c56d388-6adb-4706-be12-350f2d5cef1e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("245b6882-ecc2-4b7a-8d30-c7bf20d50ec5"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("262e8fa1-7635-4720-9061-99577b940402"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2ec6a424-833f-4f0c-a165-059eda4fbaa2"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("447d1164-8b32-49a7-a370-f29436359b3d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("48680a2a-e656-47e7-89c2-a0ee9945a609"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4c30dd43-1ee1-4351-98e5-e1de2f4650c1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("61690ab1-0eb0-40b4-ad08-d13121969679"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6da33d17-4cd0-428f-b108-8e297b68c357"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8142ed26-97a0-4aab-a159-f4281cefeef9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("839218ac-8cef-477f-84de-ca9a3dbf5b10"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("86a8d298-a796-4cf2-9f95-5b117463f3fb"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8f774f0a-f8d6-4826-9275-90619c61f444"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9c88e7b4-652b-4ab7-84ad-395bce0a8f26"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9fe14608-8661-4fe7-9828-d0c2c357fe82"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a2b86ff0-2b14-4231-8aac-8193dc9e538b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a8cdec52-89ca-4870-95b0-978b45cfcaf9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ad0380be-723b-4bc0-a433-5ab9910fd846"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b83570ad-a950-442c-a1c7-a29e396d994d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("c758a601-efa2-4fb9-8850-1113ed04c012"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ca2e906e-a86c-4263-abfe-b0199e7dac66"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ce9aea06-5726-4e27-8bfa-500cdcedc0cb"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d029e38a-6a78-4596-8ca3-167e2c07c8ec"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e6d8d9b7-f137-4703-b287-c656a6fbb9f2"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e7d7a90d-3420-4408-bc51-fa6e847d482a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("efb3e9f9-f71a-440c-8ffe-d1a7cb9f2011"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f1fa680f-56fd-4bf2-9e15-621c4f88aa94"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f547486d-e4de-4e6c-9098-fa0a3a4dfe02"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f74e03bd-11f8-44ca-abb0-d3ba5f98ec2a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f90686d8-b18f-479e-aa47-bf71cc302975"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("0366175c-6929-49b7-b373-8237c40268a2"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("1e114edc-e597-48d7-8ce8-0a96728f64a5"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("54525236-1d4a-4cb7-8366-55ce99b839a9"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("5fec4d46-3396-4914-bb4c-bd293dac4d89"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("80c38876-25d9-429b-98dd-cd1bfc5aa488"));

            migrationBuilder.DropColumn(
                name: "Extra1ModuleCodeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Extra1SubjString",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Extra2ModuleCodeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Extra2SubjString",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Extra3ModuleCodeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Extra3SubjString",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FridayModuleCodeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FridaySubjString",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MondayModuleCodeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MondaySubjString",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ThursdayModuleCodeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ThursdaySubjString",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TuesdayModuleCodeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TuesdaySubjString",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "WednesdayModuleCodeId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "WednesdaySubjString",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "0f988470-439c-48d4-86af-6a3299bed211");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8513d410-6e25-4e69-b800-e78c51239fdb", "AQAAAAEAACcQAAAAEFUNvC4C4llf3PJHVGgVy0KcmPkOOYJZ1Ceihf1fcvM+L0bsILf7XBzdP/2+IhQHIA==", "a1be5c7c-077e-435c-8bf7-5e6f1db94be3" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("bb1c1655-a9eb-4f02-b052-68071aeef596"), new DateTime(2021, 10, 12, 13, 59, 55, 954, DateTimeKind.Local).AddTicks(2735), "F", "Female", false },
                    { new Guid("abcb0f75-0631-4fe9-b1e1-8673b4d0a488"), new DateTime(2021, 10, 12, 13, 59, 55, 955, DateTimeKind.Local).AddTicks(4398), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "ModuleCodes",
                columns: new[] { "ModuleCodeId", "DateCreated", "IsDeleted", "ModuleCodeName" },
                values: new object[,]
                {
                    { new Guid("7893d497-5df5-452c-a141-d9762ed9e54a"), new DateTime(2021, 10, 12, 13, 59, 55, 967, DateTimeKind.Local).AddTicks(5334), false, "MML" },
                    { new Guid("65f37a7c-3a7e-4f16-a503-238342214f1f"), new DateTime(2021, 10, 12, 13, 59, 55, 967, DateTimeKind.Local).AddTicks(5344), false, "LHC" },
                    { new Guid("20bd8200-ca15-4ecd-ba9f-f1f99db9e3d6"), new DateTime(2021, 10, 12, 13, 59, 55, 967, DateTimeKind.Local).AddTicks(5347), false, "AGCLM" },
                    { new Guid("bb622047-14da-4ede-a60f-0e8dcc30487c"), new DateTime(2021, 10, 12, 13, 59, 55, 967, DateTimeKind.Local).AddTicks(5349), false, "ABCP" },
                    { new Guid("12295b16-3a6f-49e4-9da6-daea89031580"), new DateTime(2021, 10, 12, 13, 59, 55, 967, DateTimeKind.Local).AddTicks(5351), false, "ENG" },
                    { new Guid("ddf06097-da1f-4d14-913a-d46debc82f8f"), new DateTime(2021, 10, 12, 13, 59, 55, 967, DateTimeKind.Local).AddTicks(5353), false, "AFR/XHO" },
                    { new Guid("c7e03075-8bb7-4c9c-9bf9-0202101e400d"), new DateTime(2021, 10, 12, 13, 59, 55, 967, DateTimeKind.Local).AddTicks(5355), false, "LO" },
                    { new Guid("a724eb99-b210-4588-abbf-79c9c05c74ff"), new DateTime(2021, 10, 12, 13, 59, 55, 967, DateTimeKind.Local).AddTicks(5361), false, "EXAM" },
                    { new Guid("4c93cfaf-5014-42d3-9b84-0310dae04fb2"), new DateTime(2021, 10, 12, 13, 59, 55, 967, DateTimeKind.Local).AddTicks(5013), false, "BASE" }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("dfc88e17-3cab-4fe4-bea0-dde19091c362"), "G", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4524), "10G", 10, false },
                    { new Guid("526fc815-293e-4396-b31e-234ee38e5db0"), "A", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4525), "11A", 11, false },
                    { new Guid("723af282-e085-4e0d-aceb-bb31d2a6dbbe"), "B", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4529), "11B", 11, false },
                    { new Guid("e794ca6f-c75d-41ba-ad34-1ab36f6a9d7a"), "C", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4531), "11C", 11, false },
                    { new Guid("cc44e400-90a9-40c3-916c-0a159d8b781d"), "D", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4533), "11D", 11, false },
                    { new Guid("d924b3c7-b3da-4df3-b527-4a5c1ff980e3"), "E", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4534), "11E", 11, false },
                    { new Guid("473d7fca-6310-4b8c-b649-a21a6a93e30e"), "C", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4545), "12C", 12, false },
                    { new Guid("bf26d63c-1c3c-4c49-a3d4-381b849aa284"), "G", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4538), "11G", 11, false },
                    { new Guid("503f7445-cb38-4dd9-ac50-9d19523f8572"), "A", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4540), "12A", 12, false },
                    { new Guid("a174a676-6658-4ae3-a948-0991adcb4bb0"), "B", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4541), "12B", 12, false },
                    { new Guid("7421c8a3-7785-4f6f-8499-7e995a435300"), "D", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4547), "12D", 12, false },
                    { new Guid("49da1bbe-8c24-4016-87ab-0ea4fcd1589e"), "E", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4549), "12E", 12, false },
                    { new Guid("5206e546-6ed4-49e0-bbd8-7c1060369ad5"), "F", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4551), "12F", 12, false },
                    { new Guid("75e30f22-ae8a-4349-88ab-335560b42420"), "G", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4553), "12G", 12, false },
                    { new Guid("b367c2b8-324a-4970-b1b1-a0ca6f3502b6"), "F", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4536), "11F", 11, false },
                    { new Guid("fd507904-5e9e-446c-b783-ba79a94ab716"), "F", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4522), "10F", 10, false },
                    { new Guid("75f62bc3-f335-423b-8d16-c8a1639e0615"), "C", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4516), "10C", 10, false },
                    { new Guid("f6f95b50-3fa8-4dd0-9475-416d4463a5de"), "D", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4518), "10D", 10, false },
                    { new Guid("6aa56b1f-636a-4540-a636-0b6ada2761be"), "A", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4459), "8A", 8, false },
                    { new Guid("64edadd4-f6ea-4708-861c-a1a48be1feec"), "B", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4476), "8B", 8, false },
                    { new Guid("e8d96040-81b2-41b9-a122-006c25f77243"), "C", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4478), "8C", 8, false },
                    { new Guid("4fdaf040-f3ac-45e6-9648-dc1fccf551fc"), "D", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4480), "8D", 8, false },
                    { new Guid("9b9c7f3f-d1b5-41bc-9104-a44b0c5b3b7f"), "E", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4520), "10E", 10, false },
                    { new Guid("250d1198-ed6a-4004-8fe1-af08244284c6"), "F", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4484), "8F", 8, false },
                    { new Guid("73decb29-fb64-4cb5-b650-646658d679b6"), "G", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4495), "8G", 8, false },
                    { new Guid("042d7452-fe40-4def-8771-c9032ecd4f85"), "E", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4482), "8E", 8, false },
                    { new Guid("82ffe70b-b14b-4e52-9412-1330c05394c4"), "B", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4499), "9B", 9, false },
                    { new Guid("10433110-4396-4d9a-b716-00bb24699691"), "C", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4501), "9C", 9, false },
                    { new Guid("f804b2f7-770c-43da-b965-c435b920bd09"), "D", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4503), "9D", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("a9242c73-183c-469d-ad54-968112facada"), "E", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4505), "9E", 9, false },
                    { new Guid("427d1b1a-ecd9-4d9b-aa48-ad6214ecf46c"), "F", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4506), "9F", 9, false },
                    { new Guid("27b262d0-b323-4819-9de7-753094038762"), "G", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4508), "9G", 9, false },
                    { new Guid("f91af98b-6312-421a-9720-4cd0578e6ab3"), "A", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4512), "10A", 10, false },
                    { new Guid("01bae10d-b8c1-46a3-a288-5ced5fec6538"), "A", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4497), "9A", 9, false },
                    { new Guid("0178daa8-444b-46f4-9fdf-b5155147347d"), "B", new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(4514), "10B", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("7aedd19c-65bb-4379-82ae-f11a056f6bd8"), new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(5948), "G1", "G", 1, false },
                    { new Guid("4f370279-12da-4248-8922-a3db3c231f8a"), new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(5959), "G2", "G", 2, false },
                    { new Guid("fd8b7eaa-7cdd-43e6-b815-3d32a8fa8e33"), new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(5961), "G3", "G", 3, false },
                    { new Guid("1044a153-9212-4bd3-a66f-c8e429a3cb53"), new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(5967), "G4", "G", 4, false },
                    { new Guid("3dfdd8ea-2f68-4cfa-ad5c-2c398a06b07f"), new DateTime(2021, 10, 12, 13, 59, 55, 956, DateTimeKind.Local).AddTicks(5969), "G5", "G", 5, false }
                });
        }
    }
}
