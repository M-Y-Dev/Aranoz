using Aranoz.Application.Mediator.Commands.ContactCommands;
using Aranoz.Application.Mediator.Commands.MessageCommands;
using Aranoz.Application.Mediator.Queries.ContactQueries;
using Aranoz.Application.Mediator.Queries.MessageQueries;
using Aranoz.Application.Mediator.Queries.ProductQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aranoz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var result = await _mediator.Send(new DeleteContactCommand(id));
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactById(int id)
        {
            var result = await _mediator.Send(new GetContactByIdQuery(id));
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetContact()
        {
            var result = await _mediator.Send(new GetContactQuery());
            return Ok(result);
        }
        [HttpGet("GetContactCount")]
        public async Task<IActionResult> GetContactCount()
        {
            var result = await _mediator.Send(new GetContactCountQuery());
            return Ok(result);
        }
        [HttpGet("GetContactWithInclude")]
        public async Task<IActionResult> GetContactWithInclude()
        {
            var result = await _mediator.Send(new GetContactWithUserIncludeQuery());
            return Ok(result);
        }
    }
}
