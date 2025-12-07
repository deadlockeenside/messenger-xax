using XAX.Domain.ValueObjects;

namespace XAX.Domain.Entities;

public class User
{
    public required Id Id { get; init; }
    public required PhoneNumber PhoneNumber { get; init; }
}
