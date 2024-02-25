namespace AnimalInheritance;
// base Class 
class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}
//derived class of Animal Class B
class Horses : Animal
{
    public string breed;
    public int height;
    public int weight;

    public void setHeight(int height)
    {
        this.height = height;
    }
    public virtual int getHeight()
    {
        return height;
    }
    public void setWeight(int weight)
    {
        this.weight = weight;
    }
    public virtual int getWeight()
    {
        return weight;
    }
    //is private
    public override string getName()
    {
        return base.getName();
    }
    //is protected
    public override string getType()
    {
        return type;
    }

}
class Program
{
    static void Main(string[] args)
    {
        //object of the bas class Animal
        Animal info = new Animal();
        //private or protected
        info.setName("Sparky");
        info.setType("Dog");
        //public
        info.color = "White";

        Console.WriteLine("Animal Information");
        Console.WriteLine($"Name= {info.getName()}");
        Console.WriteLine($"Type= {info.getType()}");
        Console.WriteLine($"Color= {info.color}");
        Console.WriteLine();

        //class horse
        Horses horse = new Horses();
        horse.setName("Sam");
        horse.setType("Horse");
        horse.color = "Black";
        horse.breed = "Stallion";
        horse.height = 7;
        horse.weight = 1500;

        Console.WriteLine("Horse Information");
        Console.WriteLine($"Name= {horse.getName()}");
        Console.WriteLine($"Type= {horse.getType()}");
        Console.WriteLine($"Color= {horse.color}");
        Console.WriteLine($"Breed= {horse.breed}");
        Console.WriteLine($"Height= {horse.height} Hands");
        Console.WriteLine($"Weight= {horse.weight}");
        Console.ReadKey();
    }
}

