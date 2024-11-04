using System;

namespace VillaVibe.Entity.Entities;

public class Banner : BaseEntity
{
    public string City { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
}
