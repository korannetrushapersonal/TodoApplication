using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class updateseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Designation", "Name" },
                values: new object[] { 1, "Clerk", "John Drew" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Designation", "Name" },
                values: new object[] { 2, "Engineer", "James Dave" });

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "ItemId", "Description", "PersonId", "Title" },
                values: new object[,]
                {
                    { 1, "Please send the work email to Mark", 1, "Send Email to Mark" },
                    { 4, "Please pick up Task2", 1, "Please pick up Task2" },
                    { 2, "Please contact James for XYZ reasons", 2, "Contact James" },
                    { 3, "Please contact James for XYZ reasons", 2, "Contact James" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2);
        }
    }
}
