using System;

namespace VillaVibe.Entity.Entities;

public class Message : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string MessageContent { get; set; } = string.Empty;
    public DateTime MessageDate { get; set; }

}