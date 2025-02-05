using DUM.Domain.Abstractions;
using DUM.Domain.Entities;
using DUM.Infra.Data.Abstractions;
using MongoDB.Driver;

namespace DUM.Infra.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<User> _collection;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMongoClient _mongoClient;
    
    public UserRepository(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        
        this._database = _mongoClient.GetDatabase("DUM");
        this._collection = this._database.GetCollection<User>("User");
    }
    
    public void Create(User user)
    {
        Action operation = () => _collection.InsertOne(_unitOfWork as IClientSessionHandle, user);
        _unitOfWork.AddOperation(operation);
    }

    public void Update(User user)
    {
        Action operation = () => _collection.ReplaceOne(this._unitOfWork.Session as IClientSessionHandle, x => x.Id == user.Id, user);
        _unitOfWork.AddOperation(operation);
    }

    public void Delete(User user)
    {
        Action operation = () => _collection.DeleteOne(this._unitOfWork.Session as IClientSessionHandle, x => x.Id == user.Id);
        this._unitOfWork.AddOperation(operation);
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        var filter = Builders<User>.Filter.Empty;
        
        return await _collection.Find(filter).ToListAsync();
    }
}