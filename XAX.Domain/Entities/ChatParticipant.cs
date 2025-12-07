using XAX.Domain.ValueObjects;

namespace XAX.Domain.Entities;

public class ChatParticipant
{
    public required Id Id { get; init; }
    public required Id ChatId { get; init; }
    public required Id UserId { get; init; }
}
