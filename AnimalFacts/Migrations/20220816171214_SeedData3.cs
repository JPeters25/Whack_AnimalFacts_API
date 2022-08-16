using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalFacts.solution.Migrations
{
    public partial class SeedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Facts",
                columns: new[] { "FactId", "AnimalType", "Description", "Species" },
                values: new object[,]
                {
                    { 54, "Fish", "Lobsters PEE OUT OF THEIR FACES", "Lobsters" },
                    { 69, "Mammal", "During mating, the male otter will BITE THE FEMALE’S FACE", "Otter" },
                    { 68, "Mammal", "Sea otters will RAPE BABY SEALS", "Otter" },
                    { 66, "Insects", "For every human on Earth, there are 200 MILLION INSECTS", "Insects" },
                    { 65, "Mammal", "Camel pee is THICKER THAN SYRUP", "Camel" },
                    { 64, "Arachind", "Australian Funnel-Web spiders can BITE THROUGH SHOES AND FINGERNAILS", "Funnel-Web Spider" },
                    { 63, "Fish", "Female brown trout will FAKE ORGASMS", "Brown Trout" },
                    { 70, "Mammal", "Male otters will KILL FEMALES AND RAPE THEIR CORPSES", "Otter" },
                    { 62, "Aves", "Herring COMMUNICATE BY FARTING", "Herring" },
                    { 60, "Aves", "Vultures stick their heads up other animals’ butts and EAT THEM FROM THE INSIDE OUT", "Vulture" },
                    { 59, "Insect", "Millipedes SING AND GIVE BACK RUBS WHILE MATING", "Milipedes" },
                    { 58, "Mammal", "A bearcat’s butthole SMELLS LIKE POPCORN", "Bearcat" },
                    { 57, "Mammal", "An elephant can use its massive penis to PROP ITSELF UP", "Elephant" },
                    { 56, "Fish", "The Greenland shark can LIVE FOR 272 YEARS", "Shark" },
                    { 55, "Reptile", "To avoid being heard by sharks, marine iguanas can STOP THEIR OWN HEARTS", "Marine Iguana" },
                    { 61, "Mammal", "Whale vaginas are AS BIG AS A KING-SIZED BED", "Whales" },
                    { 71, "Mammal", "Male otters will HOLD PUPS RANSOM IN EXCHANGE FOR FOOD", "Otter" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 71);
        }
    }
}
