using System;

namespace VillaVibe.Entity.Entities;

public class Quest : BaseEntity
{
    public string Question { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
}
