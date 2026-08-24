namespace Kairos.Application.Common;

public sealed class Result<T>
{
    public bool IsSuccess { get; }
    public T? Value { get; }
    public IReadOnlyList<string> Errors { get; }

    private Result(bool isSucess, T? value, IReadOnlyList<string> errors)
    {
        IsSuccess = isSucess;
        Value = value;
        Errors = errors;
    }

    public static Result<T> Success(T value) =>
        new(true, value, Array.Empty<string>());

    public static Result<T> Failure(IReadOnlyList<string> errors) =>
        new(false, default, errors);

    public static Result<T> Failure(string error) =>
        new(false, default, new[] { error });
}
