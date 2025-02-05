using DUM.Domain.Entities;

namespace DUM.Application.Abstractions;

public interface IUserService
{
    public void Create(User user);
    public Task<IEnumerable<User>> GetAll();
}