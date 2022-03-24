using ValueObjects;
using Yoda;

namespace Domain
{
    public class Activity : Entity<Guid>
    {
        public Title Title { get; set; }
        public DateTime Dates { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Avenue { get; set; }

        protected Activity(Guid id = default) : base(id)
        {
        }

        public Activity(Title title, DateTime dates, string description, string category, string city, string avenue, Guid id = default)
            : this(id)
        {
            Title = title;
            Dates = dates;
            Description = description;
            Description = description;
            Category = category;
            City = city;
            Avenue = avenue;
        }
    }
}