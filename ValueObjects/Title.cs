using Yoda;

namespace ValueObjects
{
    public class Title : SimpleValueObject<string>
    {
        public const string TitleCannotBeEmpty = "Title cannot be empty.";
        public static readonly string TitleCannotContainInvalidCharacter = $"Title cannot contain {InvalidCharacters}.";
        public static readonly string TitleMustHaveUpToMaxLength = $"Title must have up to {TitleMaxLength} characters.";
        public const string InvalidCharacters = "@#$*(),.!;/?[]{}-_=+¬ºª¹²³£¢°\\";
        public const int TitleMaxLength = 200;

        public Title(string value) : base(value.Trim())
        {
        }

        public static string Validate(string title)
        {
            var titleValidate = title == null ? "" : title.Trim();
            

            if (string.IsNullOrWhiteSpace(titleValidate))
                return TitleCannotBeEmpty;

            if (titleValidate.Length > TitleMaxLength)
                return TitleMustHaveUpToMaxLength;

            return string.Empty;
        }

        public static Result<Title> Create(string title)
        {
            var error = Validate(title);

            if (error.Any())
            {
                return Result.Failure<Title>(error);
            }

            return Result.Success(new Title(title));
        }

        public override bool Equals(object obj)
        {
            return obj is Title title && Value.ToLower() == title.Value.ToLower();
        }

        public override int GetHashCode()
        {
            return Value.ToLower().GetHashCode();
        }

        public static explicit operator Title(string name)
        {
            return Create(name).Value;
        }
    }
}
