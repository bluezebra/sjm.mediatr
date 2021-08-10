using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using sjm.mediatr.Commands;
using sjm.mediatr.Queries;

namespace sjm.mediatr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await _mediator.Send(new GetProductsQuery());

            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] Product product)
        {
            await _mediator.Send(new AddProductCommand(product));

            return StatusCode(201);
        }
    }
}
