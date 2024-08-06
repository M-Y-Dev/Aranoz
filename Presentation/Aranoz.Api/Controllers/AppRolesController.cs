using Aranoz.Application.Mediator.Commands.AppRoleCommands;
using Aranoz.Application.Mediator.Queries.AppRoleQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Asn1;

namespace Aranoz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppRolesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppRolesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAppRole()
        {
            var result = await _mediator.Send(new GetAppRoleQuery());
            return Ok(result);

        }
        [HttpPost]
        public async Task<IActionResult> CreateAppRole(CreateAppRoleCommand createAppRoleCommand)
        {
            var result = await _mediator.Send(createAppRoleCommand);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApprRole(int id)
        {
            var result = await _mediator.Send(new DeleteAppRoleCommand(id));
            return Ok(result);
        }
        [HttpPut] 
        public async Task<IActionResult> UpdateRole(UpdateAppRoleCommand updateAppRoleCommand)
        {
            var result = await _mediator.Send(updateAppRoleCommand);
            return Ok(result);
        }
        [HttpGet("{id}")] 
        public async Task<IActionResult> GetAppRoleId(int id)
        {
            var result= await _mediator.Send(new GetAppRoleByIdQuery(id)); 
            return Ok(result);
        }
    }
}
