using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace technova_ecom.Migrations
{
    /// <inheritdoc />
    public partial class googoogaga : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "displayOrder",
                table: "categories",
                newName: "displayorder");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "categories",
                newName: "categoryName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "categories",
                newName: "categoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "displayorder",
                table: "categories",
                newName: "displayOrder");

            migrationBuilder.RenameColumn(
                name: "categoryName",
                table: "categories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "categories",
                newName: "id");
        }
    }
}
