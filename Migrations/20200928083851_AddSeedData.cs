using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstMVC.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Email", "Mobile", "Name" },
                values: new object[] { 1, "mary@gmail.com", "0922-355822", "Mary" });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Email", "Mobile", "Name" },
                values: new object[] { 2, "david@gmail.com", "0933-355822", "David" });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Email", "Mobile", "Name" },
                values: new object[] { 3, "rose@gmail.com", "0944-355822", "Rose" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
