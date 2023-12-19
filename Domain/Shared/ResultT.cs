namespace Domain.Shared;

public class Result<TValue> : Result
{
    private readonly TValue? _value;

    protected internal Result(TValue? value, bool isSuccess, Error? error) : base(isSuccess, error)
    {
        _value = value;
    }

    public TValue Value => IsSuccess
        ? _value!
        : throw new InvalidOperationException("There is no value for failure.");

    public static implicit operator Result<TValue>(TValue? value) => Create(value);

    public static Result<TValue> Create(TValue? value)
    {
        if (value is null)
            return new Result<TValue>(default, false, Error.NullValue);

        return new Result<TValue>(value, true, Error.None);
    }

}
