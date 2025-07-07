namespace ContabiliHub.Application.Validators
{
    public class ValidationResult
    {
        public bool IsValid { get; init; }
        public List<string> Errors { get; init; } = new();

        public static ValidationResult Success() => new() { IsValid = true };

        public static ValidationResult Failure(params string[] errors) => new()
        {
            IsValid = false,
            Errors = errors.ToList()
        };

        public static ValidationResult Failure(IEnumerable<string> errors) => new()
        {
            IsValid = false,
            Errors = errors.ToList()
        };
    }
}