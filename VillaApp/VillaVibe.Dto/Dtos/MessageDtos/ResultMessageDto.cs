using System;
using MongoDB.Bson;

namespace VillaVibe.Dto.Dtos.MessageDtos;

public class ResultMessageDto
{
    public ObjectId Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string MessageContent { get; set; } = string.Empty;
    public DateTime MessageDate { get; set; }
}
