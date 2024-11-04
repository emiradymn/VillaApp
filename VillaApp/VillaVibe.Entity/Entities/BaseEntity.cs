using System;
using MongoDB.Bson;

namespace VillaVibe.Entity.Entities;

public class BaseEntity
{
    public ObjectId Id { get; set; }
}
