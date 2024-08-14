using Aranoz.Application.Mediator.Commands.OrderCommands;
using Aranoz.Application.Mediator.Commands.OrderDetailCommands;
using Aranoz.Application.Mediator.Queries.OrderDetailQueries;
using Aranoz.Application.Mediator.Queries.OrderQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aranoz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderDetailsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetOrderDetail()
        {
            var result = await _mediator.Send(new GetOrderDetailQuery());
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrderDetail(CreateOrderDetailCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderDetail(int id)
        {
            var result = await _mediator.Send(new DeleteOrderDetailCommand(id));
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOrderDetail(UpdateOrderDetailCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderDetailId(int id)
        {
            var result = await _mediator.Send(new GetOrderDetailByIdQuery(id));
            return Ok(result);
        }
    }
}
