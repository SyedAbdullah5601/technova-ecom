using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace technova_ecom.Migrations
{
    /// <inheritdoc />
    public partial class alteringCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "category_id",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_category_id",
                table: "Product",
                column: "category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_categories_category_id",
                table: "Product",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_categories_category_id",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_category_id",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "category_id",
                table: "Product");

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
    }
}
