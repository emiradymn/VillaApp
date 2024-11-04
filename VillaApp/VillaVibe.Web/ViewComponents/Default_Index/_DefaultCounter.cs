using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.CounterDtos;

namespace VillaVibe.Web.ViewComponents.Default_Index;

public class _DefaultCounter : ViewComponent
{
    private readonly ICounterService _counterService;
    private readonly IMapper _mapper;

    public _DefaultCounter(ICounterService counterService, IMapper mapper)
    {
        _counterService = counterService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var values = await _counterService.TGetListAsync();
        var counterList = _mapper.Map<List<ResultCounterDto>>(values);
        return View(counterList);
    }
}
