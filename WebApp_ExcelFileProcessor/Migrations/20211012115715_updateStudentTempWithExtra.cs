using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class updateStudentTempWithExtra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentTemps_ModuleCodes_ExtraModuleCodeId",
                table: "StudentTemps");

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("44da986c-d23d-4cbf-a301-336e61b31756"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("7f0c3d06-5995-4053-8917-8666be92442b"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("14b97ee8-e48f-4984-a513-836df6d5f051"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("a4ce1b9d-8001-481a-87db-e94afd350138"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("bbe2fe92-d583-481a-af5d-adca0af227b6"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("c2764484-62d6-43da-81a4-f5bbdd716976"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("d5543731-5117-444c-bd08-5330283e960a"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("dd7ba8d3-c392-43f6-98d9-36ce7d38e12e"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("e0a57603-e00a-433e-a8dd-505dc29203d1"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("e9cd8012-f84c-4dc5-87a7-b15dc091ea31"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("f9d9db71-6f0b-4bb8-a212-b7d1925184a3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("09f148cd-b69f-4607-9271-3205b9b01d9d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1abffeb5-ce73-4dbe-adb5-6262b2712009"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1ba7f645-ecdb-445b-968e-c1ae09bdb4ad"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1d0ac70a-2c1f-4adc-903c-cb6251f75971"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("20fc4941-8b96-4222-a2d9-97c9bd8ce147"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2741cd2d-8160-4f74-98cc-3c211ce9d337"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("38eac2c3-f0fa-4c0f-84c7-7293fcc28537"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3c171cfc-6dbb-4c06-8ce6-e49d645d835b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("43cae22e-2db1-48ae-8cac-edc49356937f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4a2a2e1f-3406-4cf2-91de-54cb82ad41c8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("50e08172-6d74-4508-9069-304e5593a9b3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6161703e-691f-4120-8281-93d78ef542fe"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6366bc18-ffb4-4828-901c-1de5181082fc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6ffc9962-2e4c-44c0-9b88-ce552a292203"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("772523ec-aaca-4d97-8c33-3bac0a5ce1bc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7d59a70b-4f55-472a-a373-7020e95e8926"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8a6ec17d-c19f-4ecf-804a-6668bc26502f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8af8bcec-e274-4325-bc6c-4cef7bfd1f21"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8eb7a132-29db-461f-aaaa-c80d1b59b2aa"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9448ae89-7d14-4c40-986e-ff47e8ead889"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("958604ab-e227-4e56-b8b9-011b0694b335"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9c2e46b8-c092-477d-b00f-93b7cb7af0e2"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9ccb9997-fcee-4509-bce2-bb922c24a880"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a0fa6747-3954-4fa2-b8c8-f71afd50732a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a22f307a-4411-45bb-b915-2ab8ca5edc4e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a53bddd6-dcde-4fe7-8256-a3a968359a85"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b22a3853-20f7-4421-8da3-fc60c4a8a659"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b86479d2-021e-48ec-bf77-1c3b107e7dae"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("bde6041a-de3d-4c5c-9f68-5977ccd1ec89"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("bf05d880-f7ae-4890-8bf4-e3515cb6d62a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("c8f1649b-4026-4e5f-a817-193701e9d95a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("db0340a8-4b0c-4181-85a1-493b299954be"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("dd48bae3-3770-421b-b6f5-ab0c0b109769"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("eb62cec8-52f3-4373-9fd4-ebabb3ab89e9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fa5dff23-e28a-4a27-b28e-2b8ff568b89c"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("51675d60-e9a4-4e89-a8f1-918cd7e48edc"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("76356861-1caa-4fdd-af4f-d7b8b3ef2c36"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("9cac2d72-d7f9-401b-b7db-6597ee2f26fc"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("d26fb98f-f6e7-44a6-ac1b-a28823b1a363"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("d621dc5d-ab8c-46e5-b434-0d556c291c28"));

            migrationBuilder.RenameColumn(
                name: "ExtraSubjString",
                table: "StudentTemps",
                newName: "Extra3SubjString");

            migrationBuilder.RenameColumn(
                name: "ExtraModuleCodeId",
                table: "StudentTemps",
                newName: "Extra3ModuleCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTemps_ExtraModuleCodeId",
                table: "StudentTemps",
                newName: "IX_StudentTemps_Extra3ModuleCodeId");

            migrationBuilder.AddColumn<Guid>(
                name: "Extra1ModuleCodeId",
                table: "StudentTemps",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Extra1SubjString",
                table: "StudentTemps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Extra2ModuleCodeId",
                table: "StudentTemps",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Extra2SubjString",
                table: "StudentTemps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "0e37993d-0371-40c2-852c-14ddea529395");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9e6d806-e498-40a2-bfb9-893cee53159f", "AQAAAAEAACcQAAAAELqlyFh/Dgd13yNUbltFRTCtzr1R3+EY7MtPxBSI+MonqpLRHAcmXJzNhNPNJdHgjw==", "c6dc97fe-cd1e-4b6f-a5c6-7ef0f17f5a71" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("19d4115d-967d-4616-a27c-cc2cc9b7bcc6"), new DateTime(2021, 10, 12, 13, 57, 14, 49, DateTimeKind.Local).AddTicks(7127), "F", "Female", false },
                    { new Guid("8cd7c6e3-862f-4e46-9da3-128f469e7716"), new DateTime(2021, 10, 12, 13, 57, 14, 50, DateTimeKind.Local).AddTicks(5918), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "ModuleCodes",
                columns: new[] { "ModuleCodeId", "DateCreated", "IsDeleted", "ModuleCodeName" },
                values: new object[,]
                {
                    { new Guid("0f64388f-6f7c-4ba9-9687-5025246eb24d"), new DateTime(2021, 10, 12, 13, 57, 14, 63, DateTimeKind.Local).AddTicks(2870), false, "MML" },
                    { new Guid("8b916611-fee0-4794-be3d-8d4d66a36994"), new DateTime(2021, 10, 12, 13, 57, 14, 63, DateTimeKind.Local).AddTicks(2879), false, "LHC" },
                    { new Guid("ee9fe3d7-50c9-4ce4-ab69-9d5d6bf8fc28"), new DateTime(2021, 10, 12, 13, 57, 14, 63, DateTimeKind.Local).AddTicks(2882), false, "AGCLM" },
                    { new Guid("0ca79e5d-8bec-4132-b373-99c330eadc41"), new DateTime(2021, 10, 12, 13, 57, 14, 63, DateTimeKind.Local).AddTicks(2884), false, "ABCP" },
                    { new Guid("b36f399d-8495-4a4e-926a-50a996aac7c3"), new DateTime(2021, 10, 12, 13, 57, 14, 63, DateTimeKind.Local).AddTicks(2887), false, "ENG" },
                    { new Guid("c1963027-8fb8-4db8-92fd-3b2b131db80e"), new DateTime(2021, 10, 12, 13, 57, 14, 63, DateTimeKind.Local).AddTicks(2889), false, "AFR/XHO" },
                    { new Guid("b1b6e464-0c6e-4c36-bc1d-2c1ee82c3d43"), new DateTime(2021, 10, 12, 13, 57, 14, 63, DateTimeKind.Local).AddTicks(2891), false, "LO" },
                    { new Guid("8ab298a0-0104-4c96-bf76-354cfabea28d"), new DateTime(2021, 10, 12, 13, 57, 14, 63, DateTimeKind.Local).AddTicks(2898), false, "EXAM" },
                    { new Guid("ffba507c-cba0-4350-971c-ad6667547f65"), new DateTime(2021, 10, 12, 13, 57, 14, 63, DateTimeKind.Local).AddTicks(2556), false, "BASE" }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("542b643d-1b44-469e-927c-621eee326cfe"), "G", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5753), "10G", 10, false },
                    { new Guid("ef950c54-8677-47b9-991e-5094513e8844"), "A", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5754), "11A", 11, false },
                    { new Guid("20796fb1-9320-42a0-8462-c0130674080f"), "B", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5758), "11B", 11, false },
                    { new Guid("39c4f5d9-e513-4caf-bf60-bd60990f7831"), "C", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5760), "11C", 11, false },
                    { new Guid("58703de0-798c-40e0-8d5a-df89ccf4a532"), "D", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5762), "11D", 11, false },
                    { new Guid("cc8b2c2a-39fc-4ec3-9c35-79a463c29418"), "E", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5763), "11E", 11, false },
                    { new Guid("00c14263-a0b7-49dd-afca-bd0cd62520bf"), "C", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5774), "12C", 12, false },
                    { new Guid("b81ac0b5-71f7-4c7c-aa7a-768df334c87b"), "G", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5767), "11G", 11, false },
                    { new Guid("7fe0acfa-6c71-48a7-9035-41d2779f4bc8"), "A", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5768), "12A", 12, false },
                    { new Guid("af693b88-c136-43b2-8450-81ef1d1a8572"), "B", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5771), "12B", 12, false },
                    { new Guid("42452140-72d8-4f39-bb14-e6cb746a974f"), "D", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5776), "12D", 12, false },
                    { new Guid("82d5f97a-84e2-4bee-96bf-52af5f58787b"), "E", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5778), "12E", 12, false },
                    { new Guid("ac122c8f-45b0-45d5-bf59-ee16bf673619"), "F", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5780), "12F", 12, false },
                    { new Guid("6f6de646-e5c4-4470-ade5-10554fa0961f"), "G", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5781), "12G", 12, false },
                    { new Guid("3c333f83-35f3-49ea-8262-55958886700e"), "F", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5765), "11F", 11, false },
                    { new Guid("9cbc51b6-8a44-4480-98cc-6f1149c4e17f"), "F", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5751), "10F", 10, false },
                    { new Guid("2540d53e-d649-4f01-9797-1d3969b0928a"), "C", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5746), "10C", 10, false },
                    { new Guid("3afa7b4d-490b-4e3a-a5ae-f593e548b264"), "D", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5748), "10D", 10, false },
                    { new Guid("b81eddf1-c9b5-497a-a976-6a12ac48441d"), "A", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5626), "8A", 8, false },
                    { new Guid("6467e1cd-831c-4f4f-b9f7-12a2117f6b5e"), "B", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5641), "8B", 8, false },
                    { new Guid("51d5b8b1-55ab-4773-84e6-bc45706e6c61"), "C", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5644), "8C", 8, false },
                    { new Guid("42a8cd0d-5745-45d7-a526-985712da6e80"), "D", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5712), "8D", 8, false },
                    { new Guid("8afc5d1b-bcad-4689-be60-65e62cc9ae01"), "E", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5749), "10E", 10, false },
                    { new Guid("1c8176c2-410f-44f2-8f89-f7d621d12a2b"), "F", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5715), "8F", 8, false },
                    { new Guid("ce795186-175b-4ebe-9f89-548ededa14a5"), "G", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5725), "8G", 8, false },
                    { new Guid("7cdd63b2-2139-421c-b050-39b471718c5e"), "E", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5714), "8E", 8, false },
                    { new Guid("da3fbe47-cfef-448f-b064-42b68a6071ee"), "B", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5729), "9B", 9, false },
                    { new Guid("d6106664-bea5-424f-bf59-e1f5ed7376cc"), "C", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5730), "9C", 9, false },
                    { new Guid("19e2c990-4bf1-4086-9c90-7b2111daf36d"), "D", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5732), "9D", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("c87359ec-8717-4790-adda-553b5facccc7"), "E", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5734), "9E", 9, false },
                    { new Guid("79f1087b-4fad-442c-a26c-badd487921b0"), "F", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5736), "9F", 9, false },
                    { new Guid("d40fe25c-68c9-4cee-8f47-7d253c046e79"), "G", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5739), "9G", 9, false },
                    { new Guid("8cc6166d-4637-4191-ae49-9c3c65872a56"), "A", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5742), "10A", 10, false },
                    { new Guid("5da24ae3-6c7b-43a5-8031-5d4dba293904"), "A", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5727), "9A", 9, false },
                    { new Guid("98ebeb99-9c2a-45ed-ac11-9c9ed3951574"), "B", new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(5744), "10B", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("e5a20d26-91fa-4691-aaab-e55c3e8efa1f"), new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(7156), "G1", "G", 1, false },
                    { new Guid("bbfc21ad-e3e1-4920-a62e-43e8081c0111"), new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(7166), "G2", "G", 2, false },
                    { new Guid("05978733-128a-4ad1-84d0-a9255225f4e6"), new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(7168), "G3", "G", 3, false },
                    { new Guid("83927c25-29b3-4b04-9bac-f04fe9676e66"), new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(7174), "G4", "G", 4, false },
                    { new Guid("afc4441f-be5f-4394-b5f6-fb6eb63cc765"), new DateTime(2021, 10, 12, 13, 57, 14, 51, DateTimeKind.Local).AddTicks(7175), "G5", "G", 5, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_Extra1ModuleCodeId",
                table: "StudentTemps",
                column: "Extra1ModuleCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTemps_Extra2ModuleCodeId",
                table: "StudentTemps",
                column: "Extra2ModuleCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTemps_ModuleCodes_Extra1ModuleCodeId",
                table: "StudentTemps",
                column: "Extra1ModuleCodeId",
                principalTable: "ModuleCodes",
                principalColumn: "ModuleCodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTemps_ModuleCodes_Extra2ModuleCodeId",
                table: "StudentTemps",
                column: "Extra2ModuleCodeId",
                principalTable: "ModuleCodes",
                principalColumn: "ModuleCodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTemps_ModuleCodes_Extra3ModuleCodeId",
                table: "StudentTemps",
                column: "Extra3ModuleCodeId",
                principalTable: "ModuleCodes",
                principalColumn: "ModuleCodeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentTemps_ModuleCodes_Extra1ModuleCodeId",
                table: "StudentTemps");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTemps_ModuleCodes_Extra2ModuleCodeId",
                table: "StudentTemps");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTemps_ModuleCodes_Extra3ModuleCodeId",
                table: "StudentTemps");

            migrationBuilder.DropIndex(
                name: "IX_StudentTemps_Extra1ModuleCodeId",
                table: "StudentTemps");

            migrationBuilder.DropIndex(
                name: "IX_StudentTemps_Extra2ModuleCodeId",
                table: "StudentTemps");

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("19d4115d-967d-4616-a27c-cc2cc9b7bcc6"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("8cd7c6e3-862f-4e46-9da3-128f469e7716"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("0ca79e5d-8bec-4132-b373-99c330eadc41"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("0f64388f-6f7c-4ba9-9687-5025246eb24d"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("8ab298a0-0104-4c96-bf76-354cfabea28d"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("8b916611-fee0-4794-be3d-8d4d66a36994"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("b1b6e464-0c6e-4c36-bc1d-2c1ee82c3d43"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("b36f399d-8495-4a4e-926a-50a996aac7c3"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("c1963027-8fb8-4db8-92fd-3b2b131db80e"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("ee9fe3d7-50c9-4ce4-ab69-9d5d6bf8fc28"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("ffba507c-cba0-4350-971c-ad6667547f65"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("00c14263-a0b7-49dd-afca-bd0cd62520bf"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("19e2c990-4bf1-4086-9c90-7b2111daf36d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1c8176c2-410f-44f2-8f89-f7d621d12a2b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("20796fb1-9320-42a0-8462-c0130674080f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2540d53e-d649-4f01-9797-1d3969b0928a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("39c4f5d9-e513-4caf-bf60-bd60990f7831"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3afa7b4d-490b-4e3a-a5ae-f593e548b264"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3c333f83-35f3-49ea-8262-55958886700e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("42452140-72d8-4f39-bb14-e6cb746a974f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("42a8cd0d-5745-45d7-a526-985712da6e80"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("51d5b8b1-55ab-4773-84e6-bc45706e6c61"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("542b643d-1b44-469e-927c-621eee326cfe"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("58703de0-798c-40e0-8d5a-df89ccf4a532"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5da24ae3-6c7b-43a5-8031-5d4dba293904"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6467e1cd-831c-4f4f-b9f7-12a2117f6b5e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6f6de646-e5c4-4470-ade5-10554fa0961f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("79f1087b-4fad-442c-a26c-badd487921b0"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7cdd63b2-2139-421c-b050-39b471718c5e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7fe0acfa-6c71-48a7-9035-41d2779f4bc8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("82d5f97a-84e2-4bee-96bf-52af5f58787b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8afc5d1b-bcad-4689-be60-65e62cc9ae01"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8cc6166d-4637-4191-ae49-9c3c65872a56"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("98ebeb99-9c2a-45ed-ac11-9c9ed3951574"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9cbc51b6-8a44-4480-98cc-6f1149c4e17f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ac122c8f-45b0-45d5-bf59-ee16bf673619"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("af693b88-c136-43b2-8450-81ef1d1a8572"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b81ac0b5-71f7-4c7c-aa7a-768df334c87b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b81eddf1-c9b5-497a-a976-6a12ac48441d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("c87359ec-8717-4790-adda-553b5facccc7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("cc8b2c2a-39fc-4ec3-9c35-79a463c29418"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ce795186-175b-4ebe-9f89-548ededa14a5"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d40fe25c-68c9-4cee-8f47-7d253c046e79"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d6106664-bea5-424f-bf59-e1f5ed7376cc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("da3fbe47-cfef-448f-b064-42b68a6071ee"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ef950c54-8677-47b9-991e-5094513e8844"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("05978733-128a-4ad1-84d0-a9255225f4e6"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("83927c25-29b3-4b04-9bac-f04fe9676e66"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("afc4441f-be5f-4394-b5f6-fb6eb63cc765"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("bbfc21ad-e3e1-4920-a62e-43e8081c0111"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("e5a20d26-91fa-4691-aaab-e55c3e8efa1f"));

            migrationBuilder.DropColumn(
                name: "Extra1ModuleCodeId",
                table: "StudentTemps");

            migrationBuilder.DropColumn(
                name: "Extra1SubjString",
                table: "StudentTemps");

            migrationBuilder.DropColumn(
                name: "Extra2ModuleCodeId",
                table: "StudentTemps");

            migrationBuilder.DropColumn(
                name: "Extra2SubjString",
                table: "StudentTemps");

            migrationBuilder.RenameColumn(
                name: "Extra3SubjString",
                table: "StudentTemps",
                newName: "ExtraSubjString");

            migrationBuilder.RenameColumn(
                name: "Extra3ModuleCodeId",
                table: "StudentTemps",
                newName: "ExtraModuleCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTemps_Extra3ModuleCodeId",
                table: "StudentTemps",
                newName: "IX_StudentTemps_ExtraModuleCodeId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "7c6046b9-5c8b-45d1-b859-262cc4d31586");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ef22805-e2dd-4ea1-9af5-2c84385fdefb", "AQAAAAEAACcQAAAAEIwJcQDrdKbQg05ksUpk+s2WdHpzUbAiJ7YwZhkKl1/x9K4ivi+rXPFYrP7jNQkgbg==", "95352f8d-53ad-459f-bddc-72d015a2cd6c" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("7f0c3d06-5995-4053-8917-8666be92442b"), new DateTime(2021, 10, 12, 13, 43, 19, 48, DateTimeKind.Local).AddTicks(1472), "F", "Female", false },
                    { new Guid("44da986c-d23d-4cbf-a301-336e61b31756"), new DateTime(2021, 10, 12, 13, 43, 19, 57, DateTimeKind.Local).AddTicks(2688), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "ModuleCodes",
                columns: new[] { "ModuleCodeId", "DateCreated", "IsDeleted", "ModuleCodeName" },
                values: new object[,]
                {
                    { new Guid("14b97ee8-e48f-4984-a513-836df6d5f051"), new DateTime(2021, 10, 12, 13, 43, 19, 91, DateTimeKind.Local).AddTicks(7552), false, "MML" },
                    { new Guid("f9d9db71-6f0b-4bb8-a212-b7d1925184a3"), new DateTime(2021, 10, 12, 13, 43, 19, 91, DateTimeKind.Local).AddTicks(7565), false, "LHC" },
                    { new Guid("e0a57603-e00a-433e-a8dd-505dc29203d1"), new DateTime(2021, 10, 12, 13, 43, 19, 91, DateTimeKind.Local).AddTicks(7581), false, "AGCLM" },
                    { new Guid("a4ce1b9d-8001-481a-87db-e94afd350138"), new DateTime(2021, 10, 12, 13, 43, 19, 91, DateTimeKind.Local).AddTicks(7584), false, "ABCP" },
                    { new Guid("e9cd8012-f84c-4dc5-87a7-b15dc091ea31"), new DateTime(2021, 10, 12, 13, 43, 19, 91, DateTimeKind.Local).AddTicks(7587), false, "ENG" },
                    { new Guid("c2764484-62d6-43da-81a4-f5bbdd716976"), new DateTime(2021, 10, 12, 13, 43, 19, 91, DateTimeKind.Local).AddTicks(7591), false, "AFR/XHO" },
                    { new Guid("bbe2fe92-d583-481a-af5d-adca0af227b6"), new DateTime(2021, 10, 12, 13, 43, 19, 91, DateTimeKind.Local).AddTicks(7594), false, "LO" },
                    { new Guid("d5543731-5117-444c-bd08-5330283e960a"), new DateTime(2021, 10, 12, 13, 43, 19, 91, DateTimeKind.Local).AddTicks(7597), false, "EXAM" },
                    { new Guid("dd7ba8d3-c392-43f6-98d9-36ce7d38e12e"), new DateTime(2021, 10, 12, 13, 43, 19, 91, DateTimeKind.Local).AddTicks(7086), false, "BASE" }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("dd48bae3-3770-421b-b6f5-ab0c0b109769"), "G", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6161), "10G", 10, false },
                    { new Guid("eb62cec8-52f3-4373-9fd4-ebabb3ab89e9"), "A", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6166), "11A", 11, false },
                    { new Guid("38eac2c3-f0fa-4c0f-84c7-7293fcc28537"), "B", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6172), "11B", 11, false },
                    { new Guid("2741cd2d-8160-4f74-98cc-3c211ce9d337"), "C", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6184), "11C", 11, false },
                    { new Guid("3c171cfc-6dbb-4c06-8ce6-e49d645d835b"), "D", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6189), "11D", 11, false },
                    { new Guid("bf05d880-f7ae-4890-8bf4-e3515cb6d62a"), "E", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6194), "11E", 11, false },
                    { new Guid("772523ec-aaca-4d97-8c33-3bac0a5ce1bc"), "C", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6222), "12C", 12, false },
                    { new Guid("43cae22e-2db1-48ae-8cac-edc49356937f"), "G", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6205), "11G", 11, false },
                    { new Guid("6161703e-691f-4120-8281-93d78ef542fe"), "A", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6211), "12A", 12, false },
                    { new Guid("8eb7a132-29db-461f-aaaa-c80d1b59b2aa"), "B", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6216), "12B", 12, false },
                    { new Guid("6366bc18-ffb4-4828-901c-1de5181082fc"), "D", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6234), "12D", 12, false },
                    { new Guid("a22f307a-4411-45bb-b915-2ab8ca5edc4e"), "E", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6240), "12E", 12, false },
                    { new Guid("50e08172-6d74-4508-9069-304e5593a9b3"), "F", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6245), "12F", 12, false },
                    { new Guid("9448ae89-7d14-4c40-986e-ff47e8ead889"), "G", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6251), "12G", 12, false },
                    { new Guid("fa5dff23-e28a-4a27-b28e-2b8ff568b89c"), "F", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6200), "11F", 11, false },
                    { new Guid("9c2e46b8-c092-477d-b00f-93b7cb7af0e2"), "F", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6156), "10F", 10, false },
                    { new Guid("a0fa6747-3954-4fa2-b8c8-f71afd50732a"), "C", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6139), "10C", 10, false },
                    { new Guid("6ffc9962-2e4c-44c0-9b88-ce552a292203"), "D", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6145), "10D", 10, false },
                    { new Guid("20fc4941-8b96-4222-a2d9-97c9bd8ce147"), "A", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(5953), "8A", 8, false },
                    { new Guid("bde6041a-de3d-4c5c-9f68-5977ccd1ec89"), "B", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6015), "8B", 8, false },
                    { new Guid("7d59a70b-4f55-472a-a373-7020e95e8926"), "C", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6022), "8C", 8, false },
                    { new Guid("8a6ec17d-c19f-4ecf-804a-6668bc26502f"), "D", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6028), "8D", 8, false },
                    { new Guid("8af8bcec-e274-4325-bc6c-4cef7bfd1f21"), "E", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6150), "10E", 10, false },
                    { new Guid("1abffeb5-ce73-4dbe-adb5-6262b2712009"), "F", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6040), "8F", 8, false },
                    { new Guid("a53bddd6-dcde-4fe7-8256-a3a968359a85"), "G", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6046), "8G", 8, false },
                    { new Guid("c8f1649b-4026-4e5f-a817-193701e9d95a"), "E", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6034), "8E", 8, false },
                    { new Guid("b22a3853-20f7-4421-8da3-fc60c4a8a659"), "B", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6082), "9B", 9, false },
                    { new Guid("b86479d2-021e-48ec-bf77-1c3b107e7dae"), "C", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6092), "9C", 9, false },
                    { new Guid("9ccb9997-fcee-4509-bce2-bb922c24a880"), "D", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6098), "9D", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("db0340a8-4b0c-4181-85a1-493b299954be"), "E", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6103), "9E", 9, false },
                    { new Guid("09f148cd-b69f-4607-9271-3205b9b01d9d"), "F", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6108), "9F", 9, false },
                    { new Guid("4a2a2e1f-3406-4cf2-91de-54cb82ad41c8"), "G", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6114), "9G", 9, false },
                    { new Guid("958604ab-e227-4e56-b8b9-011b0694b335"), "A", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6120), "10A", 10, false },
                    { new Guid("1d0ac70a-2c1f-4adc-903c-cb6251f75971"), "A", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6076), "9A", 9, false },
                    { new Guid("1ba7f645-ecdb-445b-968e-c1ae09bdb4ad"), "B", new DateTime(2021, 10, 12, 13, 43, 19, 63, DateTimeKind.Local).AddTicks(6132), "10B", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("d621dc5d-ab8c-46e5-b434-0d556c291c28"), new DateTime(2021, 10, 12, 13, 43, 19, 64, DateTimeKind.Local).AddTicks(1002), "G1", "G", 1, false },
                    { new Guid("9cac2d72-d7f9-401b-b7db-6597ee2f26fc"), new DateTime(2021, 10, 12, 13, 43, 19, 64, DateTimeKind.Local).AddTicks(1038), "G2", "G", 2, false },
                    { new Guid("d26fb98f-f6e7-44a6-ac1b-a28823b1a363"), new DateTime(2021, 10, 12, 13, 43, 19, 64, DateTimeKind.Local).AddTicks(1045), "G3", "G", 3, false },
                    { new Guid("51675d60-e9a4-4e89-a8f1-918cd7e48edc"), new DateTime(2021, 10, 12, 13, 43, 19, 64, DateTimeKind.Local).AddTicks(1051), "G4", "G", 4, false },
                    { new Guid("76356861-1caa-4fdd-af4f-d7b8b3ef2c36"), new DateTime(2021, 10, 12, 13, 43, 19, 64, DateTimeKind.Local).AddTicks(1069), "G5", "G", 5, false }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTemps_ModuleCodes_ExtraModuleCodeId",
                table: "StudentTemps",
                column: "ExtraModuleCodeId",
                principalTable: "ModuleCodes",
                principalColumn: "ModuleCodeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
