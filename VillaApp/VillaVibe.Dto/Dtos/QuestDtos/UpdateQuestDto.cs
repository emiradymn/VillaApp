using System;
using MongoDB.Bson;

namespace VillaVibe.Dto.Dtos.QuestDtos;

public class UpdateQuestDto
{
    public ObjectId Id { get; set; }
    public string Question { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
}
