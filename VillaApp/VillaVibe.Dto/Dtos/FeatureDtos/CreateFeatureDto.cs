using System;

namespace VillaVibe.Dto.Dtos.FeatureDtos;

public class CreateFeatureDto
{
    public string ImageUrl { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string SubTitle { get; set; } = null!;
    public string Square { get; set; } = null!;
    public string Contract { get; set; } = null!;
    public string Payment { get; set; } = null!;
    public string Safety { get; set; } = null!;
}
