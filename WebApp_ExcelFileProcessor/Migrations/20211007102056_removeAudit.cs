using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class removeAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audits");

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("464c90c4-6ae9-40ca-af4a-9312b78c8806"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("ee8e46c4-2549-4a0e-8dd8-b954b354fbe4"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("127fef36-9b35-45fb-b191-cd41160e5012"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1941d137-f9db-47ba-86e7-6b4c880613a9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1d80b78d-66b7-4dbf-8ef2-7182580d702b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("34d4dbf9-2e10-45b1-9e58-2121d5aa497b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("36c863a6-9622-4f29-9a3c-9e793ba073c7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3890c5d7-c440-4061-9285-2de710ffe0bb"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4b275eb1-4ebc-4634-94f8-9f490234596a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("58acd5bb-7bb8-43bd-9eab-680ee6987c57"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5b71d1f4-fce0-4e44-b78a-f068707e7932"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5c4d0c49-14f7-4cd1-86a7-701928f60d29"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5f6507b1-141d-4ef8-b5d0-086c2888f33c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("614f20f4-7116-4999-9a1c-e2ddb912e5ca"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("66a40d43-d357-438b-8d20-aeb832de855c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("68b65cb9-0b86-4a51-a431-96c27e3b77b2"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("690e0232-a45c-4eaf-b5ec-8fe78cc8accc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7897998b-390f-498b-958c-d34b9c60ef8b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7a21aede-b865-46ca-af89-54a1dbfa1c6f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7e06b09e-7768-4313-9f19-67071c746b1f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("7fd154f9-45ff-417c-897a-1790f5755748"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("8623e874-a0e2-47bb-ac6f-acfdcda562a1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("86e4db0a-03f1-479d-8c21-11587f9f2fb7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("955acc25-a36b-4c0e-be1f-35b9f4f27b2f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9ad63cea-5197-44ac-8429-68dc0fcd81b3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a081fbf0-9509-40e1-9bf2-6180b2481773"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ac4ba17c-6c5c-468e-b8fb-446534c14e67"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("bacfae2c-f627-433b-9097-e56654dce7da"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("beda3608-b31b-44c1-8553-d698456385cd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("c2373a81-03f4-434f-9e00-c69a9cc1fdc0"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("ec64575e-7dd4-4ed1-a97f-35aa4d10ea0c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("eee9e6d2-5021-42e4-882a-a2524dd4d9c3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f7a8c8bf-9938-43b0-8169-94e70f900468"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fa749c72-bda3-4e28-9148-1250ed6917d1"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fbdf5dd4-7284-4f42-be11-b34bcb363f4d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fbe60dc3-9f26-4867-af83-8f7758816c0e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fe8aed9c-76b8-4607-9e23-09e327791311"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("534d9e42-d8e3-4508-9cfd-eaf7e2c690b7"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("64cdf976-7870-49b4-a6cd-962672a605ad"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("be8651a7-3f46-4a8c-adca-d46be6aee076"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("580b7444-0a79-4fea-90ea-be6db2e80b20"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("afa18ee3-408c-4c66-ade5-c4c018e8f78e"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("b28bc369-39a4-4156-9bd2-9b548d8a1a38"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("c4e20e6d-22a6-4a6b-b65e-f22f8e6ff4ab"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("f3822c03-18b9-45e5-8b4a-492137f88be6"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "94beac5b-84f7-488e-8197-ba39defc15bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c516405-8699-4301-b739-fa359489c79c", "AQAAAAEAACcQAAAAECvzTf+C0sq+UIt+HNhjoa5Tzvl1DEwjnqzUKtA8n4a7dvpP2IBXTe6+k+2KhnF2QQ==", "9da82683-a0d2-49df-9496-293578b9114c" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("6d19436a-8eaa-4286-8c9f-4fcec45bc840"), new DateTime(2021, 10, 7, 12, 20, 56, 173, DateTimeKind.Local).AddTicks(358), "F", "Female", false },
                    { new Guid("3136d187-d796-419c-a4a7-5bcf0aff2f26"), new DateTime(2021, 10, 7, 12, 20, 56, 173, DateTimeKind.Local).AddTicks(8609), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("269636da-82a3-4dea-9471-064776dc0887"), "B", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9172), "8B", 8, false },
                    { new Guid("1b8c7043-5ddd-4cd9-b6b2-25700e00b392"), "A", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9161), "8A", 8, false },
                    { new Guid("eee8724c-a65d-408e-8055-28b009d809e2"), "C", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9228), "11C", 11, false },
                    { new Guid("304e52c3-418d-4457-b949-0db9ed58f89e"), "D", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9231), "11D", 11, false },
                    { new Guid("1d9f8f15-ab1e-4a2b-a4cf-ffdddb63714f"), "E", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9232), "11E", 11, false },
                    { new Guid("4a52c312-672f-4f8b-a9bb-93dfd2e37754"), "F", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9236), "11F", 11, false },
                    { new Guid("4ff90ecf-bdc3-40f2-889e-6980b41749d3"), "G", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9223), "10G", 10, false },
                    { new Guid("58429448-6d02-434e-9c5e-ec13f7a6727d"), "G", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9238), "11G", 11, false },
                    { new Guid("d40b0f3e-227f-4823-8019-128f00409059"), "B", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9241), "12B", 12, false },
                    { new Guid("e479d001-44f8-4114-91b7-28494d9fc4ea"), "C", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9243), "12C", 12, false },
                    { new Guid("80cbc098-4daa-48de-a2ea-4b00fb06b1dc"), "D", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9245), "12D", 12, false },
                    { new Guid("b32a0ecc-9ddb-4b92-b936-1e9ea584e36e"), "E", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9246), "12E", 12, false },
                    { new Guid("b9f34543-b45c-4212-8239-3f6e8e57cbcd"), "F", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9248), "12F", 12, false },
                    { new Guid("a9466098-2a5a-45dc-8434-5c29fd85aad8"), "G", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9252), "12G", 12, false },
                    { new Guid("2d42d2eb-674f-4033-bed5-4dc2f1044331"), "A", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9239), "12A", 12, false },
                    { new Guid("39c2b4af-d2ca-47f0-aebe-45285620255d"), "F", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9221), "10F", 10, false },
                    { new Guid("fdd0845f-ba25-4e20-8693-82ac1447de1a"), "B", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9226), "11B", 11, false },
                    { new Guid("3765d4ba-7224-40aa-b24c-632bc7eec1dc"), "D", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9216), "10D", 10, false },
                    { new Guid("4b4fee75-db7d-44a3-880b-541a42b45847"), "C", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9185), "8C", 8, false },
                    { new Guid("37a8e15c-5421-4d68-928b-16a80beebb69"), "D", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9187), "8D", 8, false },
                    { new Guid("e7024db6-c513-4eed-a7cb-a2e0f5ce6b75"), "E", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9189), "8E", 8, false },
                    { new Guid("99fd044f-8041-406e-8104-e228c3031b68"), "E", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9220), "10E", 10, false },
                    { new Guid("77322982-b8cd-4270-871a-015022087131"), "G", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9194), "8G", 8, false },
                    { new Guid("3c15adf8-4b68-46ac-9153-294efbf762ca"), "A", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9196), "9A", 9, false },
                    { new Guid("feb607bd-041f-4c95-877a-6aece586bfec"), "B", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9197), "9B", 9, false },
                    { new Guid("dcc3c21d-3233-433d-a30a-309ece47635f"), "F", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9192), "8F", 8, false },
                    { new Guid("95765801-96d7-43f2-9da2-711858a0d97d"), "D", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9203), "9D", 9, false },
                    { new Guid("14dd5839-8b79-433c-a31f-468dc5bde314"), "C", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9200), "9C", 9, false },
                    { new Guid("383d00f5-4044-43a4-844b-7285c135199f"), "C", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9214), "10C", 10, false },
                    { new Guid("5b00e89e-72d1-4b93-b56c-a2210c3a883a"), "B", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9213), "10B", 10, false },
                    { new Guid("f83199c7-d83c-4658-8c90-51ff47d651db"), "A", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9225), "11A", 11, false },
                    { new Guid("0cfa05a8-3ecc-4b65-ae32-5ba508f38db3"), "G", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9209), "9G", 9, false },
                    { new Guid("59ab3ce0-f63c-42ad-b930-3682144111be"), "F", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9208), "9F", 9, false },
                    { new Guid("5d5e576d-ca28-4362-a087-57b73e67ef5e"), "E", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9205), "9E", 9, false },
                    { new Guid("95a456fc-c096-4cdf-8d56-0d296de9aa69"), "A", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(9211), "10A", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("445eb412-edf6-439a-a42f-9a239bade63f"), "Gold", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(7787), false },
                    { new Guid("a31c4f91-1af0-47ee-89fe-7630d7e971c0"), "Unassigned", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(7802), false },
                    { new Guid("dcd4ffcf-02f8-44be-a9a3-ae32e1aca454"), "Scarlet", new DateTime(2021, 10, 7, 12, 20, 56, 174, DateTimeKind.Local).AddTicks(7800), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("fb580e6a-0a2f-4cf0-a6f5-5eb913630dac"), new DateTime(2021, 10, 7, 12, 20, 56, 175, DateTimeKind.Local).AddTicks(1615), "G1", "G", 1, false },
                    { new Guid("21bec561-ac0b-4fb9-bac3-81503ef37956"), new DateTime(2021, 10, 7, 12, 20, 56, 175, DateTimeKind.Local).AddTicks(1628), "G2", "G", 2, false },
                    { new Guid("9270fde0-2b75-44c8-91cc-b1716dee4e50"), new DateTime(2021, 10, 7, 12, 20, 56, 175, DateTimeKind.Local).AddTicks(1631), "G3", "G", 3, false },
                    { new Guid("28d59f1c-eb6d-43aa-bf4c-05b1f9a00205"), new DateTime(2021, 10, 7, 12, 20, 56, 175, DateTimeKind.Local).AddTicks(1633), "G4", "G", 4, false },
                    { new Guid("74a91b56-52c9-4d97-8a72-0f5d49035215"), new DateTime(2021, 10, 7, 12, 20, 56, 175, DateTimeKind.Local).AddTicks(1635), "G5", "G", 5, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("3136d187-d796-419c-a4a7-5bcf0aff2f26"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("6d19436a-8eaa-4286-8c9f-4fcec45bc840"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("0cfa05a8-3ecc-4b65-ae32-5ba508f38db3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("14dd5839-8b79-433c-a31f-468dc5bde314"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1b8c7043-5ddd-4cd9-b6b2-25700e00b392"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1d9f8f15-ab1e-4a2b-a4cf-ffdddb63714f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("269636da-82a3-4dea-9471-064776dc0887"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2d42d2eb-674f-4033-bed5-4dc2f1044331"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("304e52c3-418d-4457-b949-0db9ed58f89e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3765d4ba-7224-40aa-b24c-632bc7eec1dc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("37a8e15c-5421-4d68-928b-16a80beebb69"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("383d00f5-4044-43a4-844b-7285c135199f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("39c2b4af-d2ca-47f0-aebe-45285620255d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("3c15adf8-4b68-46ac-9153-294efbf762ca"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4a52c312-672f-4f8b-a9bb-93dfd2e37754"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4b4fee75-db7d-44a3-880b-541a42b45847"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4ff90ecf-bdc3-40f2-889e-6980b41749d3"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("58429448-6d02-434e-9c5e-ec13f7a6727d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("59ab3ce0-f63c-42ad-b930-3682144111be"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5b00e89e-72d1-4b93-b56c-a2210c3a883a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5d5e576d-ca28-4362-a087-57b73e67ef5e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("77322982-b8cd-4270-871a-015022087131"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("80cbc098-4daa-48de-a2ea-4b00fb06b1dc"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("95765801-96d7-43f2-9da2-711858a0d97d"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("95a456fc-c096-4cdf-8d56-0d296de9aa69"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("99fd044f-8041-406e-8104-e228c3031b68"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a9466098-2a5a-45dc-8434-5c29fd85aad8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b32a0ecc-9ddb-4b92-b936-1e9ea584e36e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b9f34543-b45c-4212-8239-3f6e8e57cbcd"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d40b0f3e-227f-4823-8019-128f00409059"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("dcc3c21d-3233-433d-a30a-309ece47635f"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e479d001-44f8-4114-91b7-28494d9fc4ea"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e7024db6-c513-4eed-a7cb-a2e0f5ce6b75"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("eee8724c-a65d-408e-8055-28b009d809e2"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f83199c7-d83c-4658-8c90-51ff47d651db"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fdd0845f-ba25-4e20-8693-82ac1447de1a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("feb607bd-041f-4c95-877a-6aece586bfec"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("445eb412-edf6-439a-a42f-9a239bade63f"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("a31c4f91-1af0-47ee-89fe-7630d7e971c0"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("dcd4ffcf-02f8-44be-a9a3-ae32e1aca454"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("21bec561-ac0b-4fb9-bac3-81503ef37956"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("28d59f1c-eb6d-43aa-bf4c-05b1f9a00205"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("74a91b56-52c9-4d97-8a72-0f5d49035215"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("9270fde0-2b75-44c8-91cc-b1716dee4e50"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("fb580e6a-0a2f-4cf0-a6f5-5eb913630dac"));

            migrationBuilder.CreateTable(
                name: "Audits",
                columns: table => new
                {
                    AuditLogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColumnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NewValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordIdName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordIdValue = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "3ed69c39-881a-4d32-a82b-a190d015516f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a197a33-940d-4e61-8737-29bafbaad512", "AQAAAAEAACcQAAAAEMAEgcbLpFXDWrIZSJe/dSzOt6EESCZa+hZYgSZYBlkKIj/gKtvLY3YshFQLVGwr4g==", "897e1623-cdc7-4011-bfdd-763df1dc3f13" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("464c90c4-6ae9-40ca-af4a-9312b78c8806"), new DateTime(2021, 10, 7, 9, 51, 33, 26, DateTimeKind.Local).AddTicks(130), "F", "Female", false },
                    { new Guid("ee8e46c4-2549-4a0e-8dd8-b954b354fbe4"), new DateTime(2021, 10, 7, 9, 51, 33, 27, DateTimeKind.Local).AddTicks(2773), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("614f20f4-7116-4999-9a1c-e2ddb912e5ca"), "B", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1688), "8B", 8, false },
                    { new Guid("5c4d0c49-14f7-4cd1-86a7-701928f60d29"), "A", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1659), "8A", 8, false },
                    { new Guid("1941d137-f9db-47ba-86e7-6b4c880613a9"), "C", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1759), "11C", 11, false },
                    { new Guid("955acc25-a36b-4c0e-be1f-35b9f4f27b2f"), "D", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1762), "11D", 11, false },
                    { new Guid("ec64575e-7dd4-4ed1-a97f-35aa4d10ea0c"), "E", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1768), "11E", 11, false },
                    { new Guid("7897998b-390f-498b-958c-d34b9c60ef8b"), "F", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1771), "11F", 11, false },
                    { new Guid("36c863a6-9622-4f29-9a3c-9e793ba073c7"), "G", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1751), "10G", 10, false },
                    { new Guid("4b275eb1-4ebc-4634-94f8-9f490234596a"), "G", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1774), "11G", 11, false },
                    { new Guid("eee9e6d2-5021-42e4-882a-a2524dd4d9c3"), "B", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1780), "12B", 12, false },
                    { new Guid("5b71d1f4-fce0-4e44-b78a-f068707e7932"), "C", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1783), "12C", 12, false },
                    { new Guid("9ad63cea-5197-44ac-8429-68dc0fcd81b3"), "D", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1786), "12D", 12, false },
                    { new Guid("c2373a81-03f4-434f-9e00-c69a9cc1fdc0"), "E", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1788), "12E", 12, false },
                    { new Guid("690e0232-a45c-4eaf-b5ec-8fe78cc8accc"), "F", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1794), "12F", 12, false },
                    { new Guid("34d4dbf9-2e10-45b1-9e58-2121d5aa497b"), "G", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1797), "12G", 12, false },
                    { new Guid("1d80b78d-66b7-4dbf-8ef2-7182580d702b"), "A", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1777), "12A", 12, false },
                    { new Guid("a081fbf0-9509-40e1-9bf2-6180b2481773"), "F", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1748), "10F", 10, false },
                    { new Guid("68b65cb9-0b86-4a51-a431-96c27e3b77b2"), "B", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1757), "11B", 11, false },
                    { new Guid("8623e874-a0e2-47bb-ac6f-acfdcda562a1"), "D", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1742), "10D", 10, false },
                    { new Guid("7e06b09e-7768-4313-9f19-67071c746b1f"), "C", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1692), "8C", 8, false },
                    { new Guid("58acd5bb-7bb8-43bd-9eab-680ee6987c57"), "D", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1694), "8D", 8, false },
                    { new Guid("fe8aed9c-76b8-4607-9e23-09e327791311"), "E", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1698), "8E", 8, false },
                    { new Guid("86e4db0a-03f1-479d-8c21-11587f9f2fb7"), "E", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1745), "10E", 10, false },
                    { new Guid("5f6507b1-141d-4ef8-b5d0-086c2888f33c"), "G", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1703), "8G", 8, false },
                    { new Guid("7a21aede-b865-46ca-af89-54a1dbfa1c6f"), "A", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1706), "9A", 9, false },
                    { new Guid("fbe60dc3-9f26-4867-af83-8f7758816c0e"), "B", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1709), "9B", 9, false },
                    { new Guid("66a40d43-d357-438b-8d20-aeb832de855c"), "F", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1700), "8F", 8, false },
                    { new Guid("beda3608-b31b-44c1-8553-d698456385cd"), "D", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1718), "9D", 9, false },
                    { new Guid("7fd154f9-45ff-417c-897a-1790f5755748"), "C", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1715), "9C", 9, false },
                    { new Guid("3890c5d7-c440-4061-9285-2de710ffe0bb"), "C", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1736), "10C", 10, false },
                    { new Guid("bacfae2c-f627-433b-9097-e56654dce7da"), "B", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1734), "10B", 10, false },
                    { new Guid("fbdf5dd4-7284-4f42-be11-b34bcb363f4d"), "A", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1754), "11A", 11, false },
                    { new Guid("f7a8c8bf-9938-43b0-8169-94e70f900468"), "G", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1728), "9G", 9, false },
                    { new Guid("127fef36-9b35-45fb-b191-cd41160e5012"), "F", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1724), "9F", 9, false },
                    { new Guid("fa749c72-bda3-4e28-9148-1250ed6917d1"), "E", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1721), "9E", 9, false },
                    { new Guid("ac4ba17c-6c5c-468e-b8fb-446534c14e67"), "A", new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(1731), "10A", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("534d9e42-d8e3-4508-9cfd-eaf7e2c690b7"), "Gold", new DateTime(2021, 10, 7, 9, 51, 33, 28, DateTimeKind.Local).AddTicks(9303), false },
                    { new Guid("64cdf976-7870-49b4-a6cd-962672a605ad"), "Unassigned", new DateTime(2021, 10, 7, 9, 51, 33, 28, DateTimeKind.Local).AddTicks(9340), false },
                    { new Guid("be8651a7-3f46-4a8c-adca-d46be6aee076"), "Scarlet", new DateTime(2021, 10, 7, 9, 51, 33, 28, DateTimeKind.Local).AddTicks(9336), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("b28bc369-39a4-4156-9bd2-9b548d8a1a38"), new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(4537), "G1", "G", 1, false },
                    { new Guid("f3822c03-18b9-45e5-8b4a-492137f88be6"), new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(4554), "G2", "G", 2, false },
                    { new Guid("afa18ee3-408c-4c66-ade5-c4c018e8f78e"), new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(4558), "G3", "G", 3, false },
                    { new Guid("580b7444-0a79-4fea-90ea-be6db2e80b20"), new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(4560), "G4", "G", 4, false },
                    { new Guid("c4e20e6d-22a6-4a6b-b65e-f22f8e6ff4ab"), new DateTime(2021, 10, 7, 9, 51, 33, 29, DateTimeKind.Local).AddTicks(4563), "G5", "G", 5, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Audits_UserId",
                table: "Audits",
                column: "UserId");
        }
    }
}