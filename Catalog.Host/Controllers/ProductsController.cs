using Catalog.Host.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly Product[] Products = new[]
    {
        new Product()
        {
            Title = "TV",
            Description = "Shows movies",
            Price = 350
        },
        new Product()
        {
            Title = "Stereo system",
            Description = "Plays music",
            Price = 275
        },
        new Product()
        {
            Title = "Vacuum cleaner",
            Description = "Destroys stars",
            Price = 180
        }
    };

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProducts")]
    public IEnumerable<Product> Get()
    {
        return Products;
    }
}