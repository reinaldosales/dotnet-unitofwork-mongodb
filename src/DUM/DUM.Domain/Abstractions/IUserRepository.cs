using DUM.Domain.Entities;

namespace DUM.Domain.Abstractions;

public interface IUserRepository
{
    public void Create(User user);
    
    public void Update(User user);
    
    public void Delete(User user);

    public Task<IEnumerable<User>> GetAll();
}