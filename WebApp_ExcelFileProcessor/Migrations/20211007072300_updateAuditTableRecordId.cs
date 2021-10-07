using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class updateAuditTableRecordId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("aaa99a57-20fa-45e5-8ca0-ee3873b01311"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("cabbb2bf-6bc2-413d-9b25-e757464fbbb5"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("001ec092-ad39-4c85-9cd2-bd8e43df18e7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("0433f0b9-836e-4f6b-9ad0-249825f16eb9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("044ca0fa-4ba0-4037-8231-6b62ded5b6e3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("09647e48-50a3-450f-9343-3a682c403968"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("0d0e2dfb-d520-4e51-b1f7-f19a131a1647"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("148c0830-eac6-450a-9325-a681b7fca775"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("15e1d3f9-f3cb-407a-a03b-4d9918fa3882"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("26e7f03c-eb47-4be5-9a4c-d53f04b1a41a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("29515578-b3ad-46f2-908c-036a5ab8049e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2edcae52-a575-4e6f-a8ae-561a2fcc4f15"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2f48d01d-9acc-4d5d-9730-771882abccb8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("333f9b8c-57bf-4236-8912-417ad81bdfe9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3cf07515-82c0-4ddb-811b-f6f011cda771"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("41150ef2-d741-47cc-bd32-7e63c33640f1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("485fcb8e-8ead-4cce-9b4e-c71296487760"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("50ad4d08-8311-4c25-af90-a4f43a8f4bd1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5abe5780-155e-4fdc-b791-6adbdce0ac1a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6971e027-e2f9-4d53-8ca4-91ce3cface58"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("76b929e7-a46e-45d6-9b84-182cf7f84528"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7c1ad9bf-b364-4d66-858d-30cdeaf00970"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("85aef6a0-fbb1-4f51-ac0c-ea6f8ba38837"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("885ec89b-96e7-4859-9971-a578a4c71d47"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("89897538-fb3e-4641-b15a-3bc218d23acc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8d9d7bf3-4a16-481a-b515-619ad9a5624d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a8e08e3f-3870-4c4f-817a-27fab4723e3f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b680716c-7b90-4a83-a532-5619d4c597da"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ba429a71-7a60-4cac-9ef9-9c1906f6fcb1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("c4674379-bc0f-44a1-9719-93e53e48df5c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("cad5b72a-16e5-49e2-8836-a18fa2692f27"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("de410e8d-b81f-4130-bf38-984dc3627f0c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e428e9a4-95dc-48c0-8f48-5a0531bdd431"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e527890c-c94a-4f08-a915-7d698bdcc91f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ecc80468-9aee-49f9-a38d-2ea38ffccd4d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f0e92d18-42a0-4658-8282-5279a160d162"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f98361fa-2761-4fb3-8d28-d06d39a10bf1"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("09e3fcd7-e937-4304-a49c-9265a3f0b662"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("7093e02b-4428-4634-b443-0df26263c1c9"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("b96c32b5-a62f-4728-9c61-2ee68df3f524"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("1f173725-4d66-4b42-a016-de218d660289"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("a7d1e91c-424b-4a38-bed7-ae69d554848b"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("d8c34f2e-a551-4b9f-933e-ee5a479bdd25"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("e73a7e8d-4387-4ed4-bd1f-2938e6218370"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("eea427eb-acb9-418b-8a45-c1f8a0c89271"));

            migrationBuilder.AlterColumn<string>(
                name: "RecordId",
                table: "Audits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "a6d2be8c-86ea-47fb-993e-31b23e57659a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e987e338-72fb-46e2-bd3e-3a14f89eb005", "AQAAAAEAACcQAAAAEDNu98TAYndaIH69Ki4j5XoCaZH1VNnj0NjdAzb0Ss32OYyKfwFYzvrdxi0brNNDxA==", "47413dbd-cf23-4c5e-9744-7f8d3134334b" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("af157aba-b73c-4874-a961-daa9e9027b88"), new DateTime(2021, 10, 7, 9, 22, 59, 104, DateTimeKind.Local).AddTicks(887), "F", "Female", false },
                    { new Guid("fecf3738-c81a-4f9a-b83b-bf69b2eb18d4"), new DateTime(2021, 10, 7, 9, 22, 59, 105, DateTimeKind.Local).AddTicks(1391), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("105abe23-d110-4dfb-83d8-61d1e1dc3033"), "B", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6420), "8B", 8, false },
                    { new Guid("85a48683-43f8-4c85-9f89-23b22d2d88bd"), "A", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6402), "8A", 8, false },
                    { new Guid("66255311-a2c1-4483-b661-a9b5ca7a6ce9"), "C", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6497), "11C", 11, false },
                    { new Guid("33ed77ea-8bcd-4e80-a1b9-3b99a3d45306"), "D", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6500), "11D", 11, false },
                    { new Guid("60464fcd-c0e1-4fd4-9d30-8e6c14ef1ad0"), "E", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6502), "11E", 11, false },
                    { new Guid("21cb25d8-001e-442c-8a92-3de6e5314d1f"), "F", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6507), "11F", 11, false },
                    { new Guid("67c775b6-c1bb-483b-b663-665fa10ada20"), "G", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6490), "10G", 10, false },
                    { new Guid("b6fa2413-97b2-43ae-9357-64777e6d684d"), "G", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6510), "11G", 11, false },
                    { new Guid("a55382db-71a3-4dc8-86a3-46e92c9a7a97"), "B", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6515), "12B", 12, false },
                    { new Guid("447199b7-b762-48af-916b-acdf96640732"), "C", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6517), "12C", 12, false },
                    { new Guid("57ffed2e-2510-4fe6-85d8-884eca290a63"), "D", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6520), "12D", 12, false },
                    { new Guid("54d48e28-c483-417e-9505-2a71db411a1c"), "E", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6523), "12E", 12, false },
                    { new Guid("411c6bae-f414-47ce-b9f7-aa350bf0d368"), "F", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6525), "12F", 12, false },
                    { new Guid("5b9809f3-f735-4c94-9cf1-79ad7f4a6fb8"), "G", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6530), "12G", 12, false },
                    { new Guid("454b3e8b-bb7d-4431-9dd9-bde03f03cc90"), "A", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6512), "12A", 12, false },
                    { new Guid("517b0c32-0388-45b2-a11d-1baf5571dece"), "F", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6487), "10F", 10, false },
                    { new Guid("a82eb39f-6acb-4a0e-9b90-f52c028182d7"), "B", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6495), "11B", 11, false },
                    { new Guid("4d606516-c35b-4670-a4e4-35441d0fbac3"), "D", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6480), "10D", 10, false },
                    { new Guid("4c76bc16-5330-4221-917f-5cc0d4021e51"), "C", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6435), "8C", 8, false },
                    { new Guid("88fd2e15-c2e4-4e49-82ed-d2c253dc3569"), "D", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6439), "8D", 8, false },
                    { new Guid("e4b52b21-9024-4d95-82e9-ee9d59893a2b"), "E", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6442), "8E", 8, false },
                    { new Guid("e864fa48-7f19-4d87-8e27-03bd3f1b5f8a"), "E", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6485), "10E", 10, false },
                    { new Guid("8d9f95ba-4ecf-41ef-a662-8a0747937b7f"), "G", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6447), "8G", 8, false },
                    { new Guid("4c9e9786-b16f-40a7-b477-09b4d27bf728"), "A", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6449), "9A", 9, false },
                    { new Guid("79db6c24-a597-4aa6-97ab-712a1b71b6cd"), "B", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6452), "9B", 9, false },
                    { new Guid("46d49c5a-0137-4adc-b67d-0837abfc4aa6"), "F", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6445), "8F", 8, false },
                    { new Guid("34d26550-0604-4e2a-8ce9-7b304e2f8a02"), "D", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6461), "9D", 9, false },
                    { new Guid("8696cf0e-2992-4efb-8b9f-fd87699ac9fc"), "C", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6455), "9C", 9, false },
                    { new Guid("56a20980-28c1-45bb-8a1f-bf55bb81fd9f"), "C", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6477), "10C", 10, false },
                    { new Guid("b49764ab-dd25-4a85-aa28-96b23abb3fdb"), "B", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6474), "10B", 10, false },
                    { new Guid("3ec99818-2a10-40d8-aee3-47549c093935"), "A", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6492), "11A", 11, false },
                    { new Guid("bc8315e5-6680-4e57-aedf-3aaf3c3cd76a"), "G", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6469), "9G", 9, false },
                    { new Guid("e6bd0523-ffc7-4bc7-88c3-829b131a27c6"), "F", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6466), "9F", 9, false },
                    { new Guid("363eb3bf-f84a-475e-95af-7559ccd16f4e"), "E", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6463), "9E", 9, false },
                    { new Guid("d69fe65d-e86a-4374-9770-5d8cba9b067f"), "A", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(6471), "10A", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("5e56bf94-f00e-47e7-a7f4-d92b98dea228"), "Gold", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(4314), false },
                    { new Guid("56439ded-eff4-4838-8fbc-4528dc41ed17"), "Unassigned", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(4343), false },
                    { new Guid("9b98352c-a32d-45fa-a69b-783d50ae38c1"), "Scarlet", new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(4339), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("6ccb77be-5eb7-4107-9445-50aeb599474d"), new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(8803), "G1", "G", 1, false },
                    { new Guid("662b1b4b-ea8d-449c-a522-2949e40207f4"), new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(8818), "G2", "G", 2, false },
                    { new Guid("0a6427ba-fe30-46cb-976d-b450863dfdf0"), new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(8822), "G3", "G", 3, false },
                    { new Guid("5b849b78-b5b5-41f6-8da7-a1c6d0a095ae"), new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(8824), "G4", "G", 4, false },
                    { new Guid("5d20b15c-fc2c-4dbe-9c6e-8876d07670b0"), new DateTime(2021, 10, 7, 9, 22, 59, 106, DateTimeKind.Local).AddTicks(8826), "G5", "G", 5, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("af157aba-b73c-4874-a961-daa9e9027b88"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("fecf3738-c81a-4f9a-b83b-bf69b2eb18d4"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("105abe23-d110-4dfb-83d8-61d1e1dc3033"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("21cb25d8-001e-442c-8a92-3de6e5314d1f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("33ed77ea-8bcd-4e80-a1b9-3b99a3d45306"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("34d26550-0604-4e2a-8ce9-7b304e2f8a02"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("363eb3bf-f84a-475e-95af-7559ccd16f4e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3ec99818-2a10-40d8-aee3-47549c093935"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("411c6bae-f414-47ce-b9f7-aa350bf0d368"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("447199b7-b762-48af-916b-acdf96640732"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("454b3e8b-bb7d-4431-9dd9-bde03f03cc90"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("46d49c5a-0137-4adc-b67d-0837abfc4aa6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4c76bc16-5330-4221-917f-5cc0d4021e51"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4c9e9786-b16f-40a7-b477-09b4d27bf728"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4d606516-c35b-4670-a4e4-35441d0fbac3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("517b0c32-0388-45b2-a11d-1baf5571dece"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("54d48e28-c483-417e-9505-2a71db411a1c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("56a20980-28c1-45bb-8a1f-bf55bb81fd9f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("57ffed2e-2510-4fe6-85d8-884eca290a63"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5b9809f3-f735-4c94-9cf1-79ad7f4a6fb8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("60464fcd-c0e1-4fd4-9d30-8e6c14ef1ad0"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("66255311-a2c1-4483-b661-a9b5ca7a6ce9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("67c775b6-c1bb-483b-b663-665fa10ada20"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("79db6c24-a597-4aa6-97ab-712a1b71b6cd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("85a48683-43f8-4c85-9f89-23b22d2d88bd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8696cf0e-2992-4efb-8b9f-fd87699ac9fc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("88fd2e15-c2e4-4e49-82ed-d2c253dc3569"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8d9f95ba-4ecf-41ef-a662-8a0747937b7f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a55382db-71a3-4dc8-86a3-46e92c9a7a97"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a82eb39f-6acb-4a0e-9b90-f52c028182d7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b49764ab-dd25-4a85-aa28-96b23abb3fdb"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b6fa2413-97b2-43ae-9357-64777e6d684d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("bc8315e5-6680-4e57-aedf-3aaf3c3cd76a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d69fe65d-e86a-4374-9770-5d8cba9b067f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e4b52b21-9024-4d95-82e9-ee9d59893a2b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e6bd0523-ffc7-4bc7-88c3-829b131a27c6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e864fa48-7f19-4d87-8e27-03bd3f1b5f8a"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("56439ded-eff4-4838-8fbc-4528dc41ed17"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("5e56bf94-f00e-47e7-a7f4-d92b98dea228"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("9b98352c-a32d-45fa-a69b-783d50ae38c1"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("0a6427ba-fe30-46cb-976d-b450863dfdf0"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("5b849b78-b5b5-41f6-8da7-a1c6d0a095ae"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("5d20b15c-fc2c-4dbe-9c6e-8876d07670b0"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("662b1b4b-ea8d-449c-a522-2949e40207f4"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("6ccb77be-5eb7-4107-9445-50aeb599474d"));

            migrationBuilder.AlterColumn<Guid>(
                name: "RecordId",
                table: "Audits",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "ed5c6932-81be-45f5-bf73-b0d31ccdc556");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d456ea3-39f6-4a7a-af9a-086e33648902", "AQAAAAEAACcQAAAAEBVVpML9P8oKrDNQ/X9oAhIVpkEaTxa1g5mS+2dnmCvDUE59DJ+3FH3ilSepyLiBYw==", "2394b172-425e-46d1-8d90-11d79100cc62" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("cabbb2bf-6bc2-413d-9b25-e757464fbbb5"), new DateTime(2021, 10, 7, 8, 57, 29, 386, DateTimeKind.Local).AddTicks(6067), "F", "Female", false },
                    { new Guid("aaa99a57-20fa-45e5-8ca0-ee3873b01311"), new DateTime(2021, 10, 7, 8, 57, 29, 387, DateTimeKind.Local).AddTicks(6578), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("8d9d7bf3-4a16-481a-b515-619ad9a5624d"), "B", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local), "8B", 8, false },
                    { new Guid("cad5b72a-16e5-49e2-8836-a18fa2692f27"), "A", new DateTime(2021, 10, 7, 8, 57, 29, 388, DateTimeKind.Local).AddTicks(9979), "8A", 8, false },
                    { new Guid("de410e8d-b81f-4130-bf38-984dc3627f0c"), "C", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(102), "11C", 11, false },
                    { new Guid("26e7f03c-eb47-4be5-9a4c-d53f04b1a41a"), "D", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(107), "11D", 11, false },
                    { new Guid("6971e027-e2f9-4d53-8ca4-91ce3cface58"), "E", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(111), "11E", 11, false },
                    { new Guid("a8e08e3f-3870-4c4f-817a-27fab4723e3f"), "F", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(114), "11F", 11, false },
                    { new Guid("e527890c-c94a-4f08-a915-7d698bdcc91f"), "G", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(92), "10G", 10, false },
                    { new Guid("f98361fa-2761-4fb3-8d28-d06d39a10bf1"), "G", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(120), "11G", 11, false },
                    { new Guid("2edcae52-a575-4e6f-a8ae-561a2fcc4f15"), "B", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(126), "12B", 12, false },
                    { new Guid("044ca0fa-4ba0-4037-8231-6b62ded5b6e3"), "C", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(130), "12C", 12, false },
                    { new Guid("b680716c-7b90-4a83-a532-5619d4c597da"), "D", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(134), "12D", 12, false },
                    { new Guid("41150ef2-d741-47cc-bd32-7e63c33640f1"), "E", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(137), "12E", 12, false },
                    { new Guid("0433f0b9-836e-4f6b-9ad0-249825f16eb9"), "F", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(141), "12F", 12, false },
                    { new Guid("c4674379-bc0f-44a1-9719-93e53e48df5c"), "G", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(144), "12G", 12, false },
                    { new Guid("ba429a71-7a60-4cac-9ef9-9c1906f6fcb1"), "A", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(123), "12A", 12, false },
                    { new Guid("001ec092-ad39-4c85-9cd2-bd8e43df18e7"), "F", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(89), "10F", 10, false },
                    { new Guid("485fcb8e-8ead-4cce-9b4e-c71296487760"), "B", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(99), "11B", 11, false },
                    { new Guid("50ad4d08-8311-4c25-af90-a4f43a8f4bd1"), "D", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(79), "10D", 10, false },
                    { new Guid("85aef6a0-fbb1-4f51-ac0c-ea6f8ba38837"), "C", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(4), "8C", 8, false },
                    { new Guid("29515578-b3ad-46f2-908c-036a5ab8049e"), "D", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(19), "8D", 8, false },
                    { new Guid("885ec89b-96e7-4859-9971-a578a4c71d47"), "E", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(23), "8E", 8, false },
                    { new Guid("148c0830-eac6-450a-9325-a681b7fca775"), "E", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(82), "10E", 10, false },
                    { new Guid("89897538-fb3e-4641-b15a-3bc218d23acc"), "G", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(33), "8G", 8, false },
                    { new Guid("0d0e2dfb-d520-4e51-b1f7-f19a131a1647"), "A", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(37), "9A", 9, false },
                    { new Guid("f0e92d18-42a0-4658-8282-5279a160d162"), "B", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(41), "9B", 9, false },
                    { new Guid("2f48d01d-9acc-4d5d-9730-771882abccb8"), "F", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(26), "8F", 8, false },
                    { new Guid("333f9b8c-57bf-4236-8912-417ad81bdfe9"), "D", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(48), "9D", 9, false },
                    { new Guid("76b929e7-a46e-45d6-9b84-182cf7f84528"), "C", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(45), "9C", 9, false },
                    { new Guid("7c1ad9bf-b364-4d66-858d-30cdeaf00970"), "C", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(76), "10C", 10, false },
                    { new Guid("e428e9a4-95dc-48c0-8f48-5a0531bdd431"), "B", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(72), "10B", 10, false },
                    { new Guid("09647e48-50a3-450f-9343-3a682c403968"), "A", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(96), "11A", 11, false },
                    { new Guid("15e1d3f9-f3cb-407a-a03b-4d9918fa3882"), "G", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(64), "9G", 9, false },
                    { new Guid("5abe5780-155e-4fdc-b791-6adbdce0ac1a"), "F", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(60), "9F", 9, false },
                    { new Guid("ecc80468-9aee-49f9-a38d-2ea38ffccd4d"), "E", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(56), "9E", 9, false },
                    { new Guid("3cf07515-82c0-4ddb-811b-f6f011cda771"), "A", new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(68), "10A", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("09e3fcd7-e937-4304-a49c-9265a3f0b662"), "Gold", new DateTime(2021, 10, 7, 8, 57, 29, 388, DateTimeKind.Local).AddTicks(8130), false },
                    { new Guid("b96c32b5-a62f-4728-9c61-2ee68df3f524"), "Unassigned", new DateTime(2021, 10, 7, 8, 57, 29, 388, DateTimeKind.Local).AddTicks(8151), false },
                    { new Guid("7093e02b-4428-4634-b443-0df26263c1c9"), "Scarlet", new DateTime(2021, 10, 7, 8, 57, 29, 388, DateTimeKind.Local).AddTicks(8148), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("eea427eb-acb9-418b-8a45-c1f8a0c89271"), new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(2383), "G1", "G", 1, false },
                    { new Guid("d8c34f2e-a551-4b9f-933e-ee5a479bdd25"), new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(2511), "G2", "G", 2, false },
                    { new Guid("a7d1e91c-424b-4a38-bed7-ae69d554848b"), new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(2514), "G3", "G", 3, false },
                    { new Guid("e73a7e8d-4387-4ed4-bd1f-2938e6218370"), new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(2516), "G4", "G", 4, false },
                    { new Guid("1f173725-4d66-4b42-a016-de218d660289"), new DateTime(2021, 10, 7, 8, 57, 29, 389, DateTimeKind.Local).AddTicks(2518), "G5", "G", 5, false }
                });
        }
    }
}
