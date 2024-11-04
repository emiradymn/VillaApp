using System;

namespace VillaVibe.Entity.Entities;

public class Contact : BaseEntity
{
    public string MapUrl { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
