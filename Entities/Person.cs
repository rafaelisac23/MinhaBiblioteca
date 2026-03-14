namespace MinhaBibliotexa.Entities;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int RG  { get; set; }

    public Person(int id, string name, int rg)
    {
        Id = id;
        Name = name;
        RG = rg;
    }
}