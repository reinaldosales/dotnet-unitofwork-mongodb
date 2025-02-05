using DUM.Application.Abstractions;
using DUM.Domain.Abstractions;
using DUM.Domain.Entities;

namespace DUM.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public void Create(User user)
        => _userRepository.Create(user);

    public async Task<IEnumerable<User>> GetAll()
        => await _userRepository.GetAll();
}