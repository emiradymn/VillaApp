using System;

namespace VillaVibe.Entity.Entities;

public class SubHeader : BaseEntity
{
    public string Adress { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Facebook { get; set; } = null!;
    public string Twitter { get; set; } = null!;
    public string Linkedin { get; set; } = null!;
    public string Instagram { get; set; } = null!;
}
