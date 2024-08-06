using Aranoz.Application.Mediator.Commands.ProductDetailCommands;
using Aranoz.Application.Mediator.Queries.ProductDetailQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aranoz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost] 
        public async Task<IActionResult> CreateProductDetail(CreateProductDetailCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductDetail(int id)
        {
            var result = await _mediator.Send(new DeleteProductDetailCommand(id));
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductDetailById(int id)
        {
            var result = await _mediator.Send(new GetProductDetailByIdQuery(id));
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetProductDetail()
        {
            var result = await _mediator.Send(new GetProductDetailQuery());
            return Ok(result);
        }
    }
}
