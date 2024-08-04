using Aranoz.Application.Mediator.Commands.MessageCommands;
using Aranoz.Application.Mediator.Queries.MessageQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aranoz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MessagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            var result = await _mediator.Send(new DeleteMessageCommand(id));
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMessage(UpdateMessageCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessageById(int id)
        {
            var result = await _mediator.Send(new GetMessageByIdQuery(id));
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetMessage()
        {
            var result = await _mediator.Send(new GetMessageQuery());
            return Ok(result);
        }
    }
}
