using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.SubHeaderDtos;

namespace VillaVibe.Web.ViewComponents.UILayout;

public class _UISubHeader : ViewComponent
{
    private readonly ISubHeaderService _subHeaderService;
    private readonly IMapper _mapper;
    public _UISubHeader(ISubHeaderService subHeaderService, IMapper mapper)
    {
        _subHeaderService = subHeaderService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var values = await _subHeaderService.TGetListAsync();
        var subHeaderList = _mapper.Map<List<ResultSubHeaderDto>>(values);
        return View(subHeaderList);
    }
}
