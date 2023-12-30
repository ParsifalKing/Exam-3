
class Cat : Animal
{
    public Cat(string _name) : base(_name)
    {

    }

    public override void Greets()
    {
        System.Console.WriteLine("Meow");
    }

}