using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DUM.Domain.Base;

public class EntityBase
{
    public EntityBase(ObjectId id, DateTime createdAt, DateTime updatedAt, DateTime? deletedAt)
    {
        Id = id;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        DeletedAt = deletedAt;
    }

    public EntityBase(DateTime createdAt, DateTime updatedAt, DateTime? deletedAt)
    {
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        DeletedAt = deletedAt;
    }

    [BsonId]
    public ObjectId Id { get; private set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}