using XAX.Domain.Entities;
using XAX.Domain.ValueObjects;

namespace XAX.Domain.Interfaces;

public interface IUsersRepository
{
    public void Add(User user);
    public User GetByPhoneNumber(PhoneNumber phoneNumber);
}
