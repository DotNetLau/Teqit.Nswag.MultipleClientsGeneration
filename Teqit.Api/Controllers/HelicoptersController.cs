using Microsoft.AspNetCore.Mvc;
using Teqit.Api.Models;

namespace Teqit.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HelicoptersController : ControllerBase
{
    [HttpGet(Name = "helicopters_getHelicopters")]
    public ActionResult<IEnumerable<Helicopter>> Get()
    {
        return new ActionResult<IEnumerable<Helicopter>>(Ok());
    } 
    
    [HttpGet("{id:int}", Name = "helicopters_getHelicopterById")]
    public ActionResult<Helicopter> GetHelicopter([FromRoute] int id)
    {
        return new ActionResult<Helicopter>(Ok(new Helicopter(id, "Heli")));
    } 
    
    [HttpPost(Name = "helicopters_createHelicopter")]
    public IActionResult Create([FromBody] string name)
    {
        return Ok();
    } 
}