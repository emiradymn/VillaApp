using System;
using MongoDB.Bson;

namespace VillaVibe.Dto.Dtos.CounterDtos;

public class ResultCounterDto
{
    public ObjectId Id { get; set; }
    public string Title { get; set; } = null!;
    public string Count { get; set; } = null!;
}
