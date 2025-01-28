using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Z2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApiController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public string Get()
    {
        return "Valid response!";
    }
}