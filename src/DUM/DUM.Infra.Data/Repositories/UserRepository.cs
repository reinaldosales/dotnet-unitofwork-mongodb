using DUM.Domain.Abstractions;
using DUM.Domain.Entities;
using DUM.Infra.Data.Abstractions;
using MongoDB.Driver;

namespace DUM.Infra.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<User> _users;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMongoClient _mongoClient;
    
    public UserRepository(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        
        this._database = _mongoClient.GetDatabase("DUM");
        this._users = this._database.GetCollection<User>("User");
    }
    
    public Task<User> Create(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> Update(User user)
    {
        throw new NotImplementedException();
    }

    public void Delete(User user)
    {
        throw new NotImplementedException();
    }
}