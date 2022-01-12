using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class TodoApiMigration5AddMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedItemId",
                table: "Persons",
                type: "int",
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
    }
}
