﻿using Aranoz.Application.Mediator.Commands.AddressCommands;
using Aranoz.Application.Mediator.Commands.ProductCommands;
using Aranoz.Application.Mediator.Queries.AddressQueries;
using Aranoz.Application.Mediator.Queries.ProductQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aranoz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateAddress(CreateAddressCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var result = await _mediator.Send(new DeleteAddressCommand(id));
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAddress(UpdateAddressCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddressById(int id)
        {
            var result = await _mediator.Send(new GetAddressByIdQuery(id));
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAddress()
        {
            var result = await _mediator.Send(new GetAddressQuery());
            return Ok(result);
        }

    }
}
