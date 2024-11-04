using System;
using MongoDB.Bson;

namespace VillaVibe.Dto.Dtos.QuestDtos;

public class ResultQuestDto
{
    public ObjectId Id { get; set; }
    public string Question { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
}
