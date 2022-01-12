using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class TodoApiMigration32UpdateMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_Persons_personid",
                table: "TodoItems");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_personid",
                table: "TodoItems");

            migrationBuilder.RenameColumn(
                name: "personid",
                table: "TodoItems",
                newName: "PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "TodoItems",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "TodoItems",
                newName: "personid");

            migrationBuilder.AlterColumn<int>(
                name: "personid",
                table: "TodoItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_personid",
                table: "TodoItems",
                column: "personid");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_Persons_personid",
                table: "TodoItems",
                column: "personid",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
