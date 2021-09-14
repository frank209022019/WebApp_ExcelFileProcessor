using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class allowNullsStudentTemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentTemps_Genders_GenderId",
                table: "StudentTemps");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTemps_StudentClasses_StudentClassId",
                table: "StudentTemps");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTemps_StudentColors_StudentColorId",
                table: "StudentTemps");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTemps_StudentGroups_StudentGroupId",
                table: "StudentTemps");

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("2fef4204-344a-48be-82ba-4acfcebacb4e"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("e2faf3fd-85bd-4444-b49b-a76d258eeb53"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("10460e0e-5750-4956-9258-a2a0f7692f71"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("147574c4-f652-4bd4-9054-0140e4839088"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("263630e8-fb37-473e-bcbf-a0748ae81990"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("26729663-d062-43d9-b81e-5efa30c8178d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2794a3ca-beca-44d4-b279-991ced4de48c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2917af15-88d0-4d9c-838d-46abda684c91"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2a842127-357c-4cac-bf80-96467cf21122"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("387e5659-96e6-4b37-a5fc-d0851c98cb77"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3e8db05c-c5fe-4a2b-98eb-2054ca0b0609"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3f6ad0a5-d462-4866-b678-5ba3f7b70483"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3feecbdf-1e5b-4b13-b229-bb2a9e47785b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("44b27aec-c3ba-40a4-8f42-b41345f2e111"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("48971a93-6fa2-4728-9ab7-fd7de943d587"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4aff3f1b-b8fc-4e06-b20d-da81a1709dc7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4c35498f-0423-40c2-a014-bfacf1bb9e3b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("536948ff-9442-4946-bbd5-1a8541e69376"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6d9edf7e-9947-4ca6-b926-10473fcd7863"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("70283a29-3797-407c-8187-d108fae25cc1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("739267dd-d115-42f9-9bb9-f57c4c9682b7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("79c91924-45ee-477c-9ba7-0e25204b7109"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7ee64972-92f6-4fb4-94ee-e8330acfd0bd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7f3de78c-5731-4afe-bfa0-a85926b81b43"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("835a09d7-cf33-4bfd-9b9a-10aee2f10bc2"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("87dbad9c-0d8d-4d3e-b9e4-daa38f5e7ea3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a84b91dd-3935-438d-a7d0-323d1c749c6f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ae32c125-3daf-44e1-8c0a-148775c9b1b6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b823a31a-eeeb-4f6f-b81f-5ac10ba450bb"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("bb8232bb-fada-42fd-b1d8-d28ce1219300"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("bd9a7165-3fb0-4cbe-8c84-f6ce7ecfe452"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d05dcfa2-6498-48c1-ae6e-d98191b3dc1a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d7c20edc-cd28-4692-a497-2becda6292b6"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d93be269-866a-4aa2-acb0-2e382e9056ff"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e9089b8f-a728-4fc5-b88d-e0888b4daa44"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f54215a6-83d0-4d94-bbef-11a18919c901"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fd110450-f61b-4d56-b795-58e316f55118"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("4806b1f3-9bef-4204-98b0-ca6521d0375c"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("68344e92-1ff4-4ee3-9c4f-029ef7a5cc2a"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("b15da3a0-e97f-4e32-b09f-73945d1e363e"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("1ce5a107-bb19-4fa2-80db-5479de93fe67"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("2a2dd538-beda-4c77-bdb0-684db17f72c6"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("4b32ed04-8fa0-45c1-8fba-7071a2aabcf9"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("9bb5f7d2-729e-4a58-8d90-a47dfd452b04"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("b2ae0335-b5c8-4db3-a683-9458394ebe9f"));

            migrationBuilder.AlterColumn<int>(
                name: "StudentNr",
                table: "StudentTemps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentGroupId",
                table: "StudentTemps",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentColorId",
                table: "StudentTemps",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentClassId",
                table: "StudentTemps",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "RowType",
                table: "StudentTemps",
                type: "nvarchar(1)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<int>(
                name: "RowNumber",
                table: "StudentTemps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "GenderId",
                table: "StudentTemps",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "de4548c7-7acc-4e29-9ee8-7261554f9774");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17703ffa-15c6-43aa-9377-15195bf23e66", "AQAAAAEAACcQAAAAECosPG8599YzdrXxhLtBgLGCXp/jzjvGe8qPKNPNNpSNhff2SZFubYyCCJt3SAjaPg==", "e71e62ff-b4e1-4a50-b2f0-5a8e4fae7c73" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("68d927b8-26fd-4bc8-b793-cdb85dbc2032"), new DateTime(2021, 9, 14, 10, 2, 4, 639, DateTimeKind.Local).AddTicks(7433), "F", "Female", false },
                    { new Guid("308d7267-a088-4114-8882-3b3673003f78"), new DateTime(2021, 9, 14, 10, 2, 4, 641, DateTimeKind.Local).AddTicks(3022), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("974df766-48ad-4520-8899-2125f8469d72"), "B", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4007), "8B", 8, false },
                    { new Guid("852734c2-882a-4b14-95a6-80dc6895f6d3"), "A", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(3990), "8A", 8, false },
                    { new Guid("74fad946-c025-4ed3-9ec7-60145615f1b1"), "C", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4072), "11C", 11, false },
                    { new Guid("4b4d0d36-e36b-4eff-9c29-194f5c40f82f"), "D", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4074), "11D", 11, false },
                    { new Guid("0f6e87f2-f537-439f-b1ec-4642f39c9de7"), "E", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4076), "11E", 11, false },
                    { new Guid("d33f1411-60fa-48f2-a939-302c8f14abc2"), "F", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4078), "11F", 11, false },
                    { new Guid("b7bf74b5-878c-4a89-a24a-c13ed507d8f1"), "G", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4066), "10G", 10, false },
                    { new Guid("440e728f-ed5a-4848-bb89-99b492c74c4d"), "G", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4082), "11G", 11, false },
                    { new Guid("ce78ff12-1cdd-49a5-a8f6-05ac4b353baa"), "B", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4086), "12B", 12, false },
                    { new Guid("61c0782f-9071-43ac-8652-6f1f8799d4f2"), "C", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4147), "12C", 12, false },
                    { new Guid("6541afa9-f521-4453-9e80-ac38d9c6d412"), "D", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4150), "12D", 12, false },
                    { new Guid("acf24741-4b6c-45cd-a376-f5be8f7f2aee"), "E", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4152), "12E", 12, false },
                    { new Guid("d90c4391-9a54-41aa-bfa4-a8851ae36da8"), "F", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4154), "12F", 12, false },
                    { new Guid("a602e1d1-5c5f-4841-a3e0-51914b761328"), "G", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4156), "12G", 12, false },
                    { new Guid("3cbe58b7-8d18-48e4-bd54-16e6eb571835"), "A", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4084), "12A", 12, false },
                    { new Guid("9ac34876-ac08-42ac-9272-c8d7dae6bb2b"), "F", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4064), "10F", 10, false },
                    { new Guid("b9b0f7a4-0020-42d6-ab8c-730a580f49e1"), "B", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4070), "11B", 11, false },
                    { new Guid("19e8b25e-65ab-4156-bfd7-26ecdb05f3f8"), "D", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4058), "10D", 10, false },
                    { new Guid("3bec44a6-4d28-42ab-aa02-d0d67be12941"), "C", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4010), "8C", 8, false },
                    { new Guid("e0492ec4-8b59-4047-ac05-efb051786d02"), "D", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4026), "8D", 8, false },
                    { new Guid("a95bb52d-a117-4d15-a0b6-e4fbd594e0ff"), "E", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4029), "8E", 8, false },
                    { new Guid("7fc4b149-dcba-45c9-adfd-8f4d13dc1af5"), "E", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4060), "10E", 10, false },
                    { new Guid("36494d8b-c611-4f9e-bcec-fc4e95ab7e60"), "G", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4033), "8G", 8, false },
                    { new Guid("4a493df2-2bb6-4131-a4cf-2b70d5450043"), "A", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4035), "9A", 9, false },
                    { new Guid("f79181ad-054b-411a-9506-807ca583c431"), "B", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4037), "9B", 9, false },
                    { new Guid("bddd0c93-65ce-4bc2-9c25-ebd6a7b8b4eb"), "F", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4031), "8F", 8, false },
                    { new Guid("ac07596e-7340-4faf-8120-6009be3db540"), "D", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4041), "9D", 9, false },
                    { new Guid("816b89ce-a676-4883-a6cb-a02ecbe3b699"), "C", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4039), "9C", 9, false },
                    { new Guid("672dd376-80d7-4c46-9817-66ff76e4f9cb"), "C", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4056), "10C", 10, false },
                    { new Guid("1dfeaa34-9bb6-463d-ba0c-f9a485f8c11d"), "B", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4054), "10B", 10, false },
                    { new Guid("91118a91-20c0-4037-bb52-6181501e0a0c"), "A", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4068), "11A", 11, false },
                    { new Guid("5483bb6b-c25a-4374-9350-19b91f9ff68e"), "G", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4049), "9G", 9, false },
                    { new Guid("805840ec-65a8-4517-963f-40f580d1399d"), "F", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4047), "9F", 9, false },
                    { new Guid("8b76cebd-1b4f-4614-add2-5bca02b81d0d"), "E", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4046), "9E", 9, false },
                    { new Guid("ec4bee6b-183d-4034-8728-6dfa9996e14e"), "A", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(4051), "10A", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("18445cdb-cd93-4422-823f-2dc4ec263674"), "Gold", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(1189), false },
                    { new Guid("66a91787-20ca-4721-85e9-55b3ef39ca4d"), "Unassigned", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(1222), false },
                    { new Guid("c7225eb7-753e-4420-abc1-25d169681096"), "Scarlet", new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(1219), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("ab6c8df0-797e-440d-8996-adbc371443ec"), new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(7515), "G1", "G", 1, false },
                    { new Guid("13a6f579-e305-4037-9e78-576c66d4381a"), new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(7716), "G2", "G", 2, false },
                    { new Guid("f51573bb-d047-4677-bf13-bfbeb2ef64e4"), new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(7720), "G3", "G", 3, false },
                    { new Guid("d2cf9219-02bd-418c-b859-a06acf8e6246"), new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(7724), "G4", "G", 4, false },
                    { new Guid("a9be1212-d0b8-49a3-8a2f-554141a977f9"), new DateTime(2021, 9, 14, 10, 2, 4, 643, DateTimeKind.Local).AddTicks(7728), "G5", "G", 5, false }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTemps_Genders_GenderId",
                table: "StudentTemps",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTemps_StudentClasses_StudentClassId",
                table: "StudentTemps",
                column: "StudentClassId",
                principalTable: "StudentClasses",
                principalColumn: "StudentClassId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTemps_StudentColors_StudentColorId",
                table: "StudentTemps",
                column: "StudentColorId",
                principalTable: "StudentColors",
                principalColumn: "StudentColorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTemps_StudentGroups_StudentGroupId",
                table: "StudentTemps",
                column: "StudentGroupId",
                principalTable: "StudentGroups",
                principalColumn: "StudentGroupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentTemps_Genders_GenderId",
                table: "StudentTemps");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTemps_StudentClasses_StudentClassId",
                table: "StudentTemps");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTemps_StudentColors_StudentColorId",
                table: "StudentTemps");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTemps_StudentGroups_StudentGroupId",
                table: "StudentTemps");

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("308d7267-a088-4114-8882-3b3673003f78"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("68d927b8-26fd-4bc8-b793-cdb85dbc2032"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("0f6e87f2-f537-439f-b1ec-4642f39c9de7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("19e8b25e-65ab-4156-bfd7-26ecdb05f3f8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1dfeaa34-9bb6-463d-ba0c-f9a485f8c11d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("36494d8b-c611-4f9e-bcec-fc4e95ab7e60"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3bec44a6-4d28-42ab-aa02-d0d67be12941"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3cbe58b7-8d18-48e4-bd54-16e6eb571835"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("440e728f-ed5a-4848-bb89-99b492c74c4d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4a493df2-2bb6-4131-a4cf-2b70d5450043"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4b4d0d36-e36b-4eff-9c29-194f5c40f82f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5483bb6b-c25a-4374-9350-19b91f9ff68e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("61c0782f-9071-43ac-8652-6f1f8799d4f2"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6541afa9-f521-4453-9e80-ac38d9c6d412"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("672dd376-80d7-4c46-9817-66ff76e4f9cb"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("74fad946-c025-4ed3-9ec7-60145615f1b1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7fc4b149-dcba-45c9-adfd-8f4d13dc1af5"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("805840ec-65a8-4517-963f-40f580d1399d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("816b89ce-a676-4883-a6cb-a02ecbe3b699"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("852734c2-882a-4b14-95a6-80dc6895f6d3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8b76cebd-1b4f-4614-add2-5bca02b81d0d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("91118a91-20c0-4037-bb52-6181501e0a0c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("974df766-48ad-4520-8899-2125f8469d72"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9ac34876-ac08-42ac-9272-c8d7dae6bb2b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a602e1d1-5c5f-4841-a3e0-51914b761328"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a95bb52d-a117-4d15-a0b6-e4fbd594e0ff"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ac07596e-7340-4faf-8120-6009be3db540"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("acf24741-4b6c-45cd-a376-f5be8f7f2aee"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b7bf74b5-878c-4a89-a24a-c13ed507d8f1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b9b0f7a4-0020-42d6-ab8c-730a580f49e1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("bddd0c93-65ce-4bc2-9c25-ebd6a7b8b4eb"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ce78ff12-1cdd-49a5-a8f6-05ac4b353baa"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d33f1411-60fa-48f2-a939-302c8f14abc2"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d90c4391-9a54-41aa-bfa4-a8851ae36da8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e0492ec4-8b59-4047-ac05-efb051786d02"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ec4bee6b-183d-4034-8728-6dfa9996e14e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f79181ad-054b-411a-9506-807ca583c431"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("18445cdb-cd93-4422-823f-2dc4ec263674"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("66a91787-20ca-4721-85e9-55b3ef39ca4d"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("c7225eb7-753e-4420-abc1-25d169681096"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("13a6f579-e305-4037-9e78-576c66d4381a"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("a9be1212-d0b8-49a3-8a2f-554141a977f9"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("ab6c8df0-797e-440d-8996-adbc371443ec"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("d2cf9219-02bd-418c-b859-a06acf8e6246"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("f51573bb-d047-4677-bf13-bfbeb2ef64e4"));

            migrationBuilder.AlterColumn<int>(
                name: "StudentNr",
                table: "StudentTemps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentGroupId",
                table: "StudentTemps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentColorId",
                table: "StudentTemps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentClassId",
                table: "StudentTemps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RowType",
                table: "StudentTemps",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RowNumber",
                table: "StudentTemps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GenderId",
                table: "StudentTemps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "f1816529-f3fb-44c7-8f0b-26e54a693ace");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6b546d1-ae31-4fce-8217-f7e08a6069a4", "AQAAAAEAACcQAAAAECPvajvHFOEOdDvHMMPLFNoGMRrwie6svFQF/0RR7BcMaYSqdBuaar9/JgC9HW2s5g==", "c367ae51-e860-4ea1-9023-33aabf085c9b" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("e2faf3fd-85bd-4444-b49b-a76d258eeb53"), new DateTime(2021, 9, 14, 9, 47, 20, 723, DateTimeKind.Local).AddTicks(6505), "F", "Female", false },
                    { new Guid("2fef4204-344a-48be-82ba-4acfcebacb4e"), new DateTime(2021, 9, 14, 9, 47, 20, 724, DateTimeKind.Local).AddTicks(4665), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("ae32c125-3daf-44e1-8c0a-148775c9b1b6"), "B", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5367), "8B", 8, false },
                    { new Guid("739267dd-d115-42f9-9bb9-f57c4c9682b7"), "A", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5357), "8A", 8, false },
                    { new Guid("f54215a6-83d0-4d94-bbef-11a18919c901"), "C", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5424), "11C", 11, false },
                    { new Guid("e9089b8f-a728-4fc5-b88d-e0888b4daa44"), "D", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5425), "11D", 11, false },
                    { new Guid("d05dcfa2-6498-48c1-ae6e-d98191b3dc1a"), "E", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5427), "11E", 11, false },
                    { new Guid("d93be269-866a-4aa2-acb0-2e382e9056ff"), "F", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5429), "11F", 11, false },
                    { new Guid("3f6ad0a5-d462-4866-b678-5ba3f7b70483"), "G", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5418), "10G", 10, false },
                    { new Guid("4c35498f-0423-40c2-a014-bfacf1bb9e3b"), "G", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5432), "11G", 11, false },
                    { new Guid("387e5659-96e6-4b37-a5fc-d0851c98cb77"), "B", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5436), "12B", 12, false },
                    { new Guid("3e8db05c-c5fe-4a2b-98eb-2054ca0b0609"), "C", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5438), "12C", 12, false },
                    { new Guid("2794a3ca-beca-44d4-b279-991ced4de48c"), "D", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5440), "12D", 12, false },
                    { new Guid("10460e0e-5750-4956-9258-a2a0f7692f71"), "E", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5442), "12E", 12, false },
                    { new Guid("6d9edf7e-9947-4ca6-b926-10473fcd7863"), "F", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5444), "12F", 12, false },
                    { new Guid("87dbad9c-0d8d-4d3e-b9e4-daa38f5e7ea3"), "G", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5445), "12G", 12, false },
                    { new Guid("b823a31a-eeeb-4f6f-b81f-5ac10ba450bb"), "A", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5435), "12A", 12, false },
                    { new Guid("bd9a7165-3fb0-4cbe-8c84-f6ce7ecfe452"), "F", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5417), "10F", 10, false },
                    { new Guid("a84b91dd-3935-438d-a7d0-323d1c749c6f"), "B", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5422), "11B", 11, false },
                    { new Guid("d7c20edc-cd28-4692-a497-2becda6292b6"), "D", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5408), "10D", 10, false },
                    { new Guid("147574c4-f652-4bd4-9054-0140e4839088"), "C", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5370), "8C", 8, false },
                    { new Guid("44b27aec-c3ba-40a4-8f42-b41345f2e111"), "D", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5380), "8D", 8, false },
                    { new Guid("3feecbdf-1e5b-4b13-b229-bb2a9e47785b"), "E", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5382), "8E", 8, false },
                    { new Guid("4aff3f1b-b8fc-4e06-b20d-da81a1709dc7"), "E", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5410), "10E", 10, false },
                    { new Guid("7ee64972-92f6-4fb4-94ee-e8330acfd0bd"), "G", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5386), "8G", 8, false },
                    { new Guid("536948ff-9442-4946-bbd5-1a8541e69376"), "A", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5388), "9A", 9, false },
                    { new Guid("48971a93-6fa2-4728-9ab7-fd7de943d587"), "B", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5389), "9B", 9, false },
                    { new Guid("bb8232bb-fada-42fd-b1d8-d28ce1219300"), "F", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5384), "8F", 8, false },
                    { new Guid("fd110450-f61b-4d56-b795-58e316f55118"), "D", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5393), "9D", 9, false },
                    { new Guid("2a842127-357c-4cac-bf80-96467cf21122"), "C", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5391), "9C", 9, false },
                    { new Guid("7f3de78c-5731-4afe-bfa0-a85926b81b43"), "C", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5407), "10C", 10, false },
                    { new Guid("26729663-d062-43d9-b81e-5efa30c8178d"), "B", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5405), "10B", 10, false },
                    { new Guid("2917af15-88d0-4d9c-838d-46abda684c91"), "A", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5420), "11A", 11, false },
                    { new Guid("835a09d7-cf33-4bfd-9b9a-10aee2f10bc2"), "G", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5401), "9G", 9, false },
                    { new Guid("70283a29-3797-407c-8187-d108fae25cc1"), "F", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5399), "9F", 9, false },
                    { new Guid("263630e8-fb37-473e-bcbf-a0748ae81990"), "E", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5397), "9E", 9, false },
                    { new Guid("79c91924-45ee-477c-9ba7-0e25204b7109"), "A", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(5403), "10A", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("4806b1f3-9bef-4204-98b0-ca6521d0375c"), "Gold", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(3624), false },
                    { new Guid("68344e92-1ff4-4ee3-9c4f-029ef7a5cc2a"), "Unassigned", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(3639), false },
                    { new Guid("b15da3a0-e97f-4e32-b09f-73945d1e363e"), "Scarlet", new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(3637), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("9bb5f7d2-729e-4a58-8d90-a47dfd452b04"), new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(6789), "G1", "G", 1, false },
                    { new Guid("4b32ed04-8fa0-45c1-8fba-7071a2aabcf9"), new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(6798), "G2", "G", 2, false },
                    { new Guid("2a2dd538-beda-4c77-bdb0-684db17f72c6"), new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(6800), "G3", "G", 3, false },
                    { new Guid("1ce5a107-bb19-4fa2-80db-5479de93fe67"), new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(6836), "G4", "G", 4, false },
                    { new Guid("b2ae0335-b5c8-4db3-a683-9458394ebe9f"), new DateTime(2021, 9, 14, 9, 47, 20, 725, DateTimeKind.Local).AddTicks(6838), "G5", "G", 5, false }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTemps_Genders_GenderId",
                table: "StudentTemps",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTemps_StudentClasses_StudentClassId",
                table: "StudentTemps",
                column: "StudentClassId",
                principalTable: "StudentClasses",
                principalColumn: "StudentClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTemps_StudentColors_StudentColorId",
                table: "StudentTemps",
                column: "StudentColorId",
                principalTable: "StudentColors",
                principalColumn: "StudentColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTemps_StudentGroups_StudentGroupId",
                table: "StudentTemps",
                column: "StudentGroupId",
                principalTable: "StudentGroups",
                principalColumn: "StudentGroupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}