
public class Person
{
    string name;
    string address;

    public Person(string _name, string _address)
    {
        name = _name;
        address = _address;
    }
    public string GetName()
    {
        return name;
    }
    public string GetAddress()
    {
        return address;
    }
    public void SetAddress(string _address)
    {
        address = _address;
    }
    public override string ToString()
    {
        return $" Person[ name={name}, address={address}] ";
    }


}