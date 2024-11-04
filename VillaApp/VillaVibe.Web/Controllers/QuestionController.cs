using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using VillaVibe.Business.Abstract;
using VillaVibe.Business.Validators;
using VillaVibe.Dto.Dtos.QuestDtos;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Web.Controllers;

public class QuestionController : Controller
{

    private readonly IQuestService _questService;
    private readonly IMapper _mapper;
    public QuestionController(IQuestService questService, IMapper mapper)
    {
        _questService = questService;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        var values = await _questService.TGetListAsync();
        var questList = _mapper.Map<List<ResultQuestDto>>(values);
        return View(questList);
    }

    public async Task<IActionResult> DeleteQuest(ObjectId id)
    {
        await _questService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateQuest()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateQuest(CreateQuestDto createQuestDto)
    {
        ModelState.Clear();
        var newQuest = _mapper.Map<Quest>(createQuestDto);
        var validator = new QuestionValidator();
        var result = validator.Validate(newQuest);
        if (!result.IsValid)
        {
            result.Errors.ForEach(x =>
            {
                ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
            });
            return View();
        }
        await _questService.TCreateAsync(newQuest);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateQuest(ObjectId id)
    {
        var quest = await _questService.TGetByIdAsync(id);
        var updateQuest = _mapper.Map<UpdateQuestDto>(quest);
        return View(updateQuest);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateQuest(UpdateQuestDto updateQuestDto)
    {
        var quest = _mapper.Map<Quest>(updateQuestDto);
        await _questService.TUpdateAsync(quest);
        return RedirectToAction("Index");
    }
}
