using System;

namespace VillaVibe.Dto.Dtos.ContactDtos;

public class CreateContactDto
{
    public string MapUrl { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
