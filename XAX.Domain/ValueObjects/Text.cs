namespace XAX.Domain.ValueObjects;

public record Text
{
    public const short MAX_LENGTH = 1024;

    public Text(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentNullException("Текст не может быть пустым.");

        if (value.Length > MAX_LENGTH)
            throw new ArgumentException($"Длина текста не может быть больше {MAX_LENGTH} символов.");

        Value = value;
    }

    public string Value { get; init; }
}
