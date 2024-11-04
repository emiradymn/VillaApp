using System;

namespace VillaVibe.Dto.Dtos.BannersDtos;

public class CreateBannerDto
{
    public string City { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
}
