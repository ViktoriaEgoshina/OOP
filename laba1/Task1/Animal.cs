class Animal
{
  private string _name;
  private  int _age;
  private int _numOfLimbs;

  private string _typeOfSound;
  private TypeofAnimal _type;
  private Habitat _habitat;
  private Continent _continent;
  
  // Базовый
  public Animal()
  {
    _name = "Тигр";
    _age = 3;
    _numOfLimbs = 4;
    _type = TypeofAnimal.Carnivore;
    _habitat = Habitat.Terrestrial;
    _continent = Continent.Eurasia;
    _typeOfSound = "Рык";
  }

  // С параметрами 
  public Animal(string name, int age, int numOfLimbs, string typeOfSound, TypeofAnimal type, Habitat habitat, Continent continent)
  {
    _name = name;
    _age = age;
    _numOfLimbs = numOfLimbs;
    _type = type;
    _habitat = habitat;
    _continent = continent;
    _typeOfSound = typeOfSound;
  }

  // Перегрузить - переопределить 
  public static bool operator ==(Animal firstAnimal, Animal secondAnimal)
  {
    return ((firstAnimal._name == secondAnimal._name)
          && (firstAnimal._age == secondAnimal._age)
          && (firstAnimal._numOfLimbs == secondAnimal._numOfLimbs)
          && (firstAnimal._type == secondAnimal._type)
          && (firstAnimal._habitat == secondAnimal._habitat)
          && (firstAnimal._continent == secondAnimal._continent))
          ? true
          : false;
  }

    public static bool operator !=(Animal firstAnimal, Animal secondAnimal)
  {
    return !(firstAnimal == secondAnimal);
         
  }

  public void GetSound()
  {
    Console.WriteLine($"{_name} издает {_typeOfSound}");
  }

  public bool CanFly()
  {
    return (_habitat == Habitat.Aerial) ? true : false;
  }

   public bool CanSwim()
  {
    return (_habitat == Habitat.Aquatic || _habitat == Habitat.Amphious) ? true : false;
  }

  public void ExsistTail(string text)
  {
    if (text == "да")
    {
      Console.WriteLine($"У {_name} есть хвост!");
    } 
    else
    {
      Console.WriteLine($"У {_name} нет хвоста!");
    } 
  }

  public string Name
  {
    get {return _name; }
  }

  public int Age
  {
    set
    {
      if (value <= 0) 
      Console.WriteLine("Ввод недопустимого значения");
      else
      _age = value;
    }
  }

  public void PrintInfo()
  {
    Console.WriteLine($"Животное - {_name}, возраст - {_age}, кол-во конечностей - {_numOfLimbs}, среда обитания - {_habitat}, континент - {_continent}");
  }
}