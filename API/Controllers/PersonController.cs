using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    [HttpGet(Name = "GetPersons")]
    public ActionResult<IEnumerable<Person>> Get()
    {
        return Ok(new List<Person>
        {
            new Person("John", "Doe", 25, new DateOnly(1996, 10, 10)),
            new Person("Jane", "Doe", 22, new DateOnly(1999, 5, 5))
        });
    }
}