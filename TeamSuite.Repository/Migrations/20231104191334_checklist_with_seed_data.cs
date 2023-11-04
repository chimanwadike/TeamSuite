using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamSuite.Repository.Migrations
{
    /// <inheritdoc />
    public partial class checklist_with_seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfWedding",
                table: "Members",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CheckListForm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckListForm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CheckListItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    CheckListFormId = table.Column<Guid>(type: "uuid", nullable: false),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckList_CheckListForm_CheckListFormId",
                        column: x => x.CheckListFormId,
                        principalTable: "CheckListForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckList_CheckListItems_CheckListItemId",
                        column: x => x.CheckListItemId,
                        principalTable: "CheckListItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckList_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CheckListForm",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), "Technical Services Management", "Technical Team CheckList" });

            migrationBuilder.InsertData(
                table: "CheckListItems",
                columns: new[] { "Id", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("1ee4d6f9-543f-4e82-bfee-4fb5fbae2e76"), null, "Confirm Feed and Sound to Streaming Booth", true },
                    { new Guid("1f697cf5-88d4-4540-bc12-cc0a7fb4a4b4"), null, "Switch on TV", true },
                    { new Guid("2886bc74-cb10-40fd-a1aa-d8fdff8da600"), null, "Switch on Internet", true },
                    { new Guid("2cdad48a-0eb7-427d-85be-06b5b3ea79e1"), null, "Check System Storage Space", true },
                    { new Guid("323b892f-675c-4398-a522-fe236452b845"), null, "Confirm Intercom Working (Call all lines)", true },
                    { new Guid("4c211be7-08d2-40d6-aa53-c2fd45e44093"), null, "Confirm Internet functioning", true },
                    { new Guid("4d8e9047-5252-4b4d-a444-fd61bde84f30"), null, "Switch on System(s)", true },
                    { new Guid("5b9b97a8-e9b9-4ec2-9b22-a73cd7aae21f"), null, "Confirm Feed form Broadcast", true },
                    { new Guid("6372e3ad-9a8c-44e1-bbf2-9de4c7f32f53"), null, "Confirm Feed from Broadcast on Vmix", true },
                    { new Guid("700bbd8f-ed41-42a8-a05b-247b75e094a9"), null, "Check Nursing Mothers Room for feed", true },
                    { new Guid("7358c6ff-0617-45d0-85a2-db13d0f92100"), null, "Setup timer", true },
                    { new Guid("86561683-ea1b-4817-93d5-617465998a62"), null, "Check System for Recording and Timer", true },
                    { new Guid("8a7a6f0a-22d1-49ed-acac-5077ca1de851"), null, "Confirm internet on System(s)", true },
                    { new Guid("a5abdc33-7865-487e-928f-5ce5fcc80bb8"), null, "Retrieve program for the Day", true },
                    { new Guid("cbda2593-663c-4d1d-8fa7-fdfff22ec4ef"), null, "Confirm Sound from Epignosis", true },
                    { new Guid("d228aac6-b250-4624-851d-f5436e3ddfd0"), null, "Switch on System for Intercom", true },
                    { new Guid("e7c7973f-1ec6-4745-88ed-011b3064046c"), null, "Upload Program to System and share to TV", true },
                    { new Guid("ee3994db-db07-4777-b1f8-ee73dc2fdc9e"), null, "Confirm Sound from Main Church", true },
                    { new Guid("ef4662de-f86f-4c61-ae5b-d08554ebec16"), null, "Test Recording software", true },
                    { new Guid("f7e3ba90-7bec-4a7a-b13f-546cc47bdc8d"), null, "Switch on CCTV", true }
                });

            migrationBuilder.InsertData(
                table: "CheckList",
                columns: new[] { "Id", "CheckListFormId", "CheckListItemId", "LocationId", "Order" },
                values: new object[,]
                {
                    { new Guid("08903ef8-4b71-45da-b291-c39438d176cb"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("2cdad48a-0eb7-427d-85be-06b5b3ea79e1"), new Guid("13164e2a-7a90-11ee-b962-0242ac120002"), 11 },
                    { new Guid("0fdadf87-a6ef-4c77-adbb-29cf9f621513"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("4c211be7-08d2-40d6-aa53-c2fd45e44093"), new Guid("03164e2a-7a90-11ee-b962-0242ac120002"), 5 },
                    { new Guid("157aafe4-c388-4d0b-97da-5c0315982fc0"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("e7c7973f-1ec6-4745-88ed-011b3064046c"), new Guid("23164e2a-7a90-11ee-b962-0242ac120002"), 19 },
                    { new Guid("1989a2dd-82d6-488e-a29e-cbdfeb5b18dc"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("d228aac6-b250-4624-851d-f5436e3ddfd0"), new Guid("03164e2a-7a90-11ee-b962-0242ac120002"), 3 },
                    { new Guid("35d216c1-9847-4fcc-8f90-48dd785ca18d"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("5b9b97a8-e9b9-4ec2-9b22-a73cd7aae21f"), new Guid("13164e2a-7a90-11ee-b962-0242ac120002"), 14 },
                    { new Guid("3768dad2-a72b-4a07-8ffa-684c656a4802"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("7358c6ff-0617-45d0-85a2-db13d0f92100"), new Guid("23164e2a-7a90-11ee-b962-0242ac120002"), 20 },
                    { new Guid("42db7a66-078a-4501-bcc5-f22a73c0f7a8"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("1f697cf5-88d4-4540-bc12-cc0a7fb4a4b4"), new Guid("13164e2a-7a90-11ee-b962-0242ac120002"), 8 },
                    { new Guid("47ca39fd-46e5-42ba-a33a-cdc38850af8b"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("1ee4d6f9-543f-4e82-bfee-4fb5fbae2e76"), new Guid("13164e2a-7a90-11ee-b962-0242ac120002"), 15 },
                    { new Guid("4f4acce2-9c26-4cce-bbd8-48ab28246e8c"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("4d8e9047-5252-4b4d-a444-fd61bde84f30"), new Guid("13164e2a-7a90-11ee-b962-0242ac120002"), 6 },
                    { new Guid("51e5af57-b859-4e4b-add2-3dfcd257b042"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("ee3994db-db07-4777-b1f8-ee73dc2fdc9e"), new Guid("13164e2a-7a90-11ee-b962-0242ac120002"), 13 },
                    { new Guid("60086472-53d1-4c23-ae4b-19605550f191"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("a5abdc33-7865-487e-928f-5ce5fcc80bb8"), new Guid("23164e2a-7a90-11ee-b962-0242ac120002"), 18 },
                    { new Guid("6dcc9fdb-f969-4f2c-82ba-6911fd6e4476"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("700bbd8f-ed41-42a8-a05b-247b75e094a9"), new Guid("13164e2a-7a90-11ee-b962-0242ac120002"), 10 },
                    { new Guid("886788dd-0c1f-4432-b8e0-14ce92672e43"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("cbda2593-663c-4d1d-8fa7-fdfff22ec4ef"), new Guid("13164e2a-7a90-11ee-b962-0242ac120002"), 12 },
                    { new Guid("8add9f01-b65b-49e3-afca-b87fdba89413"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("ef4662de-f86f-4c61-ae5b-d08554ebec16"), new Guid("23164e2a-7a90-11ee-b962-0242ac120002"), 17 },
                    { new Guid("9d52c8d7-baa4-4b0a-bd67-26ecc680f2e4"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("86561683-ea1b-4817-93d5-617465998a62"), new Guid("23164e2a-7a90-11ee-b962-0242ac120002"), 16 },
                    { new Guid("ae41afcb-2cfa-445d-9be0-de741b33f86a"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("a1dda148-d324-4231-b578-f238d69fcfb8"), new Guid("03164e2a-7a90-11ee-b962-0242ac120002"), 1 },
                    { new Guid("d85eda40-0b43-407e-80e1-e4b28be86fd2"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("2886bc74-cb10-40fd-a1aa-d8fdff8da600"), new Guid("03164e2a-7a90-11ee-b962-0242ac120002"), 2 },
                    { new Guid("e52c85b4-8ee9-4d25-ad63-8c386de8734b"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("323b892f-675c-4398-a522-fe236452b845"), new Guid("03164e2a-7a90-11ee-b962-0242ac120002"), 4 },
                    { new Guid("eb7c46b1-87c6-4c73-9c80-b1b1486c2ba1"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("f7e3ba90-7bec-4a7a-b13f-546cc47bdc8d"), new Guid("13164e2a-7a90-11ee-b962-0242ac120002"), 9 },
                    { new Guid("f3b77dd2-e03a-4c07-8391-75c01513da68"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("8a7a6f0a-22d1-49ed-acac-5077ca1de851"), new Guid("13164e2a-7a90-11ee-b962-0242ac120002"), 7 },
                    { new Guid("fe30ade3-bda3-4a99-9581-f28db009d206"), new Guid("0ccacbc2-ca8a-426c-8461-e01047ec9765"), new Guid("6372e3ad-9a8c-44e1-bbf2-9de4c7f32f53"), new Guid("23164e2a-7a90-11ee-b962-0242ac120002"), 21 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckList_CheckListFormId",
                table: "CheckList",
                column: "CheckListFormId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckList_CheckListItemId",
                table: "CheckList",
                column: "CheckListItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckList_LocationId",
                table: "CheckList",
                column: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckList");

            migrationBuilder.DropTable(
                name: "CheckListForm");

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("1ee4d6f9-543f-4e82-bfee-4fb5fbae2e76"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("1f697cf5-88d4-4540-bc12-cc0a7fb4a4b4"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("2886bc74-cb10-40fd-a1aa-d8fdff8da600"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("2cdad48a-0eb7-427d-85be-06b5b3ea79e1"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("323b892f-675c-4398-a522-fe236452b845"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("4c211be7-08d2-40d6-aa53-c2fd45e44093"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("4d8e9047-5252-4b4d-a444-fd61bde84f30"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("5b9b97a8-e9b9-4ec2-9b22-a73cd7aae21f"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("6372e3ad-9a8c-44e1-bbf2-9de4c7f32f53"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("700bbd8f-ed41-42a8-a05b-247b75e094a9"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("7358c6ff-0617-45d0-85a2-db13d0f92100"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("86561683-ea1b-4817-93d5-617465998a62"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("8a7a6f0a-22d1-49ed-acac-5077ca1de851"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("a5abdc33-7865-487e-928f-5ce5fcc80bb8"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("cbda2593-663c-4d1d-8fa7-fdfff22ec4ef"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("d228aac6-b250-4624-851d-f5436e3ddfd0"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("e7c7973f-1ec6-4745-88ed-011b3064046c"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("ee3994db-db07-4777-b1f8-ee73dc2fdc9e"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("ef4662de-f86f-4c61-ae5b-d08554ebec16"));

            migrationBuilder.DeleteData(
                table: "CheckListItems",
                keyColumn: "Id",
                keyValue: new Guid("f7e3ba90-7bec-4a7a-b13f-546cc47bdc8d"));

            migrationBuilder.DropColumn(
                name: "DateOfWedding",
                table: "Members");
        }
    }
}
