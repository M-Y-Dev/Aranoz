using Aranoz.Application.Mediator.Commands.OrderCommands;
using Aranoz.Application.Mediator.Queries.OrderQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aranoz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet] 
        public async Task <IActionResult> GetOrder()
        {
            var result = await _mediator.Send(new GetOrderQuery()); 
            return Ok(result); 
        }
        [HttpPost] 
        public async Task <IActionResult> CreateOrder(CreateOrderCommand command)
        {
            var result= await _mediator.Send(command); 
            return Ok(result);
        }

        [HttpDelete("{id}")] 
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var result= await _mediator.Send(new  DeleteOrderCommand(id));   
            return Ok(result);
        }
       [HttpPut]
        public async Task<IActionResult> UpdateOrder(UpdateOrderCommand command)
        {
            var result= await _mediator.Send(command); 
            return Ok(result);  
        }
        [HttpGet("{id}")] 
        public async Task<IActionResult> GetOrderId(int id)
        {
            var result = await _mediator.Send(new GetOrderByIdQuery(id)); 
            return Ok(result);
        }

    }
}
