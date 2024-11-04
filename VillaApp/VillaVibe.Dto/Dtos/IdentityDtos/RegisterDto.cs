using System;

namespace VillaVibe.Dto.Dtos.IdentityDtos;

public class RegisterDto
{
    public string NameSurname { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;

}
