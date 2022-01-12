using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class TodoApiMigration20UpdateMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_Persons_PersonId",
                table: "TodoItems");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "TodoItems",
                newName: "personid");

            migrationBuilder.RenameIndex(
                name: "IX_TodoItems_PersonId",
                table: "TodoItems",
                newName: "IX_TodoItems_personid");

            migrationBuilder.AlterColumn<int>(
                name: "personid",
                table: "TodoItems",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_Persons_personid",
                table: "TodoItems",
                column: "personid",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_Persons_personid",
                table: "TodoItems");

            migrationBuilder.RenameColumn(
                name: "personid",
                table: "TodoItems",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_TodoItems_personid",
                table: "TodoItems",
                newName: "IX_TodoItems_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "TodoItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Designation", "Name" },
                values: new object[] { 1, "Clerk", "John Drew" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Designation", "Name" },
                values: new object[] { 2, "Engineer", "James Dave" });

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
