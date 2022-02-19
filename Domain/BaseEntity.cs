namespace Domain
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; protected set; }

        public BaseEntity()
        {
        }

        public BaseEntity(TId id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is BaseEntity<TId> other))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (Id.Equals(default(TId)) || other.Id.Equals(default(TId)))
                return false;

            return Id.Equals(other.Id);

        }

        public static bool operator ==(BaseEntity<TId> a, BaseEntity<TId> b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(BaseEntity<TId> a, BaseEntity<TId> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Id.GetHashCode() * 397) ^ (Id != null ? Id.GetHashCode() : 0);
            }
        }
    }
}
