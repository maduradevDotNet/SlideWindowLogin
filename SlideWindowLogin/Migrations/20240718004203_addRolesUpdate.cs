using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SlideWindowLogin.Migrations
{
    /// <inheritdoc />
    public partial class addRolesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1533d623-c76f-4f2d-b27b-ebbe7f59be71", null, "client", "client" },
                    { "e3fcd55e-4b0f-4b54-8b65-886ed0476bc8", null, "seller", "seller" },
                    { "e5905168-31b9-4913-983f-8a53c3a96617", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1533d623-c76f-4f2d-b27b-ebbe7f59be71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3fcd55e-4b0f-4b54-8b65-886ed0476bc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5905168-31b9-4913-983f-8a53c3a96617");

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02012eb1-24b2-42cb-aa38-2aa21636a31a", 0, "b5fb5334-6dba-42c5-ab45-ba328f246f13", null, false, false, null, null, "seller", null, null, false, "ebe3dac3-5765-416b-a921-c00fc0cbeca8", false, "seller" },
                    { "6d2a8097-1b25-4064-8705-0e28d8c72200", 0, "41bf49a5-e04a-4c73-a6af-0d62f19e2220", null, false, false, null, null, "admin", null, null, false, "66a7c064-a1f4-477f-b4db-204b3611cf00", false, "admin" },
                    { "754f26f5-e267-4cf5-9649-bac4350bebfb", 0, "d6ebc316-0293-4d15-9be6-eafd8fadd48f", null, false, false, null, null, "client", null, null, false, "a8e2734a-4b0c-4b5d-af98-f1a222f65e2b", false, "client" }
                });
        }
    }
}
