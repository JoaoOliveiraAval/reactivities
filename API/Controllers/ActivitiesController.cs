using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/activities")]
    public class ActivitiesController : BaseController<Activity>
    {
        public ActivitiesController(DataContext context) : base(context)
        {
        }
    }
}
