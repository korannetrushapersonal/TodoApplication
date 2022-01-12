using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class TodoApiMigration9UpdateMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonItemMappings_Persons_ItemId",
                table: "PersonItemMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonItemMappings_TodoItems_PersonId",
                table: "PersonItemMappings");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonItemMappings_TodoItems_ItemId",
                table: "PersonItemMappings",
                column: "ItemId",
                principalTable: "TodoItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonItemMappings_Persons_PersonId",
                table: "PersonItemMappings",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonItemMappings_TodoItems_ItemId",
                table: "PersonItemMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonItemMappings_Persons_PersonId",
                table: "PersonItemMappings");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonItemMappings_Persons_ItemId",
                table: "PersonItemMappings",
                column: "ItemId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonItemMappings_TodoItems_PersonId",
                table: "PersonItemMappings",
                column: "PersonId",
                principalTable: "TodoItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
