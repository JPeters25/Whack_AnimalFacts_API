﻿// <auto-generated />
using AnimalFacts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalFacts.solution.Migrations
{
    [DbContext(typeof(AnimalFactsContext))]
    [Migration("20220816171214_SeedData3")]
    partial class SeedData3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalFacts.Models.Fact", b =>
                {
                    b.Property<int>("FactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnimalType")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("FactId");

                    b.ToTable("Facts");

                    b.HasData(
                        new
                        {
                            FactId = 1,
                            AnimalType = "Mammal",
                            Description = "River otters will ATTACK PEOPLE",
                            Species = "Otter"
                        },
                        new
                        {
                            FactId = 2,
                            AnimalType = "Mammal",
                            Description = "Sea otters will KILL FOR A GOOD TIME",
                            Species = "Otter"
                        },
                        new
                        {
                            FactId = 3,
                            AnimalType = "Amphibian",
                            Description = "Just touching the golden poison dart frog WILL KILL YOU",
                            Species = "Poison Dart Frog"
                        },
                        new
                        {
                            FactId = 4,
                            AnimalType = "Reptile",
                            Description = "Some horned lizards SQUIRT BLOOD FROM THEIR EYES",
                            Species = "Horned Lizard"
                        },
                        new
                        {
                            FactId = 5,
                            AnimalType = "Mollusk",
                            Description = "Cone snails shoot you with a DEADLY HARPOON",
                            Species = "Cone Snail"
                        },
                        new
                        {
                            FactId = 6,
                            AnimalType = "Arachnid",
                            Description = "Female black widow spiders EAT THE MALE WHILE MATING",
                            Species = "Black Widow"
                        },
                        new
                        {
                            FactId = 7,
                            AnimalType = "Mammal",
                            Description = "Vampire bats FEED ON THE BLOOD OF MAMMALS, INCLUDING HUMANS",
                            Species = "Vampire Bat"
                        },
                        new
                        {
                            FactId = 8,
                            AnimalType = "Mammal",
                            Description = "Male platypuses have POISONOUS SPURS",
                            Species = "Platypus"
                        },
                        new
                        {
                            FactId = 9,
                            AnimalType = "Insect",
                            Description = "Fruit fly swarms are just MASSIVE ORGIES",
                            Species = "Fruit Fly"
                        },
                        new
                        {
                            FactId = 10,
                            AnimalType = "Aves",
                            Description = "Petting birds TURNS THEM ON",
                            Species = "Bird"
                        },
                        new
                        {
                            FactId = 11,
                            AnimalType = "Aves",
                            Description = "Some birds keep cool by DEFECATING ON THEIR OWN FEET",
                            Species = "Bird"
                        },
                        new
                        {
                            FactId = 12,
                            AnimalType = "Aves",
                            Description = "Ducks EAT EACH OTHERS BABIES",
                            Species = "Duck"
                        },
                        new
                        {
                            FactId = 13,
                            AnimalType = "Mammal",
                            Description = "Musk is BEAVER BUTT JUICE",
                            Species = "Beaver"
                        },
                        new
                        {
                            FactId = 15,
                            AnimalType = "Arachnids",
                            Description = "After shedding their tails, scorpions DIE OF CONSTIPATION",
                            Species = "Scorpion"
                        },
                        new
                        {
                            FactId = 16,
                            AnimalType = "Insect",
                            Description = "When bees mate, their SEXUAL ORGANS EXPLODE",
                            Species = "Bee"
                        },
                        new
                        {
                            FactId = 17,
                            AnimalType = "Mammal",
                            Description = "Sloths ALMOST DIE EVERY TIME THEY POOP",
                            Species = "Sloth"
                        },
                        new
                        {
                            FactId = 18,
                            AnimalType = "Reptile",
                            Description = "Snapping turtles will EAT HUMAN CORPSES",
                            Species = "Snapping Turtle"
                        },
                        new
                        {
                            FactId = 19,
                            AnimalType = "Mammal",
                            Description = "Some wild rats can weigh UP TO 11 POUNDS",
                            Species = "Rat"
                        },
                        new
                        {
                            FactId = 20,
                            AnimalType = "Marsupial",
                            Description = "Most koalas HAVE CHLAMYDIA",
                            Species = "Koala"
                        },
                        new
                        {
                            FactId = 21,
                            AnimalType = "Insect",
                            Description = "Ladybugs will EAT THEIR OWN EGGS",
                            Species = "Lady Bug"
                        },
                        new
                        {
                            FactId = 22,
                            AnimalType = "Mollusk",
                            Description = "Snails have RAZOR SHARP TEETH",
                            Species = "Snail"
                        },
                        new
                        {
                            FactId = 23,
                            AnimalType = "Mammal",
                            Description = "Slow loris monkeys have POISONOUS ELBOWS",
                            Species = "Loris Monkey"
                        },
                        new
                        {
                            FactId = 24,
                            AnimalType = "Arachnid",
                            Description = "Baby spiders EAT THEIR MOMS",
                            Species = "Spider"
                        },
                        new
                        {
                            FactId = 25,
                            AnimalType = "Marsupial",
                            Description = "Kangaroo mothers will SACRIFICE THEIR OWN BABIES TO STAY ALIVE",
                            Species = "Kangaroo"
                        },
                        new
                        {
                            FactId = 26,
                            AnimalType = "Aves",
                            Description = "Ostriches KICK HARD ENOUGH TO KILL YOU",
                            Species = "Ostrich"
                        },
                        new
                        {
                            FactId = 27,
                            AnimalType = "Invertebrate",
                            Description = "Some jellyfish can sting you EVEN AFTER THEY ARE DEAD",
                            Species = "Jellyfish"
                        },
                        new
                        {
                            FactId = 28,
                            AnimalType = "Invertebrate",
                            Description = "Sea Cucumbers SHOOT THEIR ORGANS THROUGH THEIR BUTTS AT PREDATORS",
                            Species = "Sea Cucumber"
                        },
                        new
                        {
                            FactId = 29,
                            AnimalType = "Mammal",
                            Description = "Deer will EAT HUMAN REMAINS",
                            Species = "Deer"
                        },
                        new
                        {
                            FactId = 30,
                            AnimalType = "Fish",
                            Description = "The Sheepshead Fish has TEETH LIKE A HUMAN",
                            Species = "Sheepshead Fish"
                        },
                        new
                        {
                            FactId = 31,
                            AnimalType = "Fish",
                            Description = "Great White Sharks can smell blood in the water from UP TO THREE MILES AWAY",
                            Species = "Great White Shark"
                        },
                        new
                        {
                            FactId = 32,
                            AnimalType = "Reptile",
                            Description = "Crocodiles can CLIMB TREES",
                            Species = "Crocodile"
                        },
                        new
                        {
                            FactId = 33,
                            AnimalType = "Reptile",
                            Description = "King Cobras have enough venom in one bite to kill TWENTY PEOPLE",
                            Species = "King Cobra"
                        },
                        new
                        {
                            FactId = 34,
                            AnimalType = "Reptile",
                            Description = "The Mulga Snake BITES YOU IN YOUR SLEEP",
                            Species = "Mulga Snake"
                        },
                        new
                        {
                            FactId = 35,
                            AnimalType = "Mammal",
                            Description = "Vampire Bats CAN RUN",
                            Species = "Vampire Bat"
                        },
                        new
                        {
                            FactId = 36,
                            AnimalType = "Reptile",
                            Description = "Some turtles BREATHE OUT OF THEIR BUTTS",
                            Species = "Turtle"
                        },
                        new
                        {
                            FactId = 37,
                            AnimalType = "Mammal",
                            Description = "Orcas kill sharks BY SUFFOCATING THEM",
                            Species = "Orca"
                        },
                        new
                        {
                            FactId = 38,
                            AnimalType = "Mammal",
                            Description = "A starving mouse will EAT ITS OWN TAIL",
                            Species = "Mouse"
                        },
                        new
                        {
                            FactId = 39,
                            AnimalType = "Mammal",
                            Description = "A bear can run AS FAST AS A HORSE",
                            Species = "Bear"
                        },
                        new
                        {
                            FactId = 40,
                            AnimalType = "Mammal",
                            Description = "Dolphins TORTURE THEIR PREY",
                            Species = "Dolphin"
                        },
                        new
                        {
                            FactId = 41,
                            AnimalType = "Mammal",
                            Description = "Polar Bears will EAT EACH OTHER",
                            Species = "Polar Bear"
                        },
                        new
                        {
                            FactId = 42,
                            AnimalType = "Marsupial",
                            Description = "Baby koalas EAT THEIR MOTHERS’ FECES",
                            Species = "Koala"
                        },
                        new
                        {
                            FactId = 43,
                            AnimalType = "Insect",
                            Description = "A Bullet Ant’s bite is so painful that IT FEELS LIKE BEING SHOT",
                            Species = "Bullet Ant"
                        },
                        new
                        {
                            FactId = 44,
                            AnimalType = "Fish",
                            Description = "Electric Eels can JUMP OUT OF THE WATER",
                            Species = "Electric Eel"
                        },
                        new
                        {
                            FactId = 45,
                            AnimalType = "Arachnid",
                            Description = "Spiders have CLEAR BLOOD",
                            Species = "Spider"
                        },
                        new
                        {
                            FactId = 46,
                            AnimalType = "Mammal",
                            Description = "The Romans used CRUSHED MOUSE BRAINS AS TOOTHPASTE",
                            Species = "Mouse"
                        },
                        new
                        {
                            FactId = 47,
                            AnimalType = "Arachnid",
                            Description = "Mites LIVE ON YOUR EYELASHES",
                            Species = "Mite"
                        },
                        new
                        {
                            FactId = 48,
                            AnimalType = "Mammal",
                            Description = "Hearing a Narwhal sound will MAKE YOU GO DEAF",
                            Species = "Narwhal"
                        },
                        new
                        {
                            FactId = 49,
                            AnimalType = "Mammal",
                            Description = "Because of their poor eyesight, Moose have been known to try to MATE WITH CARS",
                            Species = "Narwhal"
                        },
                        new
                        {
                            FactId = 50,
                            AnimalType = "Mammal",
                            Description = "Sloths poop turds that weigh ⅓ OF THEIR BODY WEIGHT",
                            Species = "Sloth"
                        },
                        new
                        {
                            FactId = 51,
                            AnimalType = "Mammal",
                            Description = "Manatees control their buoyancy through an ENDLESS CYCLE OF FARTING",
                            Species = "Manatee"
                        },
                        new
                        {
                            FactId = 52,
                            AnimalType = "Mammal",
                            Description = "Manatee calves NURSE IN THEIR MOTHERS’ ARMPITS",
                            Species = "Manatee"
                        },
                        new
                        {
                            FactId = 53,
                            AnimalType = "Marsupial",
                            Description = "Wombats’ poop IS CUBE-SHAPED",
                            Species = "Wombat"
                        },
                        new
                        {
                            FactId = 54,
                            AnimalType = "Fish",
                            Description = "Lobsters PEE OUT OF THEIR FACES",
                            Species = "Lobsters"
                        },
                        new
                        {
                            FactId = 55,
                            AnimalType = "Reptile",
                            Description = "To avoid being heard by sharks, marine iguanas can STOP THEIR OWN HEARTS",
                            Species = "Marine Iguana"
                        },
                        new
                        {
                            FactId = 56,
                            AnimalType = "Fish",
                            Description = "The Greenland shark can LIVE FOR 272 YEARS",
                            Species = "Shark"
                        },
                        new
                        {
                            FactId = 57,
                            AnimalType = "Mammal",
                            Description = "An elephant can use its massive penis to PROP ITSELF UP",
                            Species = "Elephant"
                        },
                        new
                        {
                            FactId = 58,
                            AnimalType = "Mammal",
                            Description = "A bearcat’s butthole SMELLS LIKE POPCORN",
                            Species = "Bearcat"
                        },
                        new
                        {
                            FactId = 59,
                            AnimalType = "Insect",
                            Description = "Millipedes SING AND GIVE BACK RUBS WHILE MATING",
                            Species = "Milipedes"
                        },
                        new
                        {
                            FactId = 60,
                            AnimalType = "Aves",
                            Description = "Vultures stick their heads up other animals’ butts and EAT THEM FROM THE INSIDE OUT",
                            Species = "Vulture"
                        },
                        new
                        {
                            FactId = 61,
                            AnimalType = "Mammal",
                            Description = "Whale vaginas are AS BIG AS A KING-SIZED BED",
                            Species = "Whales"
                        },
                        new
                        {
                            FactId = 62,
                            AnimalType = "Aves",
                            Description = "Herring COMMUNICATE BY FARTING",
                            Species = "Herring"
                        },
                        new
                        {
                            FactId = 63,
                            AnimalType = "Fish",
                            Description = "Female brown trout will FAKE ORGASMS",
                            Species = "Brown Trout"
                        },
                        new
                        {
                            FactId = 64,
                            AnimalType = "Arachind",
                            Description = "Australian Funnel-Web spiders can BITE THROUGH SHOES AND FINGERNAILS",
                            Species = "Funnel-Web Spider"
                        },
                        new
                        {
                            FactId = 65,
                            AnimalType = "Mammal",
                            Description = "Camel pee is THICKER THAN SYRUP",
                            Species = "Camel"
                        },
                        new
                        {
                            FactId = 66,
                            AnimalType = "Insects",
                            Description = "For every human on Earth, there are 200 MILLION INSECTS",
                            Species = "Insects"
                        },
                        new
                        {
                            FactId = 68,
                            AnimalType = "Mammal",
                            Description = "Sea otters will RAPE BABY SEALS",
                            Species = "Otter"
                        },
                        new
                        {
                            FactId = 69,
                            AnimalType = "Mammal",
                            Description = "During mating, the male otter will BITE THE FEMALE’S FACE",
                            Species = "Otter"
                        },
                        new
                        {
                            FactId = 70,
                            AnimalType = "Mammal",
                            Description = "Male otters will KILL FEMALES AND RAPE THEIR CORPSES",
                            Species = "Otter"
                        },
                        new
                        {
                            FactId = 71,
                            AnimalType = "Mammal",
                            Description = "Male otters will HOLD PUPS RANSOM IN EXCHANGE FOR FOOD",
                            Species = "Otter"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
