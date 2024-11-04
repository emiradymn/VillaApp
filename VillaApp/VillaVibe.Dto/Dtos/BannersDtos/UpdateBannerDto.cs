using System;
using MongoDB.Bson;

namespace VillaVibe.Dto.Dtos.BannersDtos;

public class UpdateBannerDto
{
    public ObjectId Id { get; set; }
    public string City { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
}
