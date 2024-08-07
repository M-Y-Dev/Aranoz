using Aranoz.Application.Mediator.Commands.BlogCategoryCommands;
using Aranoz.Application.Mediator.Queries.BlogCategoryQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aranoz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogCategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlogCategory(CreateBlogCategoryCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlogCategory(int id)
        {
            var result = await _mediator.Send(new DeleteBlogCategoryCommand(id));
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlogCategory(UpdateBlogCategoryCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogCategoryById(int id)
        {
            var result = await _mediator.Send(new GetBlogCategoryByIdQuery(id));
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetBlogCategory()
        {
            var result = await _mediator.Send(new GetBlogCategoryQuery());
            return Ok(result);
        }
    }
}
