
List<int> list = new List<int>() { 1, 0, 5, -4, 5, 10, -80, 24, 0, -4, 100, 24, 45, 6, -1 };

// Section 1

System.Console.WriteLine("Max = " + list.Max());
System.Console.WriteLine("------------------------------");


// Section 2


for (int i = 0; i < list.Count; i++)
{
    for (int j = 0; j < list.Count; j++)
    {
        if (list[i] == list[j])
        {
            list.Remove(list[i]);
        }
    }
}

foreach (var item in list)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("------------------------------");

// Section 3

list.Sort();
foreach (var item in list)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-----------------------------");


// Section 4

List<int> negative = list.FindAll(e => e < 0);

for (int i = 0; i < list.Count; i++)
{
    for (int j = 0; j < negative.Count; j++)
    {
        if (list[i] == list[j])
        {
            list[i] = 0;
        }
    }

}

foreach (var item in list)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("------------------------------");
