using Application.Activities;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/activities")]
    public class ActivitiesController : BaseApiController
    {
        public ActivitiesController(IMapper mapper, IMediator mediator) : base(mapper, mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetActivities(CancellationToken cancellationToken)
        {
            var result = await Mediator.Send(new List.Query());
            return HandleResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivity(Guid id)
        {
            var result = await Mediator.Send(new Details.Query { Id = id });
            return HandleResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity([FromBody] Activity activity)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Activity = activity }));
        }

        [Authorize(Policy = "IsActivityHost")]
        [HttpPut("{id}")]
        public async Task<IActionResult> EditActivity(Guid id, [FromBody] Activity activity)
        {
            activity.SetId(id);
            return HandleResult(await Mediator.Send(new Edit.Command { Activity = activity }));
        }

        [Authorize(Policy = "IsActivityHost")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        }

        [HttpPost("{id}/attend")]
        public async Task<IActionResult> Attend(Guid id)
        {
            return HandleResult(await Mediator.Send(new UpdateAttendance.Command { Id = id }));
        }
    }
}
