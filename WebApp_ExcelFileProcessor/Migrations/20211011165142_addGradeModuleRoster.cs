using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class addGradeModuleRoster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("54b23384-08fd-42dc-9973-e814310da409"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("56682314-63c3-4997-9d18-64a8a45e0286"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("0587a4d9-7be6-45f7-b256-8916c5af55a3"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("387cd4ff-933e-4ab7-acaa-b6f28a8b0328"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("3dc31699-5d42-4687-9843-43e003625bab"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("691cdedf-8d2d-4b49-bb42-e724731623dc"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("74793dc4-e0be-426b-95fd-51a26f222a01"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("b105950d-abd6-4680-85fd-77a24b7ea9bc"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("c605ff4f-41cc-44f9-be6a-fe913d0fb2eb"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("ffe4760b-1218-48d3-aa73-4ecc62112689"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("041d3f51-235a-44d4-81a9-507d23a8270b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("09e0a5e5-7c79-47b5-8db9-3fdf50d93d98"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("232a04fd-6a11-434e-a403-3ab1e2d1d915"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("24ac92dd-0e83-4e1e-9f6b-4616c99a23ee"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("26d5f490-13c0-4116-979d-dc759b979909"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2fab2de9-0f16-4847-b71e-470897814fff"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("38b846b2-0501-4ad3-b6ad-6106f3ca9857"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("38ec7b19-4043-4a99-b289-6af75775a9a9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3c762a54-785b-4823-962c-07063d1fb505"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3dabd728-2793-4b03-8c73-ced0ad22dac5"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3f9ad489-f2ed-4268-9a96-a925de5f5b18"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("42e6e868-dfbd-45b1-bc39-2dc1fef4e228"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4e4bb89f-5463-4e68-997a-73b43313d379"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4e87d9e2-df5b-48d1-b1e5-90fc6725ad4c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("605d2200-c647-4048-b42d-6380dfc2e546"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("81150e22-8e8f-42f6-aa77-bd0dff08e3a5"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("89ec2781-dede-4c46-b4bd-6b2d6a90a5bc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8b6b99c1-ca81-4027-8a78-794989aaa534"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("988c71b3-8c8b-4370-823b-3e4272b79aef"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9a3d06b0-ef01-40dd-8763-fe822fe5210a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9d9576f9-760a-4f5a-89c6-4e2e7572f9d5"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a00e117a-e940-4343-8422-c4650a2bf150"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("acf89b08-fdb1-433a-a290-871d0c8064cd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b25e58d2-9de2-4d0b-ada6-208e29b9f06f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b387be03-15b8-4d00-85f4-d3f258df0021"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ceeed6b2-987d-492d-8642-2fe9d327e519"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d59d5f20-bd15-4af9-bdca-8d716c1a8ddf"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("dc284a54-53c7-4e9f-8d70-b98c3b12a365"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("de395678-9ecf-435e-ba73-42bf3fcd11fd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e25af776-8149-4058-8b6b-28aa3b846651"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e27762c6-4093-4257-ab47-2d12de3cc699"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e3ee9e11-cdab-4433-89df-0d95e8706d12"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e4512b53-0ee2-43e4-b959-aa7836772a0b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e4fc52aa-889f-4a8f-89f2-c3a04586404a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ecf9bb4c-f47d-48a9-9650-9ffa91d63b79"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("533a9ede-e23b-451a-835d-52454d013f2f"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("db7dd8ef-569a-4cd4-99dc-ee4700cd4dc5"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("db87c750-eb52-4e10-ab1e-0828f64de96b"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("41ab0b1b-bbbe-4385-8e05-81d5b0ae656b"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("80fb0695-40dd-4e5a-a84c-6124511d2a31"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("9ac6ee6c-7a97-455a-82e1-7b93a601f766"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("9cfa71c2-5e85-4a0a-8650-c6b5d79b82f3"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("d450dcc1-db31-46d9-b6ea-ad9157b0fd2f"));

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "cefc016d-d4b7-4b88-8639-d55023447999");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cc1d1fd-7422-4f3f-9087-b045dedd3540", "AQAAAAEAACcQAAAAEF4i9QXtuadbt4ekqFC57tAPFkPA8yghaB/bHwP4nRhAw94o33PGGqZ5oA5kv1fO+A==", "16e7c604-6d81-4590-bf07-c6570e879780" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("c3929ef7-6cd4-4957-a892-7abc21d6ca37"), new DateTime(2021, 10, 11, 18, 51, 41, 809, DateTimeKind.Local).AddTicks(5819), "F", "Female", false },
                    { new Guid("5d484318-ee5f-4ec4-8972-0608a034def2"), new DateTime(2021, 10, 11, 18, 51, 41, 810, DateTimeKind.Local).AddTicks(2402), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "ModuleCodes",
                columns: new[] { "ModuleCodeId", "DateCreated", "IsDeleted", "ModuleCodeName" },
                values: new object[,]
                {
                    { new Guid("eb81a9e4-d56c-4ebd-8689-7c9be4b8f9b8"), new DateTime(2021, 10, 11, 18, 51, 41, 820, DateTimeKind.Local).AddTicks(9280), false, "BASE" },
                    { new Guid("ca760eab-ae86-4cea-a880-5ba408fbc955"), new DateTime(2021, 10, 11, 18, 51, 41, 820, DateTimeKind.Local).AddTicks(9597), false, "LO" },
                    { new Guid("ae84a1d8-d278-4ee5-aa9d-08a1cc42747e"), new DateTime(2021, 10, 11, 18, 51, 41, 820, DateTimeKind.Local).AddTicks(9593), false, "AFR/XHO" },
                    { new Guid("8bbfbb5b-542a-4d4d-ba86-41a261da64cf"), new DateTime(2021, 10, 11, 18, 51, 41, 820, DateTimeKind.Local).AddTicks(9570), false, "MML" },
                    { new Guid("20a77051-477a-4c07-ad8f-a22c891fd56e"), new DateTime(2021, 10, 11, 18, 51, 41, 820, DateTimeKind.Local).AddTicks(9589), false, "ABCP" },
                    { new Guid("047a940e-a670-40cc-8b89-9e6af58916a6"), new DateTime(2021, 10, 11, 18, 51, 41, 820, DateTimeKind.Local).AddTicks(9581), false, "AGCLM" },
                    { new Guid("0eb871ec-b46f-4376-97d7-ef9bfc79ebac"), new DateTime(2021, 10, 11, 18, 51, 41, 820, DateTimeKind.Local).AddTicks(9579), false, "LHC" },
                    { new Guid("312038b9-3ccd-4f17-8048-2bf9241e23b7"), new DateTime(2021, 10, 11, 18, 51, 41, 820, DateTimeKind.Local).AddTicks(9591), false, "ENG" }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("bd8b0410-883d-437f-bcf5-b44f236ad638"), "F", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2340), "10F", 10, false },
                    { new Guid("88cb6bbd-0e85-4fe1-a551-c8e57287261f"), "G", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2342), "10G", 10, false },
                    { new Guid("8137bb5f-6c5c-4284-a88f-e19e9bcfb15b"), "A", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2343), "11A", 11, false },
                    { new Guid("0e8c6d3b-69ca-45db-932e-f122a09df30d"), "B", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2345), "11B", 11, false },
                    { new Guid("cc7e0b29-6002-43ff-8f82-d12200fea3d7"), "C", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2346), "11C", 11, false },
                    { new Guid("8ecdca64-342d-4c28-848e-6a8adfb2b6c8"), "D", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2348), "11D", 11, false },
                    { new Guid("a0afe2e4-2151-4c9e-b6a2-a1cd7f1e0069"), "E", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2349), "11E", 11, false },
                    { new Guid("76a0943f-e97f-471a-bf4c-c6fdd5ab1ed6"), "G", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2354), "11G", 11, false },
                    { new Guid("a0308417-1ba4-4e4a-979e-bc9eb7af5d16"), "A", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2356), "12A", 12, false },
                    { new Guid("b25b3de8-11ff-4fec-917a-2d6dadfe7c86"), "C", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2359), "12C", 12, false },
                    { new Guid("41d330ef-8fd8-42a8-bd18-c9503ea4e9a6"), "D", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2361), "12D", 12, false },
                    { new Guid("33b63700-b0f3-4acb-bb5b-e8e3d9d18e0e"), "E", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2362), "12E", 12, false },
                    { new Guid("4987caf3-92a5-4424-9776-7a070b482928"), "F", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2364), "12F", 12, false },
                    { new Guid("0b293f80-b0a7-4bd7-8ec4-3c21868fe4ca"), "G", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2367), "12G", 12, false },
                    { new Guid("2573fb00-b1be-41b9-8295-53320183b056"), "F", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2352), "11F", 11, false },
                    { new Guid("15efb8ef-a6b3-4933-add0-e4a732217186"), "B", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2357), "12B", 12, false },
                    { new Guid("71364c49-c81f-423d-8bfe-a8d8196c4f7b"), "E", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2338), "10E", 10, false },
                    { new Guid("70944d86-bac1-493b-a410-d7d7d2eb57de"), "B", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2330), "10B", 10, false },
                    { new Guid("ba1aafdc-2d2b-4978-beb5-399a711795d3"), "A", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2239), "8A", 8, false },
                    { new Guid("2da4c75d-37da-4593-a8e4-fa8ed8caf8d6"), "B", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2249), "8B", 8, false },
                    { new Guid("7720b4f4-d387-4e12-945d-84b78781a568"), "C", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2260), "8C", 8, false },
                    { new Guid("dcb29f3e-1d51-4c45-81aa-3f5caab4a9ac"), "C", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2332), "10C", 10, false },
                    { new Guid("267e12dc-f1a5-4dc5-99b5-660aa61ce3b9"), "E", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2308), "8E", 8, false },
                    { new Guid("37951335-908d-47a3-98c1-5ad2fc95b8f3"), "F", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2310), "8F", 8, false },
                    { new Guid("8f89643f-ce71-40fc-8814-eaa00f5a7f3c"), "G", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2312), "8G", 8, false },
                    { new Guid("a7383d26-e3e1-4334-8d07-be5c12e1cc3c"), "D", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2262), "8D", 8, false },
                    { new Guid("c34abd03-8a04-466c-9052-4fb8084550ef"), "B", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2315), "9B", 9, false },
                    { new Guid("b1000056-35d9-4c11-90c8-f0ec82eae7ef"), "A", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2313), "9A", 9, false },
                    { new Guid("253b497b-b36b-47aa-8918-094ce49f02b9"), "A", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2326), "10A", 10, false },
                    { new Guid("2f6e8b2e-55cb-4014-ac44-28bbf7a76e34"), "G", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2325), "9G", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("6095a2f5-37e8-4c85-85ea-de217c8193ae"), "D", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2334), "10D", 10, false },
                    { new Guid("520a81d6-d18d-4c61-bdd8-f3722c458df7"), "E", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2322), "9E", 9, false },
                    { new Guid("185fdb6b-4ec6-4755-812d-1b3951dba7b6"), "D", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2320), "9D", 9, false },
                    { new Guid("19d86afc-82f7-4756-a225-34e75fc4354d"), "C", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2316), "9C", 9, false },
                    { new Guid("3c0c4470-6f39-4d0f-8170-bec8208246c2"), "F", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(2323), "9F", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("1bc38b7f-d9fe-44e2-9910-e3839d111b0b"), "Gold", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(746), false },
                    { new Guid("ab063519-ce8c-45b7-bcdd-da8cd701e665"), "Unassigned", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(938), false },
                    { new Guid("d585dda2-9be9-4af4-a71d-957052fc0a1c"), "Scarlet", new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(936), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("1e42a78e-621e-45fe-bb8b-18ede62f420b"), new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(3629), "G1", "G", 1, false },
                    { new Guid("9107ac53-41f3-44da-a4a6-c447d88d0168"), new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(3639), "G2", "G", 2, false },
                    { new Guid("f826c40a-7293-4b1d-8ee4-d3a763b06fe9"), new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(3641), "G3", "G", 3, false },
                    { new Guid("95acb8c2-5d1b-4a6a-a874-1173be57fca0"), new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(3643), "G4", "G", 4, false },
                    { new Guid("523bd6a8-8e0d-4053-9e6f-00476d040179"), new DateTime(2021, 10, 11, 18, 51, 41, 811, DateTimeKind.Local).AddTicks(3644), "G5", "G", 5, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GradeModuleRoster_ModuleCodeId",
                table: "GradeModuleRoster",
                column: "ModuleCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GradeModuleRoster");

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("5d484318-ee5f-4ec4-8972-0608a034def2"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("c3929ef7-6cd4-4957-a892-7abc21d6ca37"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("047a940e-a670-40cc-8b89-9e6af58916a6"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("0eb871ec-b46f-4376-97d7-ef9bfc79ebac"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("20a77051-477a-4c07-ad8f-a22c891fd56e"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("312038b9-3ccd-4f17-8048-2bf9241e23b7"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("8bbfbb5b-542a-4d4d-ba86-41a261da64cf"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("ae84a1d8-d278-4ee5-aa9d-08a1cc42747e"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("ca760eab-ae86-4cea-a880-5ba408fbc955"));

            migrationBuilder.DeleteData(
                table: "ModuleCodes",
                keyColumn: "ModuleCodeId",
                keyValue: new Guid("eb81a9e4-d56c-4ebd-8689-7c9be4b8f9b8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("0b293f80-b0a7-4bd7-8ec4-3c21868fe4ca"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("0e8c6d3b-69ca-45db-932e-f122a09df30d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("15efb8ef-a6b3-4933-add0-e4a732217186"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("185fdb6b-4ec6-4755-812d-1b3951dba7b6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("19d86afc-82f7-4756-a225-34e75fc4354d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("253b497b-b36b-47aa-8918-094ce49f02b9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2573fb00-b1be-41b9-8295-53320183b056"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("267e12dc-f1a5-4dc5-99b5-660aa61ce3b9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2da4c75d-37da-4593-a8e4-fa8ed8caf8d6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2f6e8b2e-55cb-4014-ac44-28bbf7a76e34"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("33b63700-b0f3-4acb-bb5b-e8e3d9d18e0e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("37951335-908d-47a3-98c1-5ad2fc95b8f3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3c0c4470-6f39-4d0f-8170-bec8208246c2"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("41d330ef-8fd8-42a8-bd18-c9503ea4e9a6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4987caf3-92a5-4424-9776-7a070b482928"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("520a81d6-d18d-4c61-bdd8-f3722c458df7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6095a2f5-37e8-4c85-85ea-de217c8193ae"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("70944d86-bac1-493b-a410-d7d7d2eb57de"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("71364c49-c81f-423d-8bfe-a8d8196c4f7b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("76a0943f-e97f-471a-bf4c-c6fdd5ab1ed6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7720b4f4-d387-4e12-945d-84b78781a568"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8137bb5f-6c5c-4284-a88f-e19e9bcfb15b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("88cb6bbd-0e85-4fe1-a551-c8e57287261f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8ecdca64-342d-4c28-848e-6a8adfb2b6c8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8f89643f-ce71-40fc-8814-eaa00f5a7f3c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a0308417-1ba4-4e4a-979e-bc9eb7af5d16"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a0afe2e4-2151-4c9e-b6a2-a1cd7f1e0069"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a7383d26-e3e1-4334-8d07-be5c12e1cc3c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b1000056-35d9-4c11-90c8-f0ec82eae7ef"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b25b3de8-11ff-4fec-917a-2d6dadfe7c86"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ba1aafdc-2d2b-4978-beb5-399a711795d3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("bd8b0410-883d-437f-bcf5-b44f236ad638"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("c34abd03-8a04-466c-9052-4fb8084550ef"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("cc7e0b29-6002-43ff-8f82-d12200fea3d7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("dcb29f3e-1d51-4c45-81aa-3f5caab4a9ac"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("1bc38b7f-d9fe-44e2-9910-e3839d111b0b"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("ab063519-ce8c-45b7-bcdd-da8cd701e665"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("d585dda2-9be9-4af4-a71d-957052fc0a1c"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("1e42a78e-621e-45fe-bb8b-18ede62f420b"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("523bd6a8-8e0d-4053-9e6f-00476d040179"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("9107ac53-41f3-44da-a4a6-c447d88d0168"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("95acb8c2-5d1b-4a6a-a874-1173be57fca0"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("f826c40a-7293-4b1d-8ee4-d3a763b06fe9"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "ab63cede-0e23-4ffa-8538-467001dbc4ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16eef300-8acf-423e-8d3b-8d2e28a57e74", "AQAAAAEAACcQAAAAEO1CH79A7nCmWM43MEsRpaBrkOnS5PFp2ISjPdXdDCP28qXZGxagRunel0ahhBtyYw==", "5ce5367c-816f-4188-9d9a-808a5be88d7f" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("54b23384-08fd-42dc-9973-e814310da409"), new DateTime(2021, 10, 11, 18, 7, 20, 682, DateTimeKind.Local).AddTicks(7368), "F", "Female", false },
                    { new Guid("56682314-63c3-4997-9d18-64a8a45e0286"), new DateTime(2021, 10, 11, 18, 7, 20, 683, DateTimeKind.Local).AddTicks(4162), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "ModuleCodes",
                columns: new[] { "ModuleCodeId", "DateCreated", "IsDeleted", "ModuleCodeName" },
                values: new object[,]
                {
                    { new Guid("c605ff4f-41cc-44f9-be6a-fe913d0fb2eb"), new DateTime(2021, 10, 11, 18, 7, 20, 694, DateTimeKind.Local).AddTicks(787), false, "BASE" },
                    { new Guid("74793dc4-e0be-426b-95fd-51a26f222a01"), new DateTime(2021, 10, 11, 18, 7, 20, 694, DateTimeKind.Local).AddTicks(1114), false, "LO" },
                    { new Guid("3dc31699-5d42-4687-9843-43e003625bab"), new DateTime(2021, 10, 11, 18, 7, 20, 694, DateTimeKind.Local).AddTicks(1112), false, "AFR/XHO" },
                    { new Guid("387cd4ff-933e-4ab7-acaa-b6f28a8b0328"), new DateTime(2021, 10, 11, 18, 7, 20, 694, DateTimeKind.Local).AddTicks(1084), false, "MML" },
                    { new Guid("b105950d-abd6-4680-85fd-77a24b7ea9bc"), new DateTime(2021, 10, 11, 18, 7, 20, 694, DateTimeKind.Local).AddTicks(1104), false, "ABCP" },
                    { new Guid("0587a4d9-7be6-45f7-b256-8916c5af55a3"), new DateTime(2021, 10, 11, 18, 7, 20, 694, DateTimeKind.Local).AddTicks(1095), false, "AGCLM" },
                    { new Guid("691cdedf-8d2d-4b49-bb42-e724731623dc"), new DateTime(2021, 10, 11, 18, 7, 20, 694, DateTimeKind.Local).AddTicks(1093), false, "LHC" },
                    { new Guid("ffe4760b-1218-48d3-aa73-4ecc62112689"), new DateTime(2021, 10, 11, 18, 7, 20, 694, DateTimeKind.Local).AddTicks(1110), false, "ENG" }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("3dabd728-2793-4b03-8c73-ced0ad22dac5"), "F", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4056), "10F", 10, false },
                    { new Guid("2fab2de9-0f16-4847-b71e-470897814fff"), "G", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4058), "10G", 10, false },
                    { new Guid("232a04fd-6a11-434e-a403-3ab1e2d1d915"), "A", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4059), "11A", 11, false },
                    { new Guid("e27762c6-4093-4257-ab47-2d12de3cc699"), "B", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4061), "11B", 11, false },
                    { new Guid("e3ee9e11-cdab-4433-89df-0d95e8706d12"), "C", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4063), "11C", 11, false },
                    { new Guid("a00e117a-e940-4343-8422-c4650a2bf150"), "D", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4064), "11D", 11, false },
                    { new Guid("e4512b53-0ee2-43e4-b959-aa7836772a0b"), "E", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4066), "11E", 11, false },
                    { new Guid("38ec7b19-4043-4a99-b289-6af75775a9a9"), "G", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4071), "11G", 11, false },
                    { new Guid("acf89b08-fdb1-433a-a290-871d0c8064cd"), "A", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4072), "12A", 12, false },
                    { new Guid("26d5f490-13c0-4116-979d-dc759b979909"), "C", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4076), "12C", 12, false },
                    { new Guid("ceeed6b2-987d-492d-8642-2fe9d327e519"), "D", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4077), "12D", 12, false },
                    { new Guid("3c762a54-785b-4823-962c-07063d1fb505"), "E", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4079), "12E", 12, false },
                    { new Guid("d59d5f20-bd15-4af9-bdca-8d716c1a8ddf"), "F", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4081), "12F", 12, false },
                    { new Guid("8b6b99c1-ca81-4027-8a78-794989aaa534"), "G", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4084), "12G", 12, false },
                    { new Guid("de395678-9ecf-435e-ba73-42bf3fcd11fd"), "F", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4069), "11F", 11, false },
                    { new Guid("041d3f51-235a-44d4-81a9-507d23a8270b"), "B", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4074), "12B", 12, false },
                    { new Guid("9a3d06b0-ef01-40dd-8763-fe822fe5210a"), "E", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4055), "10E", 10, false },
                    { new Guid("9d9576f9-760a-4f5a-89c6-4e2e7572f9d5"), "B", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4047), "10B", 10, false },
                    { new Guid("e25af776-8149-4058-8b6b-28aa3b846651"), "A", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4003), "8A", 8, false },
                    { new Guid("b25e58d2-9de2-4d0b-ada6-208e29b9f06f"), "B", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4013), "8B", 8, false },
                    { new Guid("3f9ad489-f2ed-4268-9a96-a925de5f5b18"), "C", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4023), "8C", 8, false },
                    { new Guid("89ec2781-dede-4c46-b4bd-6b2d6a90a5bc"), "C", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4050), "10C", 10, false },
                    { new Guid("09e0a5e5-7c79-47b5-8db9-3fdf50d93d98"), "E", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4026), "8E", 8, false },
                    { new Guid("b387be03-15b8-4d00-85f4-d3f258df0021"), "F", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4028), "8F", 8, false },
                    { new Guid("38b846b2-0501-4ad3-b6ad-6106f3ca9857"), "G", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4030), "8G", 8, false },
                    { new Guid("42e6e868-dfbd-45b1-bc39-2dc1fef4e228"), "D", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4025), "8D", 8, false },
                    { new Guid("dc284a54-53c7-4e9f-8d70-b98c3b12a365"), "B", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4034), "9B", 9, false },
                    { new Guid("ecf9bb4c-f47d-48a9-9650-9ffa91d63b79"), "A", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4032), "9A", 9, false },
                    { new Guid("4e4bb89f-5463-4e68-997a-73b43313d379"), "A", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4046), "10A", 10, false },
                    { new Guid("24ac92dd-0e83-4e1e-9f6b-4616c99a23ee"), "G", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4044), "9G", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("e4fc52aa-889f-4a8f-89f2-c3a04586404a"), "D", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4051), "10D", 10, false },
                    { new Guid("605d2200-c647-4048-b42d-6380dfc2e546"), "E", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4041), "9E", 9, false },
                    { new Guid("4e87d9e2-df5b-48d1-b1e5-90fc6725ad4c"), "D", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4039), "9D", 9, false },
                    { new Guid("988c71b3-8c8b-4370-823b-3e4272b79aef"), "C", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4035), "9C", 9, false },
                    { new Guid("81150e22-8e8f-42f6-aa77-bd0dff08e3a5"), "F", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(4042), "9F", 9, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("db7dd8ef-569a-4cd4-99dc-ee4700cd4dc5"), "Gold", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(2672), false },
                    { new Guid("533a9ede-e23b-451a-835d-52454d013f2f"), "Unassigned", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(2687), false },
                    { new Guid("db87c750-eb52-4e10-ab1e-0828f64de96b"), "Scarlet", new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(2685), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("9ac6ee6c-7a97-455a-82e1-7b93a601f766"), new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(5346), "G1", "G", 1, false },
                    { new Guid("9cfa71c2-5e85-4a0a-8650-c6b5d79b82f3"), new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(5355), "G2", "G", 2, false },
                    { new Guid("80fb0695-40dd-4e5a-a84c-6124511d2a31"), new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(5358), "G3", "G", 3, false },
                    { new Guid("41ab0b1b-bbbe-4385-8e05-81d5b0ae656b"), new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(5359), "G4", "G", 4, false },
                    { new Guid("d450dcc1-db31-46d9-b6ea-ad9157b0fd2f"), new DateTime(2021, 10, 11, 18, 7, 20, 684, DateTimeKind.Local).AddTicks(5361), "G5", "G", 5, false }
                });
        }
    }
}
