using System;

namespace VillaVibe.Dto.Dtos.MessageDtos;

public class CreateMessageDto
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string MessageContent { get; set; } = string.Empty;
    public DateTime MessageDate { get; set; } = DateTime.Now;
}
