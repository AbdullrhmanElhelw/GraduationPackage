namespace Domain.Shared;

public class Error : IEquatable<Error>
{
    public string Message { get; }
    public string Code { get; }

    public Error(string code, string message)
    {
        Code = code;
        Message = message;
    }

    public static readonly Error None = new(string.Empty, string.Empty);

    public static readonly Error NullValue = new(nameof(NullValue), "Value cannot be null.");

    public static implicit operator string(Error error) => error.Code;

    public bool Equals(Error? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Message == other.Message && Code == other.Code;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Error)obj);
    }

    public static bool operator ==(Error? left, Error? right) => Equals(left, right);

    public static bool operator !=(Error? left, Error? right) => !Equals(left, right);

    public override int GetHashCode()
    {
        return HashCode.Combine(Message, Code);
    }
    public override string ToString()
    {
        return $"{Code}: {Message}";
    }

}
