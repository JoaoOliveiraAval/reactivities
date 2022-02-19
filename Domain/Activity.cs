namespace Domain
{
    public class Activity : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public DateTime Dates { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Avenue { get; set; }

        protected Activity(Guid id = default) : base(id)
        {
        }

        public Activity(string title, DateTime dates, string description, string category, string city, string avenue, Guid id = default)
            : this(id)
        {
            Title = title;
            Dates = dates;
            Description = description;
            Category = category;
            City = city;
            Avenue = avenue;
        }
    }
}