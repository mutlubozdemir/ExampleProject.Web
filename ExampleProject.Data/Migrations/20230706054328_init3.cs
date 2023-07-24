using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleProject.Data.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5f797129-3e14-4ee4-9440-9efd4d952ebb"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a7f53eda-5576-4ac3-99ab-ba2c8ad44d1f"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("03bbcebb-d5a0-4ec5-9fd6-87a8973fdc03"), new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"), "Visual Studio.........................", "Admin Test", new DateTime(2023, 7, 6, 8, 43, 28, 206, DateTimeKind.Local).AddTicks(8769), null, null, new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("4083029d-7624-44d6-acfa-4a54deefbd3f"), 15 },
                    { new Guid("c975f8cf-46b0-492d-944f-bfe2d1408ee2"), new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"), ".........................", "Admin Test", new DateTime(2023, 7, 6, 8, 43, 28, 206, DateTimeKind.Local).AddTicks(8763), null, null, new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"), false, null, null, "Asp.net Core Deneme Makalesi", new Guid("6168a092-56d5-439d-a0b8-940fbda81950"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2ac8179a-3f45-40d2-ac0e-65d58333e265"),
                column: "ConcurrencyStamp",
                value: "1a3a4cb9-64f6-4cfe-9f4f-dd6425f55259");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bd76b238-de73-447e-bef6-424f84b844c8"),
                column: "ConcurrencyStamp",
                value: "d66c7719-d849-4562-b7a6-00591ccd31ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eebcd6ba-d079-4fde-a81a-df80076c8002"),
                column: "ConcurrencyStamp",
                value: "d17d9887-603c-4aa0-a7d0-e2bf7df5d1f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4083029d-7624-44d6-acfa-4a54deefbd3f"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0108c0ee-9363-4ccf-a4cd-17946e90bf90", "000b22cd-a7af-412b-8061-87355ac284db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6168a092-56d5-439d-a0b8-940fbda81950"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28969654-d90f-4569-9958-7a00fb26285c", "AQAAAAEAACcQAAAAEGUi7mrax4Jr8b6gxIS3+8Rn+MxaLMWdBuuq54HHORnPi2XAMfWYUFlWbWmBOYosKA==", "f3a7f59f-ec37-403e-89f7-bab5ea86dd15" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 8, 43, 28, 206, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 8, 43, 28, 206, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 8, 43, 28, 206, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 8, 43, 28, 206, DateTimeKind.Local).AddTicks(9133));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("03bbcebb-d5a0-4ec5-9fd6-87a8973fdc03"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c975f8cf-46b0-492d-944f-bfe2d1408ee2"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("5f797129-3e14-4ee4-9440-9efd4d952ebb"), new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"), ".........................", "Admin Test", new DateTime(2023, 7, 5, 16, 32, 46, 314, DateTimeKind.Local).AddTicks(771), null, null, new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"), false, null, null, "Asp.net Core Deneme Makalesi", new Guid("6168a092-56d5-439d-a0b8-940fbda81950"), 15 },
                    { new Guid("a7f53eda-5576-4ac3-99ab-ba2c8ad44d1f"), new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"), "Visual Studio.........................", "Admin Test", new DateTime(2023, 7, 5, 16, 32, 46, 314, DateTimeKind.Local).AddTicks(778), null, null, new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("4083029d-7624-44d6-acfa-4a54deefbd3f"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2ac8179a-3f45-40d2-ac0e-65d58333e265"),
                column: "ConcurrencyStamp",
                value: "dad2df8a-65f2-4c2e-938b-ea547e6ae40a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bd76b238-de73-447e-bef6-424f84b844c8"),
                column: "ConcurrencyStamp",
                value: "6e373a09-e5e5-4a30-9d55-81d8916ce82c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eebcd6ba-d079-4fde-a81a-df80076c8002"),
                column: "ConcurrencyStamp",
                value: "a69dffde-5249-4557-979b-f690b2bad6c8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4083029d-7624-44d6-acfa-4a54deefbd3f"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41b2af1d-d9d4-4089-9476-e6e1ecdbbf9b", "e5beeabc-8d3c-4713-8ee0-b6b0616da390" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6168a092-56d5-439d-a0b8-940fbda81950"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c536bdff-29b1-498c-9f5a-f72a9d0643c4", "AQAAAAEAACcQAAAAEMi58VlHNbYSHsV8goPGjYtSHSPZBHxtIy8j2Kxge7Wc1/27m+M40PpghjIiybzhfA==", "016a02c7-c38d-4425-bc3d-c77e0f6530d0" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 16, 32, 46, 314, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 16, 32, 46, 314, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 16, 32, 46, 314, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 16, 32, 46, 314, DateTimeKind.Local).AddTicks(1103));
        }
    }
}
