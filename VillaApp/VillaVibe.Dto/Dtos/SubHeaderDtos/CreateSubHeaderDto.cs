using System;

namespace VillaVibe.Dto.Dtos.SubHeaderDtos;

public class CreateSubHeaderDto
{
    public string Adress { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Facebook { get; set; } = null!;
    public string Twitter { get; set; } = null!;
    public string Linkedin { get; set; } = null!;
    public string Instagram { get; set; } = null!;
}
