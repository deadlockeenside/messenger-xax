using System.Text.RegularExpressions;

namespace XAX.Domain.ValueObjects;

public record PhoneNumber
{
    public static Regex VALID_FORMAT = new Regex(@"^\+7\d{10}$");

    public PhoneNumber(string value)
    {
        if (!VALID_FORMAT.IsMatch(value))
            throw new ArgumentException("Неккоректный формат номера телефона.");

        Value = value;
    }

    public string Value { get; init; }
}
