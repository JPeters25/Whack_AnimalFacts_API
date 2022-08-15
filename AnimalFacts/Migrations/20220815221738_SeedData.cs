using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalFacts.solution.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 1,
                column: "Description",
                value: "River otters will ATTACK PEOPLE");

            migrationBuilder.InsertData(
                table: "Facts",
                columns: new[] { "FactId", "AnimalType", "Description", "Species" },
                values: new object[,]
                {
                    { 2, "Mammal", "Sea otters will KILL FOR A GOOD TIME", "Otter" },
                    { 3, "Amphibian", "Just touching the golden poison dart frog WILL KILL YOU", "Poison Dart Frog" },
                    { 4, "Reptile", "Some horned lizards SQUIRT BLOOD FROM THEIR EYES", "Horned Lizard" },
                    { 5, "Mollusk", "Cone snails shoot you with a DEADLY HARPOON", "Cone Snail" },
                    { 6, "Arachnids", "Female black widow spiders EAT THE MALE WHILE MATING", "Black Widow" },
                    { 7, "Mammal", "Vampire bats FEED ON THE BLOOD OF MAMMALS, INCLUDING HUMANS", "Vampire Bat" },
                    { 8, "Mammal", "Male platypuses have POISONOUS SPURS", "Platypus" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 1,
                column: "Description",
                value: "Otters are bad, proven by science");
        }
    }
}
