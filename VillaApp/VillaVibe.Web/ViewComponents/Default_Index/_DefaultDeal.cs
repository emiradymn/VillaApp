using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.DealDtos;

namespace VillaVibe.Web.ViewComponents.Default_Index;

public class _DefaultDeal : ViewComponent
{
    private readonly IDealService _dealService;
    private readonly IMapper _mapper;

    public _DefaultDeal(IDealService dealService, IMapper mapper)
    {
        _dealService = dealService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var values = await _dealService.TGetListAsync();
        var dealList = _mapper.Map<List<ResultDealDto>>(values);
        return View(dealList);
    }
}
