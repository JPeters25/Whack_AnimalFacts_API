using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalFacts.solution.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facts",
                columns: table => new
                {
                    FactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnimalType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Nsfw = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facts", x => x.FactId);
                });

            migrationBuilder.InsertData(
                table: "Facts",
                columns: new[] { "FactId", "AnimalType", "Description", "Nsfw", "Species" },
                values: new object[,]
                {
                    { 1, "Mammal", "River otters will ATTACK PEOPLE", "false", "Otter" },
                    { 38, "Mammal", "A starving mouse will EAT ITS OWN TAIL", "false", "Mouse" },
                    { 39, "Mammal", "A bear can run AS FAST AS A HORSE", "false", "Bear" },
                    { 40, "Mammal", "Dolphins TORTURE THEIR PREY", "false", "Dolphin" },
                    { 41, "Mammal", "Polar Bears will EAT EACH OTHER", "false", "Polar Bear" },
                    { 42, "Marsupial", "Baby koalas EAT THEIR MOTHERS’ FECES", "false", "Koala" },
                    { 43, "Insect", "A Bullet Ant’s bite is so painful that IT FEELS LIKE BEING SHOT", "false", "Bullet Ant" },
                    { 44, "Fish", "Electric Eels can JUMP OUT OF THE WATER", "false", "Electric Eel" },
                    { 45, "Arachnid", "Spiders have CLEAR BLOOD", "false", "Spider" },
                    { 46, "Mammal", "The Romans used CRUSHED MOUSE BRAINS AS TOOTHPASTE", "false", "Mouse" },
                    { 47, "Arachnid", "Mites LIVE ON YOUR EYELASHES", "false", "Mite" },
                    { 48, "Mammal", "Hearing a Narwhal sound will MAKE YOU GO DEAF", "false", "Narwhal" },
                    { 49, "Mammal", "Because of their poor eyesight, Moose have been known to try to MATE WITH CARS", "false", "Narwhal" },
                    { 50, "Mammal", "Sloths poop turds that weigh ⅓ OF THEIR BODY WEIGHT", "false", "Sloth" },
                    { 51, "Mammal", "Manatees control their buoyancy through an ENDLESS CYCLE OF FARTING", "false", "Manatee" },
                    { 52, "Mammal", "Manatee calves NURSE IN THEIR MOTHERS’ ARMPITS", "false", "Manatee" },
                    { 53, "Marsupial", "Wombats’ poop IS CUBE-SHAPED", "false", "Wombat" },
                    { 54, "Fish", "Lobsters PEE OUT OF THEIR FACES", "false", "Lobsters" },
                    { 69, "Mammal", "During mating, the male otter will BITE THE FEMALE’S FACE", "false", "Otter" },
                    { 68, "Mammal", "Sea otters will RAPE BABY SEALS", "true", "Otter" },
                    { 66, "Insects", "For every human on Earth, there are 200 MILLION INSECTS", "false", "Insects" },
                    { 65, "Mammal", "Camel pee is THICKER THAN SYRUP", "false", "Camel" },
                    { 64, "Arachind", "Australian Funnel-Web spiders can BITE THROUGH SHOES AND FINGERNAILS", "false", "Funnel-Web Spider" },
                    { 63, "Fish", "Female brown trout will FAKE ORGASMS", null, "Brown Trout" },
                    { 37, "Mammal", "Orcas kill sharks BY SUFFOCATING THEM", "false", "Orca" },
                    { 62, "Aves", "Herring COMMUNICATE BY FARTING", "false", "Herring" },
                    { 60, "Aves", "Vultures stick their heads up other animals’ butts and EAT THEM FROM THE INSIDE OUT", "false", "Vulture" },
                    { 59, "Insect", "Millipedes SING AND GIVE BACK RUBS WHILE MATING", "false", "Milipedes" },
                    { 58, "Mammal", "A bearcat’s butthole SMELLS LIKE POPCORN", "false", "Bearcat" },
                    { 57, "Mammal", "An elephant can use its massive penis to PROP ITSELF UP", "false", "Elephant" },
                    { 56, "Fish", "The Greenland shark can LIVE FOR 272 YEARS", "false", "Shark" },
                    { 55, "Reptile", "To avoid being heard by sharks, marine iguanas can STOP THEIR OWN HEARTS", "false", "Marine Iguana" },
                    { 61, "Mammal", "Whale vaginas are AS BIG AS A KING-SIZED BED", "true", "Whales" },
                    { 70, "Mammal", "Male otters will KILL FEMALES AND RAPE THEIR CORPSES", "true", "Otter" },
                    { 36, "Reptile", "Some turtles BREATHE OUT OF THEIR BUTTS", "false", "Turtle" },
                    { 34, "Reptile", "The Mulga Snake BITES YOU IN YOUR SLEEP", "false", "Mulga Snake" },
                    { 2, "Mammal", "Sea otters will KILL FOR A GOOD TIME", "false", "Otter" },
                    { 3, "Amphibian", "Just touching the golden poison dart frog WILL KILL YOU", "false", "Poison Dart Frog" },
                    { 4, "Reptile", "Some horned lizards SQUIRT BLOOD FROM THEIR EYES", "false", "Horned Lizard" },
                    { 5, "Mollusk", "Cone snails shoot you with a DEADLY HARPOON", "false", "Cone Snail" },
                    { 6, "Arachnid", "Female black widow spiders EAT THE MALE WHILE MATING", "false", "Black Widow" },
                    { 7, "Mammal", "Vampire bats FEED ON THE BLOOD OF MAMMALS, INCLUDING HUMANS", "false", "Vampire Bat" },
                    { 8, "Mammal", "Male platypuses have POISONOUS SPURS", "false", "Platypus" },
                    { 9, "Insect", "Fruit fly swarms are just MASSIVE ORGIES", "true", "Fruit Fly" },
                    { 10, "Aves", "Petting birds TURNS THEM ON", "true", "Bird" },
                    { 11, "Aves", "Some birds keep cool by DEFECATING ON THEIR OWN FEET", "false", "Bird" },
                    { 12, "Aves", "Ducks EAT EACH OTHERS BABIES", "false", "Duck" },
                    { 13, "Mammal", "Musk is BEAVER BUTT JUICE", "false", "Beaver" },
                    { 15, "Arachnids", "After shedding their tails, scorpions DIE OF CONSTIPATION", "false", "Scorpion" },
                    { 16, "Insect", "When bees mate, their SEXUAL ORGANS EXPLODE", "true", "Bee" },
                    { 17, "Mammal", "Sloths ALMOST DIE EVERY TIME THEY POOP", "false", "Sloth" },
                    { 18, "Reptile", "Snapping turtles will EAT HUMAN CORPSES", "false", "Snapping Turtle" },
                    { 19, "Mammal", "Some wild rats can weigh UP TO 11 POUNDS", "false", "Rat" },
                    { 33, "Reptile", "King Cobras have enough venom in one bite to kill TWENTY PEOPLE", "false", "King Cobra" },
                    { 32, "Reptile", "Crocodiles can CLIMB TREES", "false", "Crocodile" },
                    { 31, "Fish", "Great White Sharks can smell blood in the water from UP TO THREE MILES AWAY", "false", "Great White Shark" },
                    { 30, "Fish", "The Sheepshead Fish has TEETH LIKE A HUMAN", "false", "Sheepshead Fish" },
                    { 29, "Mammal", "Deer will EAT HUMAN REMAINS", "false", "Deer" },
                    { 28, "Invertebrate", "Sea Cucumbers SHOOT THEIR ORGANS THROUGH THEIR BUTTS AT PREDATORS", "false", "Sea Cucumber" },
                    { 35, "Mammal", "Vampire Bats CAN RUN", "false", "Vampire Bat" },
                    { 27, "Invertebrate", "Some jellyfish can sting you EVEN AFTER THEY ARE DEAD", "false", "Jellyfish" },
                    { 25, "Marsupial", "Kangaroo mothers will SACRIFICE THEIR OWN BABIES TO STAY ALIVE", "false", "Kangaroo" },
                    { 24, "Arachnid", "Baby spiders EAT THEIR MOMS", "false", "Spider" },
                    { 23, "Mammal", "Slow loris monkeys have POISONOUS ELBOWS", "false", "Loris Monkey" },
                    { 22, "Mollusk", "Snails have RAZOR SHARP TEETH", "false", "Snail" },
                    { 21, "Insect", "Ladybugs will EAT THEIR OWN EGGS", "false", "Lady Bug" },
                    { 20, "Marsupial", "Most koalas HAVE CHLAMYDIA", "false", "Koala" },
                    { 26, "Aves", "Ostriches KICK HARD ENOUGH TO KILL YOU", "false", "Ostrich" },
                    { 71, "Mammal", "Male otters will HOLD PUPS RANSOM IN EXCHANGE FOR FOOD", "false", "Otter" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facts");
        }
    }
}
