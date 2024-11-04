using System;
using MongoDB.Bson;

namespace VillaVibe.Dto.Dtos.FeatureDtos;

public class ResultFeatureDto
{
    public ObjectId Id { get; set; }
    public string ImageUrl { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string SubTitle { get; set; } = null!;
    public string Square { get; set; } = null!;
    public string Contract { get; set; } = null!;
    public string Payment { get; set; } = null!;

    public string Safety { get; set; } = null!;
}
