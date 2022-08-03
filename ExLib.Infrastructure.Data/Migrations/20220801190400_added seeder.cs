using Microsoft.EntityFrameworkCore.Migrations;

namespace ExLib.Infrastructure.Data.Migrations
{
    public partial class addedseeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookLocation",
                columns: new[] { "Id", "IsActive", "Location" },
                values: new object[,]
                {
                    { 1, true, "Exactus Office" },
                    { 2, true, "Owner's Home" },
                    { 3, true, "In the Matrix" }
                });

            migrationBuilder.InsertData(
                table: "BookStatus",
                columns: new[] { "Id", "IsActive", "Status" },
                values: new object[,]
                {
                    { 1, true, "Available" },
                    { 2, true, "Checked Out" },
                    { 3, true, "Damaged" },
                    { 4, true, "Lost" }
                });

            migrationBuilder.InsertData(
                table: "BookType",
                columns: new[] { "Id", "IsActive", "Type" },
                values: new object[,]
                {
                    { 1, true, "Hardcover" },
                    { 2, true, "Paperback" },
                    { 3, true, "Digital Copy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookLocation",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookStatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookType",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
