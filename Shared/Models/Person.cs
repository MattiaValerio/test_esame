using System.Text.Json;

namespace Shared.Models;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateOnly Birth { get; set; }
    
    public Person(string name, string lastName, int age, DateOnly birth)
    {
        Name = name;
        LastName = lastName;
        Age = age;
        Birth = birth;
    }
    
    public string FullName => $"{Name} {LastName}";

    // return json representation of the object
    public string Serialize()
    {
        return JsonSerializer.Serialize(this);
    }
    
    // return object from json string
    public static Person? Deserialize(string json)
    {
        return JsonSerializer.Deserialize<Person>(json);   
    }
}
