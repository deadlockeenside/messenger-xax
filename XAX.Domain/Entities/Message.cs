using XAX.Domain.ValueObjects;

namespace XAX.Domain.Entities;

public class Message
{
    public required Id Id { get; init; }
    public required Id ChatId { get; init; }
    public required Id SenderId { get; init; }
    public required Text Text { get; init; }
    public required DateTime SendedAt { get; init; }
}
