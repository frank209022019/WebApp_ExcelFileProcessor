using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class addStudIdToScreenTemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("8faa6acf-197e-4192-a220-a9f5c2c9447c"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("ab2a5e7e-210a-41e8-bb5e-f9fef61e8ce7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("032271cb-e615-4eb2-9eb2-5ec2aa35cee8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("06c70230-4a32-4a90-aaa6-1d0f6541a920"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("10e327d1-5259-4a08-b4ce-3e5d7f923dbb"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("14d20394-76a8-4c07-b39e-ece456bc1fbc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2376a7c9-3004-4ec9-b3f4-157f47da4ebd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("24ccbb69-ec1c-45b6-88ae-86db565dee5a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2d2d36e3-79b4-4861-a199-f60e73382d4e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("40f22b1f-ae37-41d1-aaff-546be3f22e72"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("41ce67d8-1a8e-4a57-a12c-ae48068ed824"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4b081e7e-3b34-4927-82b4-3c2fd72469c6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4c26b9f2-d4c4-4258-a15a-ecccad140ec8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("51630980-8f92-4bcf-862b-9dca324c2254"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5176eeaa-9449-4aa6-8c54-88c50539c7db"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("72c8e048-2211-4ba9-bd6b-f45e88bd61d4"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("73a64744-7c85-47e5-983c-51809f626fa8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("76d394bb-24b7-49ff-a848-7608828d6073"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8731d0a9-c31c-4518-9998-e52b0bad421b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("944806c4-5d1b-427a-8894-cd13bb095a8c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("944fdfb5-8c0b-4970-b2c9-979d48dcdc2d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9a9f835b-0bf2-4139-9905-58bd1dfee70b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9cc165a8-bc5c-48b4-808c-19720a9f0730"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a785b27f-060c-4a6f-acaf-9fede35872d4"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ac78a578-3a67-4c1a-b013-59a314d453b9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("aebd6abb-883b-4b6a-b378-98fae92037f1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b98b791a-2155-4f16-a7f3-7690abbbfd65"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("c7af6bfd-1c4c-4aa9-9cef-4ebe2520900d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("cb1f601e-2342-4ce3-87bd-f4a95f03a39d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("cb3e7208-8039-4b00-b9ff-9b3bb3ac47fd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("db9848aa-003d-4a53-8081-7fead75e476c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("de70aab4-4e8a-4233-aafd-ebf4545ef9dc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("dfa1abf2-10ef-4484-8242-32aa13caa556"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ee81aa6c-8083-4b3f-9d7a-438bbc3aa831"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f4afb68c-a064-4ecc-b04c-6e9641c6f564"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f791e3d8-96e2-4cdd-b259-696818b3180f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fd86af7f-388f-4e85-a61e-6f8acf5cdf48"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("277a47ca-4579-42cc-a986-2cf4a2f65feb"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("8849d6cb-049e-42a9-982a-4a9ccf78d3f4"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("92720001-99da-463d-8648-4f21612f8740"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("0a8a57ba-a86e-4e7b-a011-09f6e7352654"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("262c10eb-010e-4db0-9500-64712915ee9d"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("96100943-27a5-4602-8a75-623552fa8d75"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("980a8b9a-e1c7-482c-8ad3-b19328b64a5f"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("edb28e68-064d-4c14-9363-669312929cd9"));

            migrationBuilder.AddColumn<Guid>(
                name: "StudentId",
                table: "StudentScreeningTemps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "ca281a6c-d18d-455f-b246-4b0f4dc345ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe365527-3115-49e7-868c-997fd900024d", "AQAAAAEAACcQAAAAEKiVHc/HNSKBbQuxPfMCEutTJ+cYxCoxffZhu2YdEQkPASgs3MamiEHWWqJB9f+bkQ==", "22ebbf1d-d0c1-4528-a1b1-04d6780baff0" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("5cd3fb7a-4fe4-4252-b776-a510e3f5fde8"), new DateTime(2021, 9, 16, 10, 8, 41, 402, DateTimeKind.Local).AddTicks(6498), "F", "Female", false },
                    { new Guid("a2b5982a-bc68-4acc-9abc-0e7aec807aa8"), new DateTime(2021, 9, 16, 10, 8, 41, 404, DateTimeKind.Local).AddTicks(2479), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("457bc344-752a-4a00-a33d-8487eaf6c357"), "B", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9640), "8B", 8, false },
                    { new Guid("dfebcec9-d1df-4026-91ea-e487b6a0b9dd"), "A", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9622), "8A", 8, false },
                    { new Guid("796e11bb-aa3c-4e04-9ea6-3f678b83ba6b"), "C", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9729), "11C", 11, false },
                    { new Guid("97cfb147-c539-4f9c-9191-b2c5933bcb36"), "D", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9731), "11D", 11, false },
                    { new Guid("6f4d0155-10f5-412a-a1c1-00bbf7c9f239"), "E", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9734), "11E", 11, false },
                    { new Guid("099542ea-3ac7-4c79-8edf-64ac7a01fb36"), "F", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9737), "11F", 11, false },
                    { new Guid("4862f608-5b21-42c4-acfa-3afa7090cb5c"), "G", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9720), "10G", 10, false },
                    { new Guid("4af7ca9b-e3bc-4819-8ac1-9164154e8423"), "G", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9741), "11G", 11, false },
                    { new Guid("9e571b69-f422-4901-897c-98d1a9e2fff0"), "B", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9749), "12B", 12, false },
                    { new Guid("4002ea1b-25f8-4065-a5cc-b0340f8d99f0"), "C", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9752), "12C", 12, false },
                    { new Guid("e0cb445d-2ce9-4b3a-9bda-b35741ecaa30"), "D", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9755), "12D", 12, false },
                    { new Guid("00d209ce-fd2a-4655-bcf9-2b0aa6c8ff52"), "E", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9758), "12E", 12, false },
                    { new Guid("fe61cbae-cf29-4767-a6ac-013c496e9c1b"), "F", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9761), "12F", 12, false },
                    { new Guid("12a36872-8c09-41be-9e9d-83e47fe877c8"), "G", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9764), "12G", 12, false },
                    { new Guid("12f33be7-bbb7-42ed-8e4c-d326a695641b"), "A", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9747), "12A", 12, false },
                    { new Guid("d5c5d10f-b9a7-4753-a8cb-7eacebd028a1"), "F", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9714), "10F", 10, false },
                    { new Guid("13c523f7-74d0-4f4f-b1f7-55268ceb24fe"), "B", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9726), "11B", 11, false },
                    { new Guid("238ffedd-2842-4549-a2c3-eb0d7f95fdc5"), "D", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9708), "10D", 10, false },
                    { new Guid("c1d47ca3-014f-4bec-810f-934f8fd37ab7"), "C", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9645), "8C", 8, false },
                    { new Guid("9d227953-02df-4771-b109-52b0175f798a"), "D", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9648), "8D", 8, false },
                    { new Guid("0ccc2558-b334-48d0-a5a4-8294ce6d4f60"), "E", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9664), "8E", 8, false },
                    { new Guid("44919ed1-50c7-4b28-9b8d-f8c8a7b001ad"), "E", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9711), "10E", 10, false },
                    { new Guid("339dd6b2-49fd-450b-b80f-bc858323b55d"), "G", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9671), "8G", 8, false },
                    { new Guid("ffd4dacf-9839-41b3-90d7-14c24fdd0953"), "A", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9674), "9A", 9, false },
                    { new Guid("cd23ef7f-9a7e-4154-aed7-b67ce43ae58e"), "B", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9678), "9B", 9, false },
                    { new Guid("a48b362a-7cab-4a39-b1fc-bca4952aa0b0"), "F", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9668), "8F", 8, false },
                    { new Guid("c42f2042-d414-45e5-b266-3704c32f65ce"), "D", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9683), "9D", 9, false },
                    { new Guid("4af0c821-3ce9-4536-b658-24747e6b8428"), "C", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9680), "9C", 9, false },
                    { new Guid("634fffe4-bd78-41b7-9add-01c037ed8ebd"), "C", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9705), "10C", 10, false },
                    { new Guid("613620a5-b80c-44be-8b43-6eda63a1507a"), "B", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9702), "10B", 10, false },
                    { new Guid("f1a94b21-be42-43dc-9ccd-1c3cd8a5b315"), "A", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9723), "11A", 11, false },
                    { new Guid("85a85792-68c6-4352-b80e-253aa4725523"), "G", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9696), "9G", 9, false },
                    { new Guid("e52189a7-741d-4b42-8b88-2f480e1411ff"), "F", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9694), "9F", 9, false },
                    { new Guid("acc5112c-5884-42e6-8c76-cba7bb49a0bc"), "E", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9687), "9E", 9, false },
                    { new Guid("f556b543-bef6-42b7-b902-4e3b79c985e7"), "A", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(9699), "10A", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("6dd4ff35-b5f4-43e3-872a-8e82ecf71b37"), "Gold", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(6612), false },
                    { new Guid("cd92bc30-852e-4609-acbc-6db6d1546d5e"), "Unassigned", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(6655), false },
                    { new Guid("578a8d14-0b19-428d-96c4-abd7485140ce"), "Scarlet", new DateTime(2021, 9, 16, 10, 8, 41, 406, DateTimeKind.Local).AddTicks(6651), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("5170bc95-0fa4-48bb-bd31-062a553fc728"), new DateTime(2021, 9, 16, 10, 8, 41, 407, DateTimeKind.Local).AddTicks(2228), "G1", "G", 1, false },
                    { new Guid("bdd4237b-a3d1-4dd4-bbe8-8de348128ee8"), new DateTime(2021, 9, 16, 10, 8, 41, 407, DateTimeKind.Local).AddTicks(2249), "G2", "G", 2, false },
                    { new Guid("1452aa4e-7dc5-4378-9626-6b48564981e1"), new DateTime(2021, 9, 16, 10, 8, 41, 407, DateTimeKind.Local).AddTicks(2253), "G3", "G", 3, false },
                    { new Guid("9706023c-0c0c-42ba-ac86-cf27221e7122"), new DateTime(2021, 9, 16, 10, 8, 41, 407, DateTimeKind.Local).AddTicks(2256), "G4", "G", 4, false },
                    { new Guid("41a21fd6-a1d4-40ab-986e-060b85a56c61"), new DateTime(2021, 9, 16, 10, 8, 41, 407, DateTimeKind.Local).AddTicks(2260), "G5", "G", 5, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentScreeningTemps_StudentId",
                table: "StudentScreeningTemps",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentScreeningTemps_Students_StudentId",
                table: "StudentScreeningTemps",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentScreeningTemps_Students_StudentId",
                table: "StudentScreeningTemps");

            migrationBuilder.DropIndex(
                name: "IX_StudentScreeningTemps_StudentId",
                table: "StudentScreeningTemps");

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("5cd3fb7a-4fe4-4252-b776-a510e3f5fde8"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("a2b5982a-bc68-4acc-9abc-0e7aec807aa8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("00d209ce-fd2a-4655-bcf9-2b0aa6c8ff52"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("099542ea-3ac7-4c79-8edf-64ac7a01fb36"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("0ccc2558-b334-48d0-a5a4-8294ce6d4f60"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("12a36872-8c09-41be-9e9d-83e47fe877c8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("12f33be7-bbb7-42ed-8e4c-d326a695641b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("13c523f7-74d0-4f4f-b1f7-55268ceb24fe"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("238ffedd-2842-4549-a2c3-eb0d7f95fdc5"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("339dd6b2-49fd-450b-b80f-bc858323b55d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4002ea1b-25f8-4065-a5cc-b0340f8d99f0"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("44919ed1-50c7-4b28-9b8d-f8c8a7b001ad"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("457bc344-752a-4a00-a33d-8487eaf6c357"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4862f608-5b21-42c4-acfa-3afa7090cb5c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4af0c821-3ce9-4536-b658-24747e6b8428"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4af7ca9b-e3bc-4819-8ac1-9164154e8423"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("613620a5-b80c-44be-8b43-6eda63a1507a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("634fffe4-bd78-41b7-9add-01c037ed8ebd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6f4d0155-10f5-412a-a1c1-00bbf7c9f239"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("796e11bb-aa3c-4e04-9ea6-3f678b83ba6b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("85a85792-68c6-4352-b80e-253aa4725523"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("97cfb147-c539-4f9c-9191-b2c5933bcb36"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9d227953-02df-4771-b109-52b0175f798a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9e571b69-f422-4901-897c-98d1a9e2fff0"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a48b362a-7cab-4a39-b1fc-bca4952aa0b0"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("acc5112c-5884-42e6-8c76-cba7bb49a0bc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("c1d47ca3-014f-4bec-810f-934f8fd37ab7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("c42f2042-d414-45e5-b266-3704c32f65ce"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("cd23ef7f-9a7e-4154-aed7-b67ce43ae58e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d5c5d10f-b9a7-4753-a8cb-7eacebd028a1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("dfebcec9-d1df-4026-91ea-e487b6a0b9dd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e0cb445d-2ce9-4b3a-9bda-b35741ecaa30"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e52189a7-741d-4b42-8b88-2f480e1411ff"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f1a94b21-be42-43dc-9ccd-1c3cd8a5b315"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f556b543-bef6-42b7-b902-4e3b79c985e7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fe61cbae-cf29-4767-a6ac-013c496e9c1b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ffd4dacf-9839-41b3-90d7-14c24fdd0953"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("578a8d14-0b19-428d-96c4-abd7485140ce"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("6dd4ff35-b5f4-43e3-872a-8e82ecf71b37"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("cd92bc30-852e-4609-acbc-6db6d1546d5e"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("1452aa4e-7dc5-4378-9626-6b48564981e1"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("41a21fd6-a1d4-40ab-986e-060b85a56c61"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("5170bc95-0fa4-48bb-bd31-062a553fc728"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("9706023c-0c0c-42ba-ac86-cf27221e7122"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("bdd4237b-a3d1-4dd4-bbe8-8de348128ee8"));

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudentScreeningTemps");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "b83bcb0f-3653-4678-b86e-09b9258edfb0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11c3c424-9500-43cf-b745-3ffa81ee2be7", "AQAAAAEAACcQAAAAED425aqLaATyYeSJ4KVwdGoih6/tnfri0ABucxgiHZjkVXGXVS2hYHAzJNkAsrX4ew==", "9b61e40b-0211-4f8d-98d2-56eb24f6c61f" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("8faa6acf-197e-4192-a220-a9f5c2c9447c"), new DateTime(2021, 9, 16, 10, 5, 13, 292, DateTimeKind.Local).AddTicks(5800), "F", "Female", false },
                    { new Guid("ab2a5e7e-210a-41e8-bb5e-f9fef61e8ce7"), new DateTime(2021, 9, 16, 10, 5, 13, 293, DateTimeKind.Local).AddTicks(7054), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("f4afb68c-a064-4ecc-b04c-6e9641c6f564"), "B", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2314), "8B", 8, false },
                    { new Guid("db9848aa-003d-4a53-8081-7fead75e476c"), "A", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2293), "8A", 8, false },
                    { new Guid("de70aab4-4e8a-4233-aafd-ebf4545ef9dc"), "C", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2366), "11C", 11, false },
                    { new Guid("24ccbb69-ec1c-45b6-88ae-86db565dee5a"), "D", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2368), "11D", 11, false },
                    { new Guid("41ce67d8-1a8e-4a57-a12c-ae48068ed824"), "E", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2371), "11E", 11, false },
                    { new Guid("944806c4-5d1b-427a-8894-cd13bb095a8c"), "F", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2373), "11F", 11, false },
                    { new Guid("72c8e048-2211-4ba9-bd6b-f45e88bd61d4"), "G", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2360), "10G", 10, false },
                    { new Guid("fd86af7f-388f-4e85-a61e-6f8acf5cdf48"), "G", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2375), "11G", 11, false },
                    { new Guid("40f22b1f-ae37-41d1-aaff-546be3f22e72"), "B", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2379), "12B", 12, false },
                    { new Guid("aebd6abb-883b-4b6a-b378-98fae92037f1"), "C", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2381), "12C", 12, false },
                    { new Guid("51630980-8f92-4bcf-862b-9dca324c2254"), "D", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2383), "12D", 12, false },
                    { new Guid("2376a7c9-3004-4ec9-b3f4-157f47da4ebd"), "E", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2385), "12E", 12, false },
                    { new Guid("cb1f601e-2342-4ce3-87bd-f4a95f03a39d"), "F", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2389), "12F", 12, false },
                    { new Guid("76d394bb-24b7-49ff-a848-7608828d6073"), "G", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2391), "12G", 12, false },
                    { new Guid("8731d0a9-c31c-4518-9998-e52b0bad421b"), "A", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2377), "12A", 12, false },
                    { new Guid("73a64744-7c85-47e5-983c-51809f626fa8"), "F", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2357), "10F", 10, false },
                    { new Guid("9cc165a8-bc5c-48b4-808c-19720a9f0730"), "B", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2364), "11B", 11, false },
                    { new Guid("06c70230-4a32-4a90-aaa6-1d0f6541a920"), "D", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2352), "10D", 10, false },
                    { new Guid("dfa1abf2-10ef-4484-8242-32aa13caa556"), "C", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2317), "8C", 8, false },
                    { new Guid("ac78a578-3a67-4c1a-b013-59a314d453b9"), "D", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2320), "8D", 8, false },
                    { new Guid("9a9f835b-0bf2-4139-9905-58bd1dfee70b"), "E", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2322), "8E", 8, false },
                    { new Guid("032271cb-e615-4eb2-9eb2-5ec2aa35cee8"), "E", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2354), "10E", 10, false },
                    { new Guid("4b081e7e-3b34-4927-82b4-3c2fd72469c6"), "G", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2326), "8G", 8, false },
                    { new Guid("2d2d36e3-79b4-4861-a199-f60e73382d4e"), "A", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2328), "9A", 9, false },
                    { new Guid("f791e3d8-96e2-4cdd-b259-696818b3180f"), "B", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2330), "9B", 9, false },
                    { new Guid("ee81aa6c-8083-4b3f-9d7a-438bbc3aa831"), "F", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2324), "8F", 8, false },
                    { new Guid("b98b791a-2155-4f16-a7f3-7690abbbfd65"), "D", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2337), "9D", 9, false },
                    { new Guid("5176eeaa-9449-4aa6-8c54-88c50539c7db"), "C", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2335), "9C", 9, false },
                    { new Guid("a785b27f-060c-4a6f-acaf-9fede35872d4"), "C", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2348), "10C", 10, false },
                    { new Guid("14d20394-76a8-4c07-b39e-ece456bc1fbc"), "B", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2346), "10B", 10, false },
                    { new Guid("cb3e7208-8039-4b00-b9ff-9b3bb3ac47fd"), "A", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2362), "11A", 11, false },
                    { new Guid("4c26b9f2-d4c4-4258-a15a-ecccad140ec8"), "G", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2343), "9G", 9, false },
                    { new Guid("c7af6bfd-1c4c-4aa9-9cef-4ebe2520900d"), "F", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2341), "9F", 9, false },
                    { new Guid("10e327d1-5259-4a08-b4ce-3e5d7f923dbb"), "E", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2339), "9E", 9, false },
                    { new Guid("944fdfb5-8c0b-4970-b2c9-979d48dcdc2d"), "A", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(2344), "10A", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("8849d6cb-049e-42a9-982a-4a9ccf78d3f4"), "Gold", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(610), false },
                    { new Guid("277a47ca-4579-42cc-a986-2cf4a2f65feb"), "Unassigned", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(636), false },
                    { new Guid("92720001-99da-463d-8648-4f21612f8740"), "Scarlet", new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(634), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("0a8a57ba-a86e-4e7b-a011-09f6e7352654"), new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(3825), "G1", "G", 1, false },
                    { new Guid("edb28e68-064d-4c14-9363-669312929cd9"), new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(3834), "G2", "G", 2, false },
                    { new Guid("980a8b9a-e1c7-482c-8ad3-b19328b64a5f"), new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(3836), "G3", "G", 3, false },
                    { new Guid("96100943-27a5-4602-8a75-623552fa8d75"), new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(3838), "G4", "G", 4, false },
                    { new Guid("262c10eb-010e-4db0-9500-64712915ee9d"), new DateTime(2021, 9, 16, 10, 5, 13, 295, DateTimeKind.Local).AddTicks(3840), "G5", "G", 5, false }
                });
        }
    }
}
