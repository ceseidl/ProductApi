using Microsoft.AspNetCore.Mvc;
using ProductApi.Domain;

namespace ProductApi.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new Product { Id = 1, Name = "Sample Product" });
}
