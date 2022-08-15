using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalFacts.solution.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 6,
                column: "AnimalType",
                value: "Arachnid");

            migrationBuilder.InsertData(
                table: "Facts",
                columns: new[] { "FactId", "AnimalType", "Description", "Species" },
                values: new object[,]
                {
                    { 34, "Reptile", "The Mulga Snake BITES YOU IN YOUR SLEEP", "Mulga Snake" },
                    { 35, "Mammal", "Vampire Bats CAN RUN", "Vampire Bat" },
                    { 36, "Reptile", "Some turtles BREATHE OUT OF THEIR BUTTS", "Turtle" },
                    { 37, "Mammal", "Orcas kill sharks BY SUFFOCATING THEM", "Orca" },
                    { 38, "Mammal", "A starving mouse will EAT ITS OWN TAIL", "Mouse" },
                    { 39, "Mammal", "A bear can run AS FAST AS A HORSE", "Bear" },
                    { 40, "Mammal", "Dolphins TORTURE THEIR PREY", "Dolphin" },
                    { 41, "Mammal", "Polar Bears will EAT EACH OTHER", "Polar Bear" },
                    { 42, "Marsupial", "Baby koalas EAT THEIR MOTHERS’ FECES", "Koala" },
                    { 43, "Insect", "A Bullet Ant’s bite is so painful that IT FEELS LIKE BEING SHOT", "Bullet Ant" },
                    { 44, "Fish", "Electric Eels can JUMP OUT OF THE WATER", "Electric Eel" },
                    { 45, "Arachnid", "Spiders have CLEAR BLOOD", "Spider" },
                    { 46, "Mammal", "The Romans used CRUSHED MOUSE BRAINS AS TOOTHPASTE", "Mouse" },
                    { 47, "Arachnid", "Mites LIVE ON YOUR EYELASHES", "Mite" },
                    { 48, "Mammal", "Hearing a Narwhal sound will MAKE YOU GO DEAF", "Narwhal" },
                    { 49, "Mammal", "Because of their poor eyesight, Moose have been known to try to MATE WITH CARS", "Narwhal" },
                    { 50, "Mammal", "Sloths poop turds that weigh ⅓ OF THEIR BODY WEIGHT", "Sloth" },
                    { 51, "Mammal", "Manatees control their buoyancy through an ENDLESS CYCLE OF FARTING", "Manatee" },
                    { 52, "Mammal", "Manatee calves NURSE IN THEIR MOTHERS’ ARMPITS", "Manatee" },
                    { 33, "Reptile", "King Cobras have enough venom in one bite to kill TWENTY PEOPLE", "King Cobra" },
                    { 53, "Marsupial", "Wombats’ poop IS CUBE-SHAPED", "Wombat" },
                    { 32, "Reptile", "Crocodiles can CLIMB TREES", "Crocodile" },
                    { 30, "Fish", "The Sheepshead Fish has TEETH LIKE A HUMAN", "Sheepshead Fish" },
                    { 10, "Aves", "Petting birds TURNS THEM ON", "Bird" },
                    { 11, "Aves", "Some birds keep cool by DEFECATING ON THEIR OWN FEET", "Bird" },
                    { 12, "Aves", "Ducks EAT EACH OTHERS BABIES", "Duck" },
                    { 13, "Mammal", "Musk is BEAVER BUTT JUICE", "Beaver" },
                    { 15, "Arachnids", "After shedding their tails, scorpions DIE OF CONSTIPATION", "Scorpion" },
                    { 16, "Insect", "When bees mate, their SEXUAL ORGANS EXPLODE", "Bee" },
                    { 17, "Mammal", "Sloths ALMOST DIE EVERY TIME THEY POOP", "Sloth" },
                    { 18, "Reptile", "Snapping turtles will EAT HUMAN CORPSES", "Snapping Turtle" },
                    { 19, "Mammal", "Some wild rats can weigh UP TO 11 POUNDS", "Rat" },
                    { 20, "Marsupial", "Most koalas HAVE CHLAMYDIA", "Koala" },
                    { 21, "Insect", "Ladybugs will EAT THEIR OWN EGGS", "Lady Bug" },
                    { 22, "Mollusk", "Snails have RAZOR SHARP TEETH", "Snail" },
                    { 23, "Mammal", "Slow loris monkeys have POISONOUS ELBOWS", "Loris Monkey" },
                    { 24, "Arachnid", "Baby spiders EAT THEIR MOMS", "Spider" },
                    { 25, "Marsupial", "Kangaroo mothers will SACRIFICE THEIR OWN BABIES TO STAY ALIVE", "Kangaroo" },
                    { 26, "Aves", "Ostriches KICK HARD ENOUGH TO KILL YOU", "Ostrich" },
                    { 27, "Invertebrate", "Some jellyfish can sting you EVEN AFTER THEY ARE DEAD", "Jellyfish" },
                    { 28, "Invertebrate", "Sea Cucumbers SHOOT THEIR ORGANS THROUGH THEIR BUTTS AT PREDATORS", "Sea Cucumber" },
                    { 29, "Mammal", "Deer will EAT HUMAN REMAINS", "Deer" },
                    { 31, "Fish", "Great White Sharks can smell blood in the water from UP TO THREE MILES AWAY", "Great White Shark" },
                    { 9, "Insect", "Fruit fly swarms are just MASSIVE ORGIES", "Fruit Fly" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 53);

            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 6,
                column: "AnimalType",
                value: "Arachnids");
        }
    }
}
