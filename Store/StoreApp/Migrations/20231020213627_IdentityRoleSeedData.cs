using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0882c95e-1d38-4ef8-a31f-db7e8a196e20", "75eb8748-e6d8-432f-9d98-c8bd12660935", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f0457f4-0f5e-4b21-83c6-22d2023d938a", "0cfb71ad-c592-4888-9482-f564174a7307", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48ecf9ff-d451-4ab9-b664-629eccbdce71", "6c8c14d4-f243-4bbb-961f-2e26b5963c8c", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0882c95e-1d38-4ef8-a31f-db7e8a196e20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f0457f4-0f5e-4b21-83c6-22d2023d938a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48ecf9ff-d451-4ab9-b664-629eccbdce71");
        }
    }
}
