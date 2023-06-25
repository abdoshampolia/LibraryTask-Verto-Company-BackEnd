using Application.Student.Command.CreateStudent;
using Application.Student.Command.DeleteStudent;
using Application.Student.Queries.GetStudentDetails;
using Controllers;
using Dto;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Students : ApiControllerBase
    {

        [AllowAnonymous]
        [HttpGet("{id}", Name = "GetStudentDetails")]
        [ProducesResponseType(typeof(StudentDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetStudentDetails([FromRoute] GetStudentDetailsQuery query)
        {
            return Ok(await Mediator.Send(query));
        }


        [HttpPost]
        public async Task<ActionResult<Unit>> CreateStudent(CreateStudentCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteStudent(Guid id)
        {
            await Mediator.Send(new DeleteStudentCommand(id));

            return NoContent();
        }
    }
}
