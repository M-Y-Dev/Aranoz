using Aranoz.Application.Mediator.Commands.AppUserCommands;
using Aranoz.Application.Mediator.Queries.AppUserQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aranoz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    { 
        private readonly IMediator _mediator;

        public AppUsersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet] 
        public async Task<IActionResult> GetUser()
        {
            var result = await _mediator.Send(new GetAppUserQuery()); 
           return Ok(result);
        }
        [HttpPost] 
        public async Task<IActionResult> CreateUser(CreateAppUserCommand createAppUserCommand)
        {
            var result= await _mediator.Send(createAppUserCommand); 
            return Ok(result);
        }
        [HttpDelete("{id}")] 
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result= await _mediator.Send(new DeleteAppUserCommand(id)); 
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateAppUserCommand updateAppUserCommand)
        {
            var result = await _mediator.Send(updateAppUserCommand); 
            return Ok(result);
        }
        [HttpGet("{id}")]  
        public async Task<IActionResult> GetUserId(int id)
        {
            var result= await _mediator.Send(new GetAppUserByIdQuery(id));
            return Ok(result);
        }
    }
}
