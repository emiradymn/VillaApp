using System;
using MongoDB.Bson;

namespace VillaVibe.Dto.Dtos.VideoDtos;

public class UpdateVideoDto
{
    public ObjectId Id { get; set; }
    public string VideoUrl { get; set; } = string.Empty;
}
