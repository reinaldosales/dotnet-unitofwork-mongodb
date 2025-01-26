using DUM.Domain.Base;
using MongoDB.Bson;

namespace DUM.Domain.Entities;

public class Post : EntityBase
{
    public Post(ObjectId id, DateTime createdAt, DateTime updatedAt, DateTime? deletedAt) : base(id, createdAt, updatedAt, deletedAt)
    {
    }

    public Post(DateTime createdAt, DateTime updatedAt, DateTime? deletedAt) : base(createdAt, updatedAt, deletedAt)
    {
    }
}