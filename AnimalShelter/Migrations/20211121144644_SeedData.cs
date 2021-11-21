using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 2, "Female", "Spot", "Dog" },
                    { 2, 1, "Female", "Molly", "Cat" },
                    { 3, 2, "Male", "Ribsy", "Dog" },
                    { 4, 3, "Male", "Spiffy", "Dog" },
                    { 5, 22, "Male", "Underdog", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Animals",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
