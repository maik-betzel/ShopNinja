using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopNinja.Server.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d51a807a-9bde-42f1-89be-338eb81e95f3", "183485c7-19bf-41e8-b931-a1ba02e39d2b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3291f1a1-d7f7-4172-80ed-bb61c8b06303", "1fbd6579-410e-4701-9af5-97b04560667b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3291f1a1-d7f7-4172-80ed-bb61c8b06303");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51a807a-9bde-42f1-89be-338eb81e95f3");
        }
    }
}
