using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.FeatureDtos;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Web.Controllers;

public class FeatureController : Controller
{
    private readonly IFeatureService _featureService;
    private readonly IMapper _mapper;

    public FeatureController(IFeatureService featureService, IMapper mapper)
    {
        _featureService = featureService;
        _mapper = mapper;
    }
    public async Task<IActionResult> Index()
    {
        var values = await _featureService.TGetListAsync();
        var featureList = _mapper.Map<List<ResultFeatureDto>>(values);
        return View(featureList);
    }

    public async Task<IActionResult> DeleteFeature(ObjectId id)
    {
        await _featureService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateFeature()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
    {
        var newfeature = _mapper.Map<Feature>(createFeatureDto);
        await _featureService.TCreateAsync(newfeature);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateFeature(ObjectId id)
    {
        var feature = await _featureService.TGetByIdAsync(id);
        var updatefeature = _mapper.Map<UpdateFeatureDto>(feature);
        return View(updatefeature);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
    {
        var feature = _mapper.Map<Feature>(updateFeatureDto);
        await _featureService.TUpdateAsync(feature);
        return RedirectToAction("Index");
    }


}
