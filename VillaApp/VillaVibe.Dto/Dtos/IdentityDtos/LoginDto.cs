using System;

namespace VillaVibe.Dto.Dtos.IdentityDtos;

public class LoginDto
{
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
}
