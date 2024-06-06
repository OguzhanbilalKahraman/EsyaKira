using EsyaKira.Application.Features.CQRS.Commands.ProductCommands;
using EsyaKira.Application.Features.CQRS.Handlers.ProductHandlers;
using EsyaKira.Application.Features.CQRS.Queries.ProductQueries;
using Microsoft.AspNetCore.Mvc;

namespace EsyaKira.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductWithBrandQueryHandler _getProductWithBrandQueryHandler;
        private readonly GetLast5ProductsWithBrandQueryHandler _getLast5ProductsWithBrandQueryHandler;

        public ProductsController(CreateProductCommandHandler createProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler, GetProductQueryHandler getProductQueryHandler, UpdateProductCommandHandler updateProductCommandHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductWithBrandQueryHandler getProductWithBrandQueryHandler, GetLast5ProductsWithBrandQueryHandler getLast5ProductsWithBrandQueryHandler)
        {
            _createProductCommandHandler = createProductCommandHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
            _getProductQueryHandler = getProductQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getProductWithBrandQueryHandler = getProductWithBrandQueryHandler;
            _getLast5ProductsWithBrandQueryHandler = getLast5ProductsWithBrandQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _getProductQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var value = await _getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            await _createProductCommandHandler.Handle(command);
            return Ok("Urun Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveProduct(int id)
        {
            await _removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return Ok("Urun Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            await _updateProductCommandHandler.Handle(command);
            return Ok("Urun Bilgisi Güncellendi");
        }

        [HttpGet("GetProductWithBrand")]
        public IActionResult GetProductWithBrand()
        {
            var values = _getProductWithBrandQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("GetLast5ProductsWithBrandQueryHandler")]
        public IActionResult GetLast5ProductsWithBrandQueryHandler()
        {
            var values = _getLast5ProductsWithBrandQueryHandler.Handle();
            return Ok(values);
        }
    }
}
