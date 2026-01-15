using Microsoft.AspNetCore.Mvc;
using Teqit.Api.Models;

namespace Teqit.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AirplanesController : ControllerBase
{
    [HttpGet(Name = "airplanes_getAirplanes")]
    public ActionResult<IEnumerable<Airplane>> Get()
    {
        return new ActionResult<IEnumerable<Airplane>>(Ok());
    } 
    
    [HttpGet("{id:int}", Name = "airplanes_getAirplaneById")]
    public ActionResult<Airplane> GetAirplane([FromRoute] int id)
    {
        return new ActionResult<Airplane>(Ok(new Airplane(id, "Airplane")));
    } 
    
    [HttpPost(Name = "airplanes_createAirplane")]
    public IActionResult Create([FromBody] string name)
    {
        return Ok();
    } 
}