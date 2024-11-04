
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.CounterDtos;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Web.Controllers;

public class CounterController : Controller
{

    private readonly ICounterService _counterService;
    private readonly IMapper _mapper;

    public CounterController(ICounterService counterService, IMapper mapper)
    {
        _counterService = counterService;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        var values = await _counterService.TGetListAsync();
        var counterList = _mapper.Map<List<ResultCounterDto>>(values);
        return View(counterList);
    }

    public async Task<IActionResult> DeleteCounter(ObjectId id)
    {
        await _counterService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateCounter()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateCounter(CreateCounterDto createCounterDto)
    {
        var newcounter = _mapper.Map<Counter>(createCounterDto);
        await _counterService.TCreateAsync(newcounter);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateCounter(ObjectId id)
    {
        var counter = await _counterService.TGetByIdAsync(id);
        var updateCounter = _mapper.Map<UpdateCounterDto>(counter);
        return View(updateCounter);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateCounter(UpdateCounterDto updateCounterDto)
    {
        var counter = _mapper.Map<Counter>(updateCounterDto);
        await _counterService.TUpdateAsync(counter);
        return RedirectToAction("Index");
    }
}
