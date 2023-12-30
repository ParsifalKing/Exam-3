
public class Staff : Person
{

    string school;
    double pay;

    public Staff(string _name, string _address, string _school, double _pay)
     : base(_name, _address)
    {
        school = _school;
        pay = _pay;
    }
    public string GetSchool()
    {
        return school;
    }
    public void SetSchool(string _school)
    {
        school = _school;
    }
    public double GetPay()
    {
        return pay;
    }
    public void SetPay(double _pay)
    {
        pay = _pay;
    }
    public override string ToString()
    {
        return $"Staff[ {base.ToString()}, school={school}, pay={pay} ]   ";
    }



}
