using EsyaKira.Application.Features.Mediator.Queries.ProductPricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsyaKira.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductPricingWithProductList()
        {
            var values = await _mediator.Send(new GetProductPricingWithProductQuery());
            return Ok(values);
        }
    }
}
