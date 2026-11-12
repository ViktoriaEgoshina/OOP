class Program
{
  static void Main(string[] args)
  {
    Animal tiger = new Animal();
    Animal bird = new Animal("Орёл", 2, 2, "Крик", TypeofAnimal.Carnivore, Habitat.Aerial, Continent.Eurasia);

    tiger.GetSound("Рык!");
    bird.PrintInfo();
  }
}
