using Domain;
using System.Text.Json.Serialization;

namespace API.DTO
{
    public class ActivityDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Dates { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Avenue { get; set; }

        public ActivityDTO(Activity act)
        {
            Title = act.Title.Value;
            Dates = act.Dates;
            Description = act.Description;
            Category = act.Category;
            City = act.City;
            Avenue = act.Avenue;
        }

        public ActivityDTO()
        {
        }
    }
}
