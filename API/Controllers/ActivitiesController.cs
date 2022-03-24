using API.DTO;
using Application.Activities;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ValueObjects;

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
            var dtos = Mapper.Map<List<ActivityDTO>>(result);

            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await Mediator.Send(new Details.Query { Id = id });
            var dto = Mapper.Map<ActivityDTO>(result);

            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity([FromBody] ActivityDTO activity)
        {
            return Ok(await Mediator.Send(new Create.Command { Activity = Mapper.Map<Activity>(activity) }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditActivity(Guid id, [FromBody] ActivityDTO activity)
        {
            var act = new Activity(
                (Title)activity.Title,
                activity.Dates,
                activity.Description,
                activity.Category,
                activity.City,
                activity.Avenue, id
            );

            return Ok(await Mediator.Send(new Edit.Command { Activity = Mapper.Map<Activity>(act) }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}
