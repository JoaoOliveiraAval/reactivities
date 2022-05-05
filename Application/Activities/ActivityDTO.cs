using Application.Profiles;
using Domain;

namespace Application.Activities
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
        public string HostUsername { get; set; }
        public bool IsCancelled { get; set; }

        public ICollection<Profile> Attendees { get; set; }

        public ActivityDTO(Activity act)
        {
            Title = act.Title;
            Dates = act.Dates;
            Description = act.Description;
            Category = act.Category;
            City = act.City;
            Avenue = act.Avenue;
            IsCancelled = act.IsCancelled;
        }

        public ActivityDTO()
        {
        }
    }
}
