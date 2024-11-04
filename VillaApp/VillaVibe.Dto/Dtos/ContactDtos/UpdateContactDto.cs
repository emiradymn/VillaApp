using System;
using MongoDB.Bson;

namespace VillaVibe.Dto.Dtos.ContactDtos;

public class UpdateContactDto
{
    public ObjectId Id { get; set; }
    public string MapUrl { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
