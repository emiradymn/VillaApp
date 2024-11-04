using System;
using MongoDB.Bson;

namespace VillaVibe.Dto.Dtos.SubHeaderDtos;

public class ResultSubHeaderDto
{
    public ObjectId Id { get; set; }
    public string Adress { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Facebook { get; set; } = null!;
    public string Twitter { get; set; } = null!;
    public string Linkedin { get; set; } = null!;
    public string Instagram { get; set; } = null!;
}
