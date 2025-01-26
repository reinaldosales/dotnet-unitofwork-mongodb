using DUM.Domain.Entities;

namespace DUM.Domain.Abstractions;

public interface IUserRepository
{
    Task<User> Create(User user);
    
    Task<User> Update(User user);
    
    void Delete(User user);
}