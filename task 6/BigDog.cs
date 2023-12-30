

class BigDog : Dog
{

    public BigDog(string _name) : base(_name)
    {

    }

    public override void Greets()
    {
        System.Console.WriteLine("Wooow");
    }
    public override void Greets(Dog another)
    {
        System.Console.WriteLine("Woooooow");
    }
    public void Greets(BigDog another)
    {
        System.Console.WriteLine("Wooooooooooooooow");
    }



}