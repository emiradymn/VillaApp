using System;

namespace VillaVibe.Entity.Entities;

public class Counter : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public string Count { get; set; } = string.Empty;
}
