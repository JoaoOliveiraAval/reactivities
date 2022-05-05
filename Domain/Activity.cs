using Yoda;

namespace Domain
{
    public class Activity : Entity<Guid>
    {
        public string Title { get; set; }
        public DateTime Dates { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Avenue { get; set; }
        public bool IsCancelled { get; set; }
        public ICollection<ActivityAttendee> Attendees { get; set; } = new List<ActivityAttendee>();

        protected Activity(Guid id = default) : base(id)
        {
        }

        public Activity(string title, DateTime dates, string description, string category, string city, string avenue, bool isCancelled = false, Guid id = default)
            : this(id)
        {
            Title = title;
            Dates = dates;
            Description = description;
            Description = description;
            Category = category;
            City = city;
            Avenue = avenue;
            IsCancelled = isCancelled;
        }

        public void AddAttendee(ActivityAttendee attendee)
        {
            Attendees.Add(attendee);
        }

        public void RemoveAttendee(ActivityAttendee attendee)
        {
            Attendees.Remove(attendee);
        }

        public void SetId(Guid id) => Id = id;

        public Activity()
        {
        }
    }
}