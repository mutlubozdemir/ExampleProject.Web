using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleProject.Data.Migrations
{
    public partial class dataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"), "Admin Test", new DateTime(2023, 6, 20, 23, 50, 0, 202, DateTimeKind.Local).AddTicks(7970), null, null, false, null, null, "Visual Studio 2022" },
                    { new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"), "Admin Test", new DateTime(2023, 6, 20, 23, 50, 0, 202, DateTimeKind.Local).AddTicks(7965), null, null, false, null, null, "Asp.net Corew" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"), "Admin Test", new DateTime(2023, 6, 20, 23, 50, 0, 202, DateTimeKind.Local).AddTicks(8132), null, null, "images/vstest", ".png", false, null, null },
                    { new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"), "Admin Test", new DateTime(2023, 6, 20, 23, 50, 0, 202, DateTimeKind.Local).AddTicks(8127), null, null, "images/testimage", ".jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("bb4abf6e-cfb0-4924-b639-4fc76bef7fec"), new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"), "Visual Studio.........................", "Admin Test", new DateTime(2023, 6, 20, 23, 50, 0, 202, DateTimeKind.Local).AddTicks(7677), null, null, new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"), false, null, null, "Visual Studio Deneme Makalesi", 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("ce947eb9-4954-4ff6-9c9a-82d021595e22"), new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"), ".........................", "Admin Test", new DateTime(2023, 6, 20, 23, 50, 0, 202, DateTimeKind.Local).AddTicks(7669), null, null, new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"), false, null, null, "Asp.net Core Deneme Makalesi", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bb4abf6e-cfb0-4924-b639-4fc76bef7fec"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ce947eb9-4954-4ff6-9c9a-82d021595e22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"));
        }
    }
}
