using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class TodoApiMigration35UpdateMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_Persons_PersonId",
                table: "TodoItems");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_Persons_PersonId",
                table: "TodoItems",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_Persons_PersonId",
                table: "TodoItems");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_Persons_PersonId",
                table: "TodoItems",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
