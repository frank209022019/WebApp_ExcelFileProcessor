using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class studentTEmpUpdateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentScreeningTemps_Students_StudentId",
                table: "StudentScreeningTemps");

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("398e23a8-95c8-4063-ab43-ce91633a9144"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("6553c842-95fd-4758-a972-2318e8b0668e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1079b163-fc1d-4ce8-a7be-b78e06300b72"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("13ccfc5c-c285-4b7c-b748-01e316c5fea8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1b0cb506-bb69-4127-96c8-c099d5461cd1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1ed58da9-f77c-4f02-8705-10a5b39f3b6f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("23214fe7-b0aa-4236-92da-b5999b71b4fe"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("25a842b1-dc5f-47b4-9ce1-40b467852d28"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("28087e09-4c45-4c70-953c-5f9a5cc0128b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("28fad2c9-f62a-466a-9df0-ba86827ffb88"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("37d351ab-441d-4089-b94c-d246d2c7e5c6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3942f650-dfb9-43b0-b98b-d7195cb16714"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4fcb44db-9295-4c39-941a-6d1ea870b262"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("63d46601-5e73-4472-aad3-a881486f8a1e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("65f8306f-a1c3-4980-a426-791b7863a137"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7a20d4ad-9627-45ef-aca9-f4bd7c5771fd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7a990534-135c-4608-a430-ccda4019c6fd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7d50b66e-7560-4bdf-bc47-1ce2ebbda110"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("806ce855-4e55-4565-9731-963c2e325d43"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("82773db2-057d-4982-9d8c-11003f24f99a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("84bd4c3e-c058-4d42-9a2f-31a87df51085"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("884bc822-bb7d-4f1d-8310-91362cefb414"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9c1e0011-78f7-4b82-a0e9-e634d2e48576"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("afe02a84-eed4-4568-9171-bb95498f60c9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b24ccff3-a8c8-4f79-8bad-e26c30cc2a1c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("bee8486a-95b4-49b2-8e58-b5c7462ca640"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("c6ff437e-7c47-4d4c-85f6-96e1103a635d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("c85d0322-618d-42e0-b390-2f22605fea03"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d1aaad77-56f1-477d-a5aa-991f9501906e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d3be3ccc-d5bd-4a6d-bca2-045781fd0ae9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e568d975-8775-4bb8-ab17-bfb357435e36"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e59b8633-3461-4e76-b912-90fa187f394f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("eb94142f-8c43-40e2-b9c5-92a81f4be4f1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f10eec07-f22e-4bf7-afcc-576973efe0c3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f3c21626-cef9-4a30-9972-989028527708"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fa755f51-ff4e-466a-94f2-e5c7cec7c8a7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fc8a0df1-dd47-4007-be9e-b27673d4360f"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("04df85fb-6297-4820-b508-2a348432ffa7"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("80435db6-5c7f-4f97-b583-f22891ae066b"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("dd951ff5-2db0-4b65-835c-f0ef6e5388f6"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("0c41e7fe-2420-40bd-a4d6-512a470e4701"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("396bcea9-c03d-4856-b61f-e8d0b2e67b66"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("60cbba69-48ea-4291-9978-97c729807a7d"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("6fd973ff-1078-4764-bfaa-a380e8302035"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("d9feb70d-2582-4264-98e2-2e95747b8681"));

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "StudentScreeningTemps",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ScrenningTimeStamp",
                table: "StudentScreeningTemps",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "3b978f77-638b-4268-8723-066e0ae0e76e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "324f7c85-d168-47c5-97b9-c5c0ed8e3a8a", "AQAAAAEAACcQAAAAEHJTNk4Fhsgzr/d3u4/x0akfHsUNF5wVhNeSjyjfwG0drtIXFKlHLVGVLAlWVLOuBg==", "b1f5e28b-69e0-4818-8d30-261d214bbe64" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("f1ae47fc-0bb1-4074-a8f5-723738f96a35"), new DateTime(2021, 9, 16, 15, 3, 55, 839, DateTimeKind.Local).AddTicks(9731), "F", "Female", false },
                    { new Guid("0b8e5038-3e54-4b88-bb7f-78b3f5edc652"), new DateTime(2021, 9, 16, 15, 3, 55, 840, DateTimeKind.Local).AddTicks(8746), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("58df8ce2-3b2e-4ff7-94c9-4a8d76dfbefa"), "B", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9338), "8B", 8, false },
                    { new Guid("cd5c8032-94fe-4fd5-a47d-3855ea2851e9"), "A", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9312), "8A", 8, false },
                    { new Guid("30e5c30f-12bd-4074-bbc7-6bc036db8bc2"), "C", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9426), "11C", 11, false },
                    { new Guid("6489cf42-d9b8-4531-b819-a7abfab2b332"), "D", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9427), "11D", 11, false },
                    { new Guid("de368f7b-759b-467c-af88-e7ac88e97cea"), "E", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9431), "11E", 11, false },
                    { new Guid("90ea74b2-cb15-4f25-93c2-e7f40aa4c1f4"), "F", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9433), "11F", 11, false },
                    { new Guid("50757075-c909-4d59-ad1a-4b537e626b85"), "G", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9420), "10G", 10, false },
                    { new Guid("da1668a7-e7f2-45c6-9eff-097be310a254"), "G", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9434), "11G", 11, false },
                    { new Guid("d5434ae2-afe9-4111-a9cb-cb6181991300"), "B", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9438), "12B", 12, false },
                    { new Guid("f4d39f47-55f2-4d7c-862a-c50e9da05149"), "C", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9440), "12C", 12, false },
                    { new Guid("319020ab-8fae-45c4-b5f8-9131da974700"), "D", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9442), "12D", 12, false },
                    { new Guid("82c0202d-6557-43fc-b4ea-cc15b7a29105"), "E", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9444), "12E", 12, false },
                    { new Guid("1d0dcdae-85fa-4cac-96d2-41cadf6116a5"), "F", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9447), "12F", 12, false },
                    { new Guid("2e055ad7-623d-402c-828c-c36abb12e381"), "G", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9449), "12G", 12, false },
                    { new Guid("dfb679af-ff77-4704-96d5-56da3eda983b"), "A", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9436), "12A", 12, false },
                    { new Guid("9a4acdd5-33e4-4807-aeee-5e85cfe6d965"), "F", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9418), "10F", 10, false },
                    { new Guid("610f5a3b-acec-419e-8d44-c3e1f72a874f"), "B", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9424), "11B", 11, false },
                    { new Guid("5e8e7873-a7a1-4572-b3b1-d5d80e13b275"), "D", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9413), "10D", 10, false },
                    { new Guid("6cb83ca3-703f-44b5-9031-9f1e0bad18ac"), "C", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9340), "8C", 8, false },
                    { new Guid("a584a98b-4b98-46c5-85ca-fba9d631117e"), "D", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9342), "8D", 8, false },
                    { new Guid("e7d0c13a-e1b2-4127-9e93-1dba42f3298f"), "E", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9344), "8E", 8, false },
                    { new Guid("ed8de6f9-ecd2-4eb2-83f0-513156689f6c"), "E", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9416), "10E", 10, false },
                    { new Guid("a9a2d919-c4b1-4576-88d1-ba0b07920c06"), "G", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9347), "8G", 8, false },
                    { new Guid("ebe6fdad-b24c-49c1-8aed-60204f9c46ce"), "A", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9349), "9A", 9, false },
                    { new Guid("a754672f-e1d9-4fa7-a5b4-8912c52b0239"), "B", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9351), "9B", 9, false },
                    { new Guid("305c1082-5fd3-4a2c-aa57-9297a161f215"), "F", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9345), "8F", 8, false },
                    { new Guid("3064f04f-62b6-4684-8772-56543657b209"), "D", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9399), "9D", 9, false },
                    { new Guid("27bd7007-1cc7-480b-8e11-60dd2e338ea8"), "C", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9396), "9C", 9, false },
                    { new Guid("2f0136b3-403f-4649-a027-d0a7f5a3aa50"), "C", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9410), "10C", 10, false },
                    { new Guid("04540034-174d-4386-93f1-21e9b73a62d0"), "B", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9408), "10B", 10, false },
                    { new Guid("a90caa4a-29b5-4665-9d9a-26bc8474e6e0"), "A", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9422), "11A", 11, false },
                    { new Guid("e7a0cda6-6510-4f16-894f-6c6a10dd224a"), "G", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9404), "9G", 9, false },
                    { new Guid("e7a7bf3a-349d-483f-87aa-a453e504bc6d"), "F", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9403), "9F", 9, false },
                    { new Guid("44c64471-05a4-4b35-8970-821cb466d3c4"), "E", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9401), "9E", 9, false },
                    { new Guid("3b1c568f-30cc-4614-b6e9-916787db8463"), "A", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(9406), "10A", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("a70c4263-89be-4eac-a169-52e939b2adf5"), "Gold", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(7831), false },
                    { new Guid("7ae7ef9b-1cae-428f-b022-2688bade9d89"), "Unassigned", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(7846), false },
                    { new Guid("83f2c3e8-2bea-48bf-9031-e26facbd49de"), "Scarlet", new DateTime(2021, 9, 16, 15, 3, 55, 841, DateTimeKind.Local).AddTicks(7844), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("3defd5e7-07f7-441c-83ea-c220abd478a0"), new DateTime(2021, 9, 16, 15, 3, 55, 842, DateTimeKind.Local).AddTicks(831), "G1", "G", 1, false },
                    { new Guid("73181ba4-784c-44a3-ad4a-af6246edd7c1"), new DateTime(2021, 9, 16, 15, 3, 55, 842, DateTimeKind.Local).AddTicks(840), "G2", "G", 2, false },
                    { new Guid("336e66e4-fe83-44dc-935f-64f67bb15fdf"), new DateTime(2021, 9, 16, 15, 3, 55, 842, DateTimeKind.Local).AddTicks(842), "G3", "G", 3, false },
                    { new Guid("0fb6c984-febb-4df0-bffa-ebab4c4aa236"), new DateTime(2021, 9, 16, 15, 3, 55, 842, DateTimeKind.Local).AddTicks(844), "G4", "G", 4, false },
                    { new Guid("9f33022e-79b5-4b50-b97d-3e3ba090a80a"), new DateTime(2021, 9, 16, 15, 3, 55, 842, DateTimeKind.Local).AddTicks(846), "G5", "G", 5, false }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentScreeningTemps_Students_StudentId",
                table: "StudentScreeningTemps",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentScreeningTemps_Students_StudentId",
                table: "StudentScreeningTemps");

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("0b8e5038-3e54-4b88-bb7f-78b3f5edc652"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("f1ae47fc-0bb1-4074-a8f5-723738f96a35"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("04540034-174d-4386-93f1-21e9b73a62d0"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1d0dcdae-85fa-4cac-96d2-41cadf6116a5"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("27bd7007-1cc7-480b-8e11-60dd2e338ea8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2e055ad7-623d-402c-828c-c36abb12e381"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2f0136b3-403f-4649-a027-d0a7f5a3aa50"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("305c1082-5fd3-4a2c-aa57-9297a161f215"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3064f04f-62b6-4684-8772-56543657b209"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("30e5c30f-12bd-4074-bbc7-6bc036db8bc2"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("319020ab-8fae-45c4-b5f8-9131da974700"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3b1c568f-30cc-4614-b6e9-916787db8463"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("44c64471-05a4-4b35-8970-821cb466d3c4"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("50757075-c909-4d59-ad1a-4b537e626b85"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("58df8ce2-3b2e-4ff7-94c9-4a8d76dfbefa"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5e8e7873-a7a1-4572-b3b1-d5d80e13b275"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("610f5a3b-acec-419e-8d44-c3e1f72a874f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6489cf42-d9b8-4531-b819-a7abfab2b332"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6cb83ca3-703f-44b5-9031-9f1e0bad18ac"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("82c0202d-6557-43fc-b4ea-cc15b7a29105"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("90ea74b2-cb15-4f25-93c2-e7f40aa4c1f4"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9a4acdd5-33e4-4807-aeee-5e85cfe6d965"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a584a98b-4b98-46c5-85ca-fba9d631117e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a754672f-e1d9-4fa7-a5b4-8912c52b0239"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a90caa4a-29b5-4665-9d9a-26bc8474e6e0"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a9a2d919-c4b1-4576-88d1-ba0b07920c06"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("cd5c8032-94fe-4fd5-a47d-3855ea2851e9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d5434ae2-afe9-4111-a9cb-cb6181991300"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("da1668a7-e7f2-45c6-9eff-097be310a254"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("de368f7b-759b-467c-af88-e7ac88e97cea"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("dfb679af-ff77-4704-96d5-56da3eda983b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e7a0cda6-6510-4f16-894f-6c6a10dd224a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e7a7bf3a-349d-483f-87aa-a453e504bc6d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e7d0c13a-e1b2-4127-9e93-1dba42f3298f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ebe6fdad-b24c-49c1-8aed-60204f9c46ce"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ed8de6f9-ecd2-4eb2-83f0-513156689f6c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f4d39f47-55f2-4d7c-862a-c50e9da05149"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("7ae7ef9b-1cae-428f-b022-2688bade9d89"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("83f2c3e8-2bea-48bf-9031-e26facbd49de"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("a70c4263-89be-4eac-a169-52e939b2adf5"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("0fb6c984-febb-4df0-bffa-ebab4c4aa236"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("336e66e4-fe83-44dc-935f-64f67bb15fdf"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("3defd5e7-07f7-441c-83ea-c220abd478a0"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("73181ba4-784c-44a3-ad4a-af6246edd7c1"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("9f33022e-79b5-4b50-b97d-3e3ba090a80a"));

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "StudentScreeningTemps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ScrenningTimeStamp",
                table: "StudentScreeningTemps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "1c53e817-871b-4b10-ae36-0b62dff241cd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cd07e86-9cd4-4f5e-8c84-cb154b95a8fa", "AQAAAAEAACcQAAAAEBOwm0MuUZceTHI0T7/P53fmQH9Jj542KiaR+VnAsUvDtPjAW2zGEXoNLnRtEhFzOg==", "4eb66af3-c2b8-43c8-be50-f55790d116b8" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("6553c842-95fd-4758-a972-2318e8b0668e"), new DateTime(2021, 9, 16, 14, 31, 6, 816, DateTimeKind.Local).AddTicks(4742), "F", "Female", false },
                    { new Guid("398e23a8-95c8-4063-ab43-ce91633a9144"), new DateTime(2021, 9, 16, 14, 31, 6, 817, DateTimeKind.Local).AddTicks(4914), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("c85d0322-618d-42e0-b390-2f22605fea03"), "B", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7046), "8B", 8, false },
                    { new Guid("f3c21626-cef9-4a30-9972-989028527708"), "A", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7036), "8A", 8, false },
                    { new Guid("d1aaad77-56f1-477d-a5aa-991f9501906e"), "C", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7103), "11C", 11, false },
                    { new Guid("1ed58da9-f77c-4f02-8705-10a5b39f3b6f"), "D", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7105), "11D", 11, false },
                    { new Guid("28087e09-4c45-4c70-953c-5f9a5cc0128b"), "E", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7107), "11E", 11, false },
                    { new Guid("7d50b66e-7560-4bdf-bc47-1ce2ebbda110"), "F", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7109), "11F", 11, false },
                    { new Guid("e59b8633-3461-4e76-b912-90fa187f394f"), "G", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7098), "10G", 10, false },
                    { new Guid("884bc822-bb7d-4f1d-8310-91362cefb414"), "G", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7113), "11G", 11, false },
                    { new Guid("1079b163-fc1d-4ce8-a7be-b78e06300b72"), "B", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7116), "12B", 12, false },
                    { new Guid("afe02a84-eed4-4568-9171-bb95498f60c9"), "C", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7118), "12C", 12, false },
                    { new Guid("d3be3ccc-d5bd-4a6d-bca2-045781fd0ae9"), "D", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7120), "12D", 12, false },
                    { new Guid("84bd4c3e-c058-4d42-9a2f-31a87df51085"), "E", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7122), "12E", 12, false },
                    { new Guid("806ce855-4e55-4565-9731-963c2e325d43"), "F", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7125), "12F", 12, false },
                    { new Guid("65f8306f-a1c3-4980-a426-791b7863a137"), "G", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7127), "12G", 12, false },
                    { new Guid("25a842b1-dc5f-47b4-9ce1-40b467852d28"), "A", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7115), "12A", 12, false },
                    { new Guid("3942f650-dfb9-43b0-b98b-d7195cb16714"), "F", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7095), "10F", 10, false },
                    { new Guid("7a990534-135c-4608-a430-ccda4019c6fd"), "B", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7101), "11B", 11, false },
                    { new Guid("eb94142f-8c43-40e2-b9c5-92a81f4be4f1"), "D", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7090), "10D", 10, false },
                    { new Guid("1b0cb506-bb69-4127-96c8-c099d5461cd1"), "C", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7048), "8C", 8, false },
                    { new Guid("37d351ab-441d-4089-b94c-d246d2c7e5c6"), "D", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7059), "8D", 8, false },
                    { new Guid("13ccfc5c-c285-4b7c-b748-01e316c5fea8"), "E", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7062), "8E", 8, false },
                    { new Guid("23214fe7-b0aa-4236-92da-b5999b71b4fe"), "E", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7092), "10E", 10, false },
                    { new Guid("82773db2-057d-4982-9d8c-11003f24f99a"), "G", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7065), "8G", 8, false },
                    { new Guid("bee8486a-95b4-49b2-8e58-b5c7462ca640"), "A", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7067), "9A", 9, false },
                    { new Guid("63d46601-5e73-4472-aad3-a881486f8a1e"), "B", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7069), "9B", 9, false },
                    { new Guid("f10eec07-f22e-4bf7-afcc-576973efe0c3"), "F", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7063), "8F", 8, false },
                    { new Guid("9c1e0011-78f7-4b82-a0e9-e634d2e48576"), "D", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7073), "9D", 9, false },
                    { new Guid("4fcb44db-9295-4c39-941a-6d1ea870b262"), "C", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7071), "9C", 9, false },
                    { new Guid("fc8a0df1-dd47-4007-be9e-b27673d4360f"), "C", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7088), "10C", 10, false },
                    { new Guid("28fad2c9-f62a-466a-9df0-ba86827ffb88"), "B", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7085), "10B", 10, false },
                    { new Guid("b24ccff3-a8c8-4f79-8bad-e26c30cc2a1c"), "A", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7099), "11A", 11, false },
                    { new Guid("fa755f51-ff4e-466a-94f2-e5c7cec7c8a7"), "G", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7081), "9G", 9, false },
                    { new Guid("c6ff437e-7c47-4d4c-85f6-96e1103a635d"), "F", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7080), "9F", 9, false },
                    { new Guid("7a20d4ad-9627-45ef-aca9-f4bd7c5771fd"), "E", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7078), "9E", 9, false },
                    { new Guid("e568d975-8775-4bb8-ab17-bfb357435e36"), "A", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(7083), "10A", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("04df85fb-6297-4820-b508-2a348432ffa7"), "Gold", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(5527), false },
                    { new Guid("dd951ff5-2db0-4b65-835c-f0ef6e5388f6"), "Unassigned", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(5541), false },
                    { new Guid("80435db6-5c7f-4f97-b583-f22891ae066b"), "Scarlet", new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(5540), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("60cbba69-48ea-4291-9978-97c729807a7d"), new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(8555), "G1", "G", 1, false },
                    { new Guid("396bcea9-c03d-4856-b61f-e8d0b2e67b66"), new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(8564), "G2", "G", 2, false },
                    { new Guid("0c41e7fe-2420-40bd-a4d6-512a470e4701"), new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(8566), "G3", "G", 3, false },
                    { new Guid("6fd973ff-1078-4764-bfaa-a380e8302035"), new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(8568), "G4", "G", 4, false },
                    { new Guid("d9feb70d-2582-4264-98e2-2e95747b8681"), new DateTime(2021, 9, 16, 14, 31, 6, 818, DateTimeKind.Local).AddTicks(8571), "G5", "G", 5, false }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentScreeningTemps_Students_StudentId",
                table: "StudentScreeningTemps",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}