using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Shared.Models;

public class Person
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateOnly Birth { get; set; }
    
    public Person()
    {
        Age = CalculateAge();
    }
    public Person(int id, string name, string lastName,DateOnly birth)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Birth = birth;
        Age = CalculateAge();
    }
    public Person(string name, string lastName, DateOnly birth)
    {
        Name = name;
        LastName = lastName;
        Birth = birth;
        Age = CalculateAge();
    }
    
    public string FullName => $"{Name} {LastName}";
    private int CalculateAge()
    {
        return DateTime.Now.Year - Birth.Year;
    }
    
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
