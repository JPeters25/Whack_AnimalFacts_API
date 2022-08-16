using Microsoft.EntityFrameworkCore;

namespace AnimalFacts.Models
{
  public class AnimalFactsContext : DbContext
  {
    public AnimalFactsContext(DbContextOptions<AnimalFactsContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Fact>()
        .HasData(
          new Fact { FactId = 1, AnimalType = "Mammal", Species = "Otter", Description="River otters will ATTACK PEOPLE" },
          new Fact { FactId = 2, AnimalType = "Mammal", Species = "Otter", Description="Sea otters will KILL FOR A GOOD TIME" },
          new Fact { FactId = 3, AnimalType = "Amphibian", Species = "Poison Dart Frog", Description="Just touching the golden poison dart frog WILL KILL YOU" },
          new Fact { FactId = 4, AnimalType = "Reptile", Species = "Horned Lizard", Description="Some horned lizards SQUIRT BLOOD FROM THEIR EYES" },
          new Fact { FactId = 5, AnimalType = "Mollusk", Species = "Cone Snail", Description="Cone snails shoot you with a DEADLY HARPOON" },
          new Fact { FactId = 6, AnimalType = "Arachnid", Species = "Black Widow", Description="Female black widow spiders EAT THE MALE WHILE MATING" },
          new Fact { FactId = 7, AnimalType = "Mammal", Species = "Vampire Bat", Description="Vampire bats FEED ON THE BLOOD OF MAMMALS, INCLUDING HUMANS" },
          new Fact { FactId = 8, AnimalType = "Mammal", Species = "Platypus", Description="Male platypuses have POISONOUS SPURS" },
          new Fact { FactId = 9, AnimalType = "Insect", Species = "Fruit Fly", Description="Fruit fly swarms are just MASSIVE ORGIES" },
          new Fact { FactId = 10, AnimalType = "Aves", Species = "Bird", Description="Petting birds TURNS THEM ON" },
          new Fact { FactId = 11, AnimalType = "Aves", Species = "Bird", Description="Some birds keep cool by DEFECATING ON THEIR OWN FEET" },
          new Fact { FactId = 12, AnimalType = "Aves", Species = "Duck", Description="Ducks EAT EACH OTHERS BABIES" },
          new Fact { FactId = 13, AnimalType = "Mammal", Species = "Beaver", Description="Musk is BEAVER BUTT JUICE" },
          new Fact { FactId = 15, AnimalType = "Arachnids", Species = "Scorpion", Description="After shedding their tails, scorpions DIE OF CONSTIPATION" },
          new Fact { FactId = 16, AnimalType = "Insect", Species = "Bee", Description="When bees mate, their SEXUAL ORGANS EXPLODE" },
          new Fact { FactId = 17, AnimalType = "Mammal", Species = "Sloth", Description="Sloths ALMOST DIE EVERY TIME THEY POOP" },
          new Fact { FactId = 18, AnimalType = "Reptile", Species = "Snapping Turtle", Description="Snapping turtles will EAT HUMAN CORPSES" },
          new Fact { FactId = 19, AnimalType = "Mammal", Species = "Rat", Description="Some wild rats can weigh UP TO 11 POUNDS" },
          new Fact { FactId = 20, AnimalType = "Marsupial", Species = "Koala", Description="Most koalas HAVE CHLAMYDIA" },
          new Fact { FactId = 21, AnimalType = "Insect", Species = "Lady Bug", Description="Ladybugs will EAT THEIR OWN EGGS" },
          new Fact { FactId = 22, AnimalType = "Mollusk", Species = "Snail", Description="Snails have RAZOR SHARP TEETH" },
          new Fact { FactId = 23, AnimalType = "Mammal", Species = "Loris Monkey", Description="Slow loris monkeys have POISONOUS ELBOWS" },
          new Fact { FactId = 24, AnimalType = "Arachnid", Species = "Spider", Description="Baby spiders EAT THEIR MOMS" },
          new Fact { FactId = 25, AnimalType = "Marsupial", Species = "Kangaroo", Description="Kangaroo mothers will SACRIFICE THEIR OWN BABIES TO STAY ALIVE" },
          new Fact { FactId = 26, AnimalType = "Aves", Species = "Ostrich", Description="Ostriches KICK HARD ENOUGH TO KILL YOU" },
          new Fact { FactId = 27, AnimalType = "Invertebrate", Species = "Jellyfish", Description="Some jellyfish can sting you EVEN AFTER THEY ARE DEAD" },
          new Fact { FactId = 28, AnimalType = "Invertebrate", Species = "Sea Cucumber", Description="Sea Cucumbers SHOOT THEIR ORGANS THROUGH THEIR BUTTS AT PREDATORS" },
          new Fact { FactId = 29, AnimalType = "Mammal", Species = "Deer", Description="Deer will EAT HUMAN REMAINS" },
          new Fact { FactId = 30, AnimalType = "Fish", Species = "Sheepshead Fish", Description="The Sheepshead Fish has TEETH LIKE A HUMAN" },
          new Fact { FactId = 31, AnimalType = "Fish", Species = "Great White Shark", Description="Great White Sharks can smell blood in the water from UP TO THREE MILES AWAY" },
          new Fact { FactId = 32, AnimalType = "Reptile", Species = "Crocodile", Description="Crocodiles can CLIMB TREES" },
          new Fact { FactId = 33, AnimalType = "Reptile", Species = "King Cobra", Description="King Cobras have enough venom in one bite to kill TWENTY PEOPLE" },
          new Fact { FactId = 34, AnimalType = "Reptile", Species = "Mulga Snake", Description="The Mulga Snake BITES YOU IN YOUR SLEEP" },
          new Fact { FactId = 35, AnimalType = "Mammal", Species = "Vampire Bat", Description="Vampire Bats CAN RUN" },
          new Fact { FactId = 36, AnimalType = "Reptile", Species = "Turtle", Description="Some turtles BREATHE OUT OF THEIR BUTTS" },
          new Fact { FactId = 37, AnimalType = "Mammal", Species = "Orca", Description="Orcas kill sharks BY SUFFOCATING THEM" },
          new Fact { FactId = 38, AnimalType = "Mammal", Species = "Mouse", Description="A starving mouse will EAT ITS OWN TAIL" },
          new Fact { FactId = 39, AnimalType = "Mammal", Species = "Bear", Description="A bear can run AS FAST AS A HORSE" },
          new Fact { FactId = 40, AnimalType = "Mammal", Species = "Dolphin", Description="Dolphins TORTURE THEIR PREY" },
          new Fact { FactId = 41, AnimalType = "Mammal", Species = "Polar Bear", Description="Polar Bears will EAT EACH OTHER" },
          new Fact { FactId = 42, AnimalType = "Marsupial", Species = "Koala", Description="Baby koalas EAT THEIR MOTHERS’ FECES" },
          new Fact { FactId = 43, AnimalType = "Insect", Species = "Bullet Ant", Description="A Bullet Ant’s bite is so painful that IT FEELS LIKE BEING SHOT" },
          new Fact { FactId = 44, AnimalType = "Fish", Species = "Electric Eel", Description="Electric Eels can JUMP OUT OF THE WATER" },
          new Fact { FactId = 45, AnimalType = "Arachnid", Species = "Spider", Description="Spiders have CLEAR BLOOD" },
          new Fact { FactId = 46, AnimalType = "Mammal", Species = "Mouse", Description="The Romans used CRUSHED MOUSE BRAINS AS TOOTHPASTE" },
          new Fact { FactId = 47, AnimalType = "Arachnid", Species = "Mite", Description="Mites LIVE ON YOUR EYELASHES" },
          new Fact { FactId = 48, AnimalType = "Mammal", Species = "Narwhal", Description="Hearing a Narwhal sound will MAKE YOU GO DEAF" },
          new Fact { FactId = 49, AnimalType = "Mammal", Species = "Narwhal", Description="Because of their poor eyesight, Moose have been known to try to MATE WITH CARS" },
          new Fact { FactId = 50, AnimalType = "Mammal", Species = "Sloth", Description="Sloths poop turds that weigh ⅓ OF THEIR BODY WEIGHT" },
          new Fact { FactId = 51, AnimalType = "Mammal", Species = "Manatee", Description="Manatees control their buoyancy through an ENDLESS CYCLE OF FARTING" },
          new Fact { FactId = 52, AnimalType = "Mammal", Species = "Manatee", Description="Manatee calves NURSE IN THEIR MOTHERS’ ARMPITS" },
          new Fact { FactId = 53, AnimalType = "Marsupial", Species = "Wombat", Description="Wombats’ poop IS CUBE-SHAPED" },
          new Fact { FactId = 54, AnimalType = "Fish", Species = "Lobsters", Description="Lobsters PEE OUT OF THEIR FACES" },
          new Fact { FactId = 55, AnimalType = "Reptile", Species = "Marine Iguana", Description="To avoid being heard by sharks, marine iguanas can STOP THEIR OWN HEARTS" },
          new Fact { FactId = 56, AnimalType = "Fish", Species = "Shark", Description="The Greenland shark can LIVE FOR 272 YEARS" },
          new Fact { FactId = 57, AnimalType = "Mammal", Species = "Elephant", Description="An elephant can use its massive penis to PROP ITSELF UP" },
          new Fact { FactId = 58, AnimalType = "Mammal", Species = "Bearcat", Description="A bearcat’s butthole SMELLS LIKE POPCORN" },
          new Fact { FactId = 59, AnimalType = "Insect", Species = "Milipedes", Description="Millipedes SING AND GIVE BACK RUBS WHILE MATING" },
          new Fact { FactId = 60, AnimalType = "Aves", Species = "Vulture", Description="Vultures stick their heads up other animals’ butts and EAT THEM FROM THE INSIDE OUT" },
          new Fact { FactId = 61, AnimalType = "Mammal", Species = "Whales", Description="Whale vaginas are AS BIG AS A KING-SIZED BED" },
          new Fact { FactId = 62, AnimalType = "Aves", Species = "Herring", Description="Herring COMMUNICATE BY FARTING" },
          new Fact { FactId = 63, AnimalType = "Fish", Species = "Brown Trout", Description="Female brown trout will FAKE ORGASMS" },
          new Fact { FactId = 64, AnimalType = "Arachind", Species = "Funnel-Web Spider", Description="Australian Funnel-Web spiders can BITE THROUGH SHOES AND FINGERNAILS" },
          new Fact { FactId = 65, AnimalType = "Mammal", Species = "Camel", Description="Camel pee is THICKER THAN SYRUP" },
          new Fact { FactId = 66, AnimalType = "Insects", Species = "Insects", Description="For every human on Earth, there are 200 MILLION INSECTS" },
          new Fact { FactId = 68, AnimalType = "Mammal", Species = "Otter", Description="Sea otters will RAPE BABY SEALS" },
          new Fact { FactId = 69, AnimalType = "Mammal", Species = "Otter", Description="During mating, the male otter will BITE THE FEMALE’S FACE" },
          new Fact { FactId = 70, AnimalType = "Mammal", Species = "Otter", Description="Male otters will KILL FEMALES AND RAPE THEIR CORPSES" },
          new Fact { FactId = 71, AnimalType = "Mammal", Species = "Otter", Description="Male otters will HOLD PUPS RANSOM IN EXCHANGE FOR FOOD" }
        );
    }
      
      public DbSet<Fact> Facts { get; set; }
  }
}