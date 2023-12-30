

public class Student : Person
{
    string program;
    int year;
    double fee;

    public Student(string _name, string _address, string _program, int _year, double _fee)
     : base(_name, _address)
    {
        program = _program;
        year = _year;
        fee = _fee;
    }
    public string GetProgram()
    {
        return program;
    }
    public void SetProgram(string _program)
    {
        program = _program;
    }
    public int GetYear()
    {
        return year;
    }
    public void SetYear(int _year)
    {
        year = _year;
    }
    public double GetFee()
    {
        return fee;
    }
    public void SetFee(double _fee)
    {
        fee = _fee;
    }
    public override string ToString()
    {
        return $"Student[ {base.ToString()}, program={program}, year={year}, fee={fee} ]   ";
    }


}