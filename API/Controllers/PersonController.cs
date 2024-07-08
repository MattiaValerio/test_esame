using API.Context;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly DataContext _context;

    public PersonController(DataContext context)
    {
        _context = context;
    }
    
    
    [HttpPost(Name = "AddPerson")]
    public ActionResult<Person> Post(Person person)
    {
        // add the person to the database
        _context.People.Add(person);
        
        // save the changes
        _context.SaveChanges();
        
        return Ok(person);
    }
    
    
    [HttpGet(Name = "GetPersons")]
    public ActionResult<IEnumerable<Person>> Get()
    {
        var peoples = _context.People.ToList();
        return Ok(peoples);
    }
    
    
    [HttpDelete("{id}", Name = "DeletePerson")]
    public ActionResult Delete(int id)
    {
        // find the person by id 
        var person = _context.People.Find(id);
        
        // if the person is not found return 404
        if (person == null)
        {
            return NotFound();
        }
        
        // remove the person from the database
        _context.People.Remove(person);
        
        // save the changes
        _context.SaveChanges();
        
        return Ok($"{person.FullName} has been deleted");
    }
}