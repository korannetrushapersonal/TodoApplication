using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class TodoApiMigration8AddMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonItemMappings_Persons_ItemIdId",
                table: "PersonItemMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonItemMappings_TodoItems_PersonIdId",
                table: "PersonItemMappings");

            migrationBuilder.DropIndex(
                name: "IX_PersonItemMappings_ItemIdId",
                table: "PersonItemMappings");

            migrationBuilder.DropIndex(
                name: "IX_PersonItemMappings_PersonIdId",
                table: "PersonItemMappings");

            migrationBuilder.DropColumn(
                name: "ItemIdId",
                table: "PersonItemMappings");

            migrationBuilder.DropColumn(
                name: "PersonIdId",
                table: "PersonItemMappings");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "PersonItemMappings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "PersonItemMappings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonItemMappings_ItemId",
                table: "PersonItemMappings",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonItemMappings_PersonId",
                table: "PersonItemMappings",
                column: "PersonId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonItemMappings_Persons_ItemId",
                table: "PersonItemMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonItemMappings_TodoItems_PersonId",
                table: "PersonItemMappings");

            migrationBuilder.DropIndex(
                name: "IX_PersonItemMappings_ItemId",
                table: "PersonItemMappings");

            migrationBuilder.DropIndex(
                name: "IX_PersonItemMappings_PersonId",
                table: "PersonItemMappings");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "PersonItemMappings");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "PersonItemMappings");

            migrationBuilder.AddColumn<int>(
                name: "ItemIdId",
                table: "PersonItemMappings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonIdId",
                table: "PersonItemMappings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonItemMappings_ItemIdId",
                table: "PersonItemMappings",
                column: "ItemIdId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonItemMappings_PersonIdId",
                table: "PersonItemMappings",
                column: "PersonIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonItemMappings_Persons_ItemIdId",
                table: "PersonItemMappings",
                column: "ItemIdId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonItemMappings_TodoItems_PersonIdId",
                table: "PersonItemMappings",
                column: "PersonIdId",
                principalTable: "TodoItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
