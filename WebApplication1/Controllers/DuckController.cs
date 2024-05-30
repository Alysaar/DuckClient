using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class DuckController : ControllerBase
{
    [HttpGet(Name = "GetDuck")]
    public Duck Get()
    {
        return new Duck("Quack!");
    }
}