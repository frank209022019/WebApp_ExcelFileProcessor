using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_ExcelFileProcessor.Migrations
{
    public partial class changeBoolToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "WearingAMask",
                table: "StudentScreeningTemps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "SufferFromChronicDisease",
                table: "StudentScreeningTemps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "HighRiskTravel14Days",
                table: "StudentScreeningTemps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "GeneralSenseWellbeing",
                table: "StudentScreeningTemps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "CloseContactProbableInfectedPerson",
                table: "StudentScreeningTemps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "CloseContactInfectedPerson",
                table: "StudentScreeningTemps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "AttendHealthFacility14Days",
                table: "StudentScreeningTemps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "AnyOfTheFollowingSymptoms",
                table: "StudentScreeningTemps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "AdmittedSeverPneumonia",
                table: "StudentScreeningTemps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "WearingAMask",
                table: "StudentScreening",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "SufferFromChronicDisease",
                table: "StudentScreening",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "HighRiskTravel14Days",
                table: "StudentScreening",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "GeneralSenseWellbeing",
                table: "StudentScreening",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "CloseContactProbableInfectedPerson",
                table: "StudentScreening",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "CloseContactInfectedPerson",
                table: "StudentScreening",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "AttendHealthFacility14Days",
                table: "StudentScreening",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "AnyOfTheFollowingSymptoms",
                table: "StudentScreening",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "AdmittedSeverPneumonia",
                table: "StudentScreening",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba566e0f-3d52-4967-a62c-1965b9f1e251",
                column: "ConcurrencyStamp",
                value: "77928d74-6473-46a2-b2dc-f8ecb8c00ba1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b824f5d-01b1-411b-8e44-5b05003ef81e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3272646f-bdc1-4bfd-a29a-2e2495decbf4", "AQAAAAEAACcQAAAAEAOKZ+FZIq165cFpAKyZ/3zNkgZdWf/7q+vKjRBa0pAOv5wqC0Eaolh8sX687QtGKg==", "794eb6ec-0254-48c2-a813-7c5a7b8c983b" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "DateCreated", "GenderChar", "GenderName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("0d63eb3b-8276-4289-a479-43d2696f8d38"), new DateTime(2021, 9, 16, 14, 22, 9, 603, DateTimeKind.Local).AddTicks(4433), "F", "Female", false },
                    { new Guid("4443cf5f-6439-4da4-8ea0-60654d9a36d2"), new DateTime(2021, 9, 16, 14, 22, 9, 604, DateTimeKind.Local).AddTicks(5593), "M", "Male", false }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentClassId", "ClassChar", "DateCreated", "DisplayName", "GradeInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("859066c3-d524-46d7-9107-a984038ff4d7"), "B", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6624), "8B", 8, false },
                    { new Guid("1c855890-50f7-47a6-8e9c-7a179d344620"), "A", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6614), "8A", 8, false },
                    { new Guid("e57fdced-be9f-4b56-8cee-b938400febd0"), "C", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6681), "11C", 11, false },
                    { new Guid("571c5f9c-4c1d-48ca-bdeb-1451602b7b9e"), "D", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6685), "11D", 11, false },
                    { new Guid("2072d197-1e07-4ec7-830b-c4ccf7462f2a"), "E", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6687), "11E", 11, false },
                    { new Guid("f69a3aa0-b990-4c21-a5dc-fa4837a2bddf"), "F", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6688), "11F", 11, false },
                    { new Guid("75800381-e1f9-4df0-a4fb-6c5e10e2a26a"), "G", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6676), "10G", 10, false },
                    { new Guid("9fe441d0-3d43-4b14-aa60-b76b5f55d757"), "G", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6692), "11G", 11, false },
                    { new Guid("44cc77fe-e81c-46ed-a340-ec087eca8bba"), "B", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6697), "12B", 12, false },
                    { new Guid("685d312c-e1ab-49bc-a81d-a0ae2c0f429c"), "C", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6698), "12C", 12, false },
                    { new Guid("61e219a1-ddea-46f7-a9f7-47478f91135b"), "D", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6700), "12D", 12, false },
                    { new Guid("65c7605c-3da4-4632-9a7b-16ff6694a367"), "E", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6702), "12E", 12, false },
                    { new Guid("5637258e-d260-465d-aeb4-d8e06c49849a"), "F", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6704), "12F", 12, false },
                    { new Guid("2fbc5243-8c18-4753-84d9-e5de7bd0f533"), "G", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6706), "12G", 12, false },
                    { new Guid("668ea1b2-258a-4b89-aa9a-4f83df58e0e7"), "A", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6694), "12A", 12, false },
                    { new Guid("0420fc25-2231-4648-a59f-8b4852a0d115"), "F", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6673), "10F", 10, false },
                    { new Guid("b71cece3-07ad-4582-83de-7436be8a19c9"), "B", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6679), "11B", 11, false },
                    { new Guid("22293204-2566-4b5a-ae90-a53e02af47f8"), "D", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6667), "10D", 10, false },
                    { new Guid("320fb59f-3c84-40dd-add4-601335ba76f5"), "C", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6627), "8C", 8, false },
                    { new Guid("fe015390-01f6-43c9-82db-c088119154e9"), "D", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6639), "8D", 8, false },
                    { new Guid("323193b8-dbc7-4ac1-8abc-b55fe3d8aec4"), "E", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6641), "8E", 8, false },
                    { new Guid("99878c55-777b-40b4-a3c7-6d73325cb0ff"), "E", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6669), "10E", 10, false },
                    { new Guid("4c8dbbac-2bc1-4913-8d51-fc1d124ea424"), "G", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6645), "8G", 8, false },
                    { new Guid("a244589d-c50e-466a-9ef8-525c44c119d2"), "A", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6647), "9A", 9, false },
                    { new Guid("bfe315ae-f6ba-426c-bbae-47eff6fc3975"), "B", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6649), "9B", 9, false },
                    { new Guid("56de00f9-d2b6-47d8-9bbd-1e7a5d2dd0e0"), "F", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6643), "8F", 8, false },
                    { new Guid("67cfc4d7-3b42-478f-b1f5-a67523f0265a"), "D", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6653), "9D", 9, false },
                    { new Guid("c44195f2-f4cc-4c9e-aa7a-173ec011ed4c"), "C", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6651), "9C", 9, false },
                    { new Guid("6f0dcf2e-23b5-468b-a3d8-f7dac0615391"), "C", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6665), "10C", 10, false },
                    { new Guid("01e496d7-fd84-4820-b68d-36ed2ebd554e"), "B", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6663), "10B", 10, false },
                    { new Guid("18be5c9b-b7cc-46fd-900e-25b1ce267d7b"), "A", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6678), "11A", 11, false },
                    { new Guid("d3639411-f2df-4a6f-a1c0-a1be5aaa1f70"), "G", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6660), "9G", 9, false },
                    { new Guid("46c444d8-5249-4749-bd51-d85ad92a2ecb"), "F", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6658), "9F", 9, false },
                    { new Guid("23907e6f-3c3c-4b43-b3fa-8c497a739f36"), "E", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6656), "9E", 9, false },
                    { new Guid("147f6485-9f71-408c-99b1-c6fa5a1e7e70"), "A", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(6662), "10A", 10, false }
                });

            migrationBuilder.InsertData(
                table: "StudentColors",
                columns: new[] { "StudentColorId", "ColorName", "DateCreated", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("d9ee584d-954a-4241-9323-1e8a32249247"), "Gold", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(5082), false },
                    { new Guid("d482f649-3b50-44d4-ae9d-ea75f1a252ad"), "Unassigned", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(5097), false },
                    { new Guid("4b2d2fb7-4298-44ce-939c-58a9c69002c6"), "Scarlet", new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(5095), false }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "DateCreated", "DisplayName", "GroupChar", "GroupInt", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("8cdd001d-288f-4d08-9cba-409df2c779f4"), new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(8073), "G1", "G", 1, false },
                    { new Guid("17990371-eab4-4181-b2c0-d8da56deef8e"), new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(8083), "G2", "G", 2, false },
                    { new Guid("48658d3d-2b9d-46ba-ae5c-35c3f3d06df7"), new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(8085), "G3", "G", 3, false },
                    { new Guid("35066eb3-d297-4e7b-b5c6-f4ea89f6f606"), new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(8087), "G4", "G", 4, false },
                    { new Guid("8fc1784b-8a46-4b33-b51e-e3f532c8c0b4"), new DateTime(2021, 9, 16, 14, 22, 9, 605, DateTimeKind.Local).AddTicks(8090), "G5", "G", 5, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("0d63eb3b-8276-4289-a479-43d2696f8d38"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("4443cf5f-6439-4da4-8ea0-60654d9a36d2"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("01e496d7-fd84-4820-b68d-36ed2ebd554e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("0420fc25-2231-4648-a59f-8b4852a0d115"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("147f6485-9f71-408c-99b1-c6fa5a1e7e70"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("18be5c9b-b7cc-46fd-900e-25b1ce267d7b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("1c855890-50f7-47a6-8e9c-7a179d344620"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2072d197-1e07-4ec7-830b-c4ccf7462f2a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("22293204-2566-4b5a-ae90-a53e02af47f8"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("23907e6f-3c3c-4b43-b3fa-8c497a739f36"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("2fbc5243-8c18-4753-84d9-e5de7bd0f533"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("320fb59f-3c84-40dd-add4-601335ba76f5"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("323193b8-dbc7-4ac1-8abc-b55fe3d8aec4"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("44cc77fe-e81c-46ed-a340-ec087eca8bba"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("46c444d8-5249-4749-bd51-d85ad92a2ecb"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("4c8dbbac-2bc1-4913-8d51-fc1d124ea424"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("5637258e-d260-465d-aeb4-d8e06c49849a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("56de00f9-d2b6-47d8-9bbd-1e7a5d2dd0e0"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("571c5f9c-4c1d-48ca-bdeb-1451602b7b9e"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("61e219a1-ddea-46f7-a9f7-47478f91135b"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("65c7605c-3da4-4632-9a7b-16ff6694a367"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("668ea1b2-258a-4b89-aa9a-4f83df58e0e7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("67cfc4d7-3b42-478f-b1f5-a67523f0265a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("685d312c-e1ab-49bc-a81d-a0ae2c0f429c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("6f0dcf2e-23b5-468b-a3d8-f7dac0615391"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("75800381-e1f9-4df0-a4fb-6c5e10e2a26a"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("859066c3-d524-46d7-9107-a984038ff4d7"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("99878c55-777b-40b4-a3c7-6d73325cb0ff"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("9fe441d0-3d43-4b14-aa60-b76b5f55d757"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("a244589d-c50e-466a-9ef8-525c44c119d2"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("b71cece3-07ad-4582-83de-7436be8a19c9"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("bfe315ae-f6ba-426c-bbae-47eff6fc3975"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("c44195f2-f4cc-4c9e-aa7a-173ec011ed4c"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("d3639411-f2df-4a6f-a1c0-a1be5aaa1f70"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("e57fdced-be9f-4b56-8cee-b938400febd0"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("f69a3aa0-b990-4c21-a5dc-fa4837a2bddf"));

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumn: "StudentClassId",
                keyValue: new Guid("fe015390-01f6-43c9-82db-c088119154e9"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("4b2d2fb7-4298-44ce-939c-58a9c69002c6"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("d482f649-3b50-44d4-ae9d-ea75f1a252ad"));

            migrationBuilder.DeleteData(
                table: "StudentColors",
                keyColumn: "StudentColorId",
                keyValue: new Guid("d9ee584d-954a-4241-9323-1e8a32249247"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("17990371-eab4-4181-b2c0-d8da56deef8e"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("35066eb3-d297-4e7b-b5c6-f4ea89f6f606"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("48658d3d-2b9d-46ba-ae5c-35c3f3d06df7"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("8cdd001d-288f-4d08-9cba-409df2c779f4"));

            migrationBuilder.DeleteData(
                table: "StudentGroups",
                keyColumn: "StudentGroupId",
                keyValue: new Guid("8fc1784b-8a46-4b33-b51e-e3f532c8c0b4"));

            migrationBuilder.AlterColumn<bool>(
                name: "WearingAMask",
                table: "StudentScreeningTemps",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SufferFromChronicDisease",
                table: "StudentScreeningTemps",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HighRiskTravel14Days",
                table: "StudentScreeningTemps",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "GeneralSenseWellbeing",
                table: "StudentScreeningTemps",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "CloseContactProbableInfectedPerson",
                table: "StudentScreeningTemps",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "CloseContactInfectedPerson",
                table: "StudentScreeningTemps",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AttendHealthFacility14Days",
                table: "StudentScreeningTemps",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AnyOfTheFollowingSymptoms",
                table: "StudentScreeningTemps",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AdmittedSeverPneumonia",
                table: "StudentScreeningTemps",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "WearingAMask",
                table: "StudentScreening",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SufferFromChronicDisease",
                table: "StudentScreening",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HighRiskTravel14Days",
                table: "StudentScreening",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "GeneralSenseWellbeing",
                table: "StudentScreening",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "CloseContactProbableInfectedPerson",
                table: "StudentScreening",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "CloseContactInfectedPerson",
                table: "StudentScreening",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AttendHealthFacility14Days",
                table: "StudentScreening",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AnyOfTheFollowingSymptoms",
                table: "StudentScreening",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AdmittedSeverPneumonia",
                table: "StudentScreening",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
