using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class TodoApiMigration4AddPersonTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_Persons_PersonId",
                table: "TodoItems");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_PersonId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "TodoItems");

            migrationBuilder.AddColumn<int>(
                name: "AssignedItemId",
                table: "Persons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AssignedItemId",
                table: "Persons",
                column: "AssignedItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_TodoItems_AssignedItemId",
                table: "Persons",
                column: "AssignedItemId",
                principalTable: "TodoItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_TodoItems_AssignedItemId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_AssignedItemId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "AssignedItemId",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "TodoItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_PersonId",
                table: "TodoItems",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_Persons_PersonId",
                table: "TodoItems",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
