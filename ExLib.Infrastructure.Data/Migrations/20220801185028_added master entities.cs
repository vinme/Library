using Microsoft.EntityFrameworkCore.Migrations;

namespace ExLib.Infrastructure.Data.Migrations
{
    public partial class addedmasterentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookLocationId",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookStatusId",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookTypeId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookLocation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookLocationId",
                table: "Books",
                column: "BookLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookStatusId",
                table: "Books",
                column: "BookStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookTypeId",
                table: "Books",
                column: "BookTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookLocation_BookLocationId",
                table: "Books",
                column: "BookLocationId",
                principalTable: "BookLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookStatus_BookStatusId",
                table: "Books",
                column: "BookStatusId",
                principalTable: "BookStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookType_BookTypeId",
                table: "Books",
                column: "BookTypeId",
                principalTable: "BookType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookLocation_BookLocationId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookStatus_BookStatusId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookType_BookTypeId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookLocation");

            migrationBuilder.DropTable(
                name: "BookStatus");

            migrationBuilder.DropTable(
                name: "BookType");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookLocationId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookStatusId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookTypeId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookLocationId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookStatusId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookTypeId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "Location",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
