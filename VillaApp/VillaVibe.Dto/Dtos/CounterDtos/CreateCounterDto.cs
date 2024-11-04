using System;

namespace VillaVibe.Dto.Dtos.CounterDtos;

public class CreateCounterDto
{
    public string Title { get; set; } = null!;

    public string Count { get; set; } = null!;
}
