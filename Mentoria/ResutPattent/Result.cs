namespace ResutPattent
{
    public class Result
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public IReadOnlyList<string> Errors { get; }

        protected Result(bool isSuccess, List<string> errors)
        {
            IsSuccess = isSuccess;
            Errors = errors;
        }

        public static Result Success()
            => new Result(true, new List<string>());

        public static Result Failure(List<string> errors)
            => new Result(false, errors);
    }

}
