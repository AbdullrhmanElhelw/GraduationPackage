namespace Domain.Shared;

public class Result
{
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;

    public Error? Error { get; }

    protected internal Result(bool isSuccess, Error? error)
    {
        if (isSuccess && error is null)
            throw new InvalidOperationException();

        if (!isSuccess && error != null)
            throw new InvalidOperationException();

        this.IsSuccess = isSuccess;
        this.Error = error;
    }

    public static Result Success() => new(true, Error.None);

    public static Result Failure(Error error) => new(false, error);

    public static Result<TValue> Success<TValue>(TValue? value) => new(value, true, Error.None);

    public static Result<TValue> Failure<TValue>(Error error) => new(default, false, error);

}
