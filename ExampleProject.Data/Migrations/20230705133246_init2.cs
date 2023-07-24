using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleProject.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bb4abf6e-cfb0-4924-b639-4fc76bef7fec"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ce947eb9-4954-4ff6-9c9a-82d021595e22"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2ac8179a-3f45-40d2-ac0e-65d58333e265"), "dad2df8a-65f2-4c2e-938b-ea547e6ae40a", "Superadmin", "SUPERADMIN" },
                    { new Guid("bd76b238-de73-447e-bef6-424f84b844c8"), "6e373a09-e5e5-4a30-9d55-81d8916ce82c", "User", "USER" },
                    { new Guid("eebcd6ba-d079-4fde-a81a-df80076c8002"), "a69dffde-5249-4557-979b-f690b2bad6c8", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4083029d-7624-44d6-acfa-4a54deefbd3f"), 0, "41b2af1d-d9d4-4089-9476-e6e1ecdbbf9b", "admin@gmail.com", true, "Dilara", new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"), "Bozdemir", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", null, "+905000000000", true, "e5beeabc-8d3c-4713-8ee0-b6b0616da390", false, "admin@gmail.com" },
                    { new Guid("6168a092-56d5-439d-a0b8-940fbda81950"), 0, "c536bdff-29b1-498c-9f5a-f72a9d0643c4", "superadmin@gmail.com", true, "Mutlu", new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"), "Bozdemir", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEMi58VlHNbYSHsV8goPGjYtSHSPZBHxtIy8j2Kxge7Wc1/27m+M40PpghjIiybzhfA==", "+905000000000", true, "016a02c7-c38d-4425-bc3d-c77e0f6530d0", false, "superadmin@gmail.com" }
                });

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

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("5f797129-3e14-4ee4-9440-9efd4d952ebb"), new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"), ".........................", "Admin Test", new DateTime(2023, 7, 5, 16, 32, 46, 314, DateTimeKind.Local).AddTicks(771), null, null, new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"), false, null, null, "Asp.net Core Deneme Makalesi", new Guid("6168a092-56d5-439d-a0b8-940fbda81950"), 15 },
                    { new Guid("a7f53eda-5576-4ac3-99ab-ba2c8ad44d1f"), new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"), "Visual Studio.........................", "Admin Test", new DateTime(2023, 7, 5, 16, 32, 46, 314, DateTimeKind.Local).AddTicks(778), null, null, new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("4083029d-7624-44d6-acfa-4a54deefbd3f"), 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("eebcd6ba-d079-4fde-a81a-df80076c8002"), new Guid("4083029d-7624-44d6-acfa-4a54deefbd3f") },
                    { new Guid("2ac8179a-3f45-40d2-ac0e-65d58333e265"), new Guid("6168a092-56d5-439d-a0b8-940fbda81950") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Articles_UserId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5f797129-3e14-4ee4-9440-9efd4d952ebb"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a7f53eda-5576-4ac3-99ab-ba2c8ad44d1f"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("bb4abf6e-cfb0-4924-b639-4fc76bef7fec"), new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"), "Visual Studio.........................", "Admin Test", new DateTime(2023, 6, 20, 23, 50, 0, 202, DateTimeKind.Local).AddTicks(7677), null, null, new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"), false, null, null, "Visual Studio Deneme Makalesi", 15 },
                    { new Guid("ce947eb9-4954-4ff6-9c9a-82d021595e22"), new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"), ".........................", "Admin Test", new DateTime(2023, 6, 20, 23, 50, 0, 202, DateTimeKind.Local).AddTicks(7669), null, null, new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"), false, null, null, "Asp.net Core Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("282dd9b5-e65d-44ca-b319-26505de1795b"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 20, 23, 50, 0, 202, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50fa1ca4-6559-4543-b545-033bdd167c2d"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 20, 23, 50, 0, 202, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5447d768-e04d-4ee3-8cb7-cd9522df5465"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 20, 23, 50, 0, 202, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a14b14f8-a193-4940-a67f-abfef7e542a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 20, 23, 50, 0, 202, DateTimeKind.Local).AddTicks(8127));
        }
    }
}
