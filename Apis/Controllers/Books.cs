using Application.Book.Command.CreateBook;
using Application.Book.Command.DeleteBook;
using Application.Book.Queries.FilterBooksPaginated;
using Application.Common.Models;
using Controllers;
using Dto;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Books : ApiControllerBase
    {
        
        [HttpGet]
        public async Task<ActionResult<PaginatedList<BookDto>>> FilterBooksPaginated([FromQuery] FilterBooksPaginatedQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> CreateBook(CreateBookCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteBook(Guid id)
        {
            await Mediator.Send(new DeleteBookCommand(id));

            return NoContent();
        }
    }
}
