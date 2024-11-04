using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.DealDtos;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Web.Controllers;

public class DealController : Controller
{
    private readonly IDealService _dealService;
    private readonly IMapper _mapper;

    public DealController(IDealService dealService, IMapper mapper)
    {
        _dealService = dealService;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        var values = await _dealService.TGetListAsync();
        var dealList = _mapper.Map<List<ResultDealDto>>(values);
        return View(dealList);
    }

    public async Task<IActionResult> DeleteDeal(ObjectId id)
    {
        await _dealService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateDeal()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateDeal(CreateDealDto createDealDto)
    {
        var newdeal = _mapper.Map<Deal>(createDealDto);
        await _dealService.TCreateAsync(newdeal);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateDeal(ObjectId id)
    {
        var deal = await _dealService.TGetByIdAsync(id);
        var updateDeal = _mapper.Map<UpdateDealDto>(deal);
        return View(updateDeal);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateDeal(UpdateDealDto updateDealDto)
    {
        var deal = _mapper.Map<Deal>(updateDealDto);
        await _dealService.TUpdateAsync(deal);
        return RedirectToAction("Index");
    }
}
