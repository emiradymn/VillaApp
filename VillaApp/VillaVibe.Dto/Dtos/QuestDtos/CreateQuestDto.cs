using System;

namespace VillaVibe.Dto.Dtos.QuestDtos;

public class CreateQuestDto
{
    public string Question { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
}
