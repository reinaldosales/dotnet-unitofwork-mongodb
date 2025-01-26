using DUM.Domain.Base;
using MongoDB.Bson;

namespace DUM.Domain.Entities;

public class User : EntityBase
{
    public User(ObjectId id, DateTime createdAt, DateTime updatedAt, DateTime? deletedAt) : base(id, createdAt, updatedAt, deletedAt)
    {
    }

    public User(DateTime createdAt, DateTime updatedAt, DateTime? deletedAt) : base(createdAt, updatedAt, deletedAt)
    {
    }

    public string Name { get; set; }
    public string Password { get; set; }
}