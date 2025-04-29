using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSQLServer.Migrations
{
    /// <inheritdoc />
    public partial class BudgetItem3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BudgetItems_AspNetUsers_CreatedById",
                table: "BudgetItems");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "BudgetItems",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BudgetItems_CreatedById",
                table: "BudgetItems",
                newName: "IX_BudgetItems_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetItems_AspNetUsers_UserId",
                table: "BudgetItems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BudgetItems_AspNetUsers_UserId",
                table: "BudgetItems");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BudgetItems",
                newName: "CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_BudgetItems_UserId",
                table: "BudgetItems",
                newName: "IX_BudgetItems_CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetItems_AspNetUsers_CreatedById",
                table: "BudgetItems",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
