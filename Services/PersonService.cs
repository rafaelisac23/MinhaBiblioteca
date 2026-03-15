using MinhaBibliotexa.Entities;

namespace MinhaBibliotexa.Services;

public class PersonService
{
    public List<Person> persons { get; private set;} = new List<Person>();

    public void AddPerson(Person person)
    {
        persons.Add(person);
    }
}