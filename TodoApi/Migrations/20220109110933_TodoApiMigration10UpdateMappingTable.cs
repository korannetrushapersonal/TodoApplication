using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class TodoApiMigration10UpdateMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonItemMappings_TodoItems_ItemId",
                table: "PersonItemMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonItemMappings_Persons_PersonId",
                table: "PersonItemMappings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonItemMappings",
                table: "PersonItemMappings");

            migrationBuilder.DropIndex(
                name: "IX_PersonItemMappings_PersonId",
                table: "PersonItemMappings");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonItemMappings");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "PersonItemMappings",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "PersonItemMappings",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonItemMappings",
                table: "PersonItemMappings",
                columns: new[] { "PersonId", "ItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonItemMappings_TodoItems_ItemId",
                table: "PersonItemMappings",
                column: "ItemId",
                principalTable: "TodoItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonItemMappings_Persons_PersonId",
                table: "PersonItemMappings",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonItemMappings_TodoItems_ItemId",
                table: "PersonItemMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonItemMappings_Persons_PersonId",
                table: "PersonItemMappings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonItemMappings",
                table: "PersonItemMappings");

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "PersonItemMappings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "PersonItemMappings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PersonItemMappings",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonItemMappings",
                table: "PersonItemMappings",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PersonItemMappings_PersonId",
                table: "PersonItemMappings",
                column: "PersonId");

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
    }
}
