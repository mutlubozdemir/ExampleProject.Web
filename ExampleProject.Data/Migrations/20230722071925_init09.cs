using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleProject.Data.Migrations
{
    public partial class init09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("331441f2-c04e-45b5-ab86-bb97be6133e1"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("de3ea2c5-587a-4a65-87f2-785b87d98713"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("b0ca2036-5f9f-40f7-865b-8fdf91e13506"), new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"), "Visual Studio.........................", "Admin Test", new DateTime(2023, 7, 22, 10, 19, 25, 326, DateTimeKind.Local).AddTicks(7676), null, null, new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("4083029d-7624-44d6-acfa-4a54deefbd3f"), 15 },
                    { new Guid("f0659cc5-18c2-4fba-b265-fecc7b0f8bc1"), new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"), ".........................", "Admin Test", new DateTime(2023, 7, 22, 10, 19, 25, 326, DateTimeKind.Local).AddTicks(7666), null, null, new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"), false, null, null, "Asp.net Core Deneme Makalesi", new Guid("6168a092-56d5-439d-a0b8-940fbda81950"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2ac8179a-3f45-40d2-ac0e-65d58333e265"),
                column: "ConcurrencyStamp",
                value: "fd8449a9-00a5-44dc-a1b6-29dd916044c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bd76b238-de73-447e-bef6-424f84b844c8"),
                column: "ConcurrencyStamp",
                value: "d344be19-f79d-41d0-a382-d91df898aa7c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eebcd6ba-d079-4fde-a81a-df80076c8002"),
                column: "ConcurrencyStamp",
                value: "e9689e48-ae44-461f-b3c6-56474e8a8da4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4083029d-7624-44d6-acfa-4a54deefbd3f"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b62086f-2d0e-4314-9324-e4446431a5b9", "8aabab09-2cf6-4087-bb5a-0c27dd0b2532" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6168a092-56d5-439d-a0b8-940fbda81950"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c88ad6d-a237-43e9-a4e1-e0e23dc317f6", "AQAAAAEAACcQAAAAEP/KWxZra2CwK45PmwLhVnWEgJqMLxmQuI/Q6PTH1c+mgA2JK1sYx1+02esB01siDw==", "83387c10-1f50-4767-97a4-57d03b01f1b8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 10, 19, 25, 326, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 10, 19, 25, 326, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 10, 19, 25, 326, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 10, 19, 25, 326, DateTimeKind.Local).AddTicks(8021));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b0ca2036-5f9f-40f7-865b-8fdf91e13506"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f0659cc5-18c2-4fba-b265-fecc7b0f8bc1"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("331441f2-c04e-45b5-ab86-bb97be6133e1"), new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"), ".........................", "Admin Test", new DateTime(2023, 7, 7, 15, 1, 20, 21, DateTimeKind.Local).AddTicks(8888), null, null, new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"), false, null, null, "Asp.net Core Deneme Makalesi", new Guid("6168a092-56d5-439d-a0b8-940fbda81950"), 15 },
                    { new Guid("de3ea2c5-587a-4a65-87f2-785b87d98713"), new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"), "Visual Studio.........................", "Admin Test", new DateTime(2023, 7, 7, 15, 1, 20, 21, DateTimeKind.Local).AddTicks(8895), null, null, new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("4083029d-7624-44d6-acfa-4a54deefbd3f"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2ac8179a-3f45-40d2-ac0e-65d58333e265"),
                column: "ConcurrencyStamp",
                value: "9cbce099-2f3f-40e8-ac43-b12f5046e79e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bd76b238-de73-447e-bef6-424f84b844c8"),
                column: "ConcurrencyStamp",
                value: "2437ad03-81c4-4331-bec4-7b3e23679d36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eebcd6ba-d079-4fde-a81a-df80076c8002"),
                column: "ConcurrencyStamp",
                value: "6eb4d956-a83d-47ca-b198-3382e96aae95");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4083029d-7624-44d6-acfa-4a54deefbd3f"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d1f0027-eb3e-45bb-9bc1-e2568b4e0f53", "782d0b34-7b1b-4fb2-86cd-d7ee376e3173" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6168a092-56d5-439d-a0b8-940fbda81950"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2799f75-4980-4741-9c36-b541377d53bf", "AQAAAAEAACcQAAAAEMGiMtF/mjmkMj4K5FuhRGVt+pJjXbZe73JZQQbhTIocM5V1NMDSfs8mtKoSAHDw1g==", "3b873d52-b230-47ef-8d36-a12834799bfd" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 7, 15, 1, 20, 21, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 7, 15, 1, 20, 21, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 7, 15, 1, 20, 21, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 7, 15, 1, 20, 21, DateTimeKind.Local).AddTicks(9191));
        }
    }
}
