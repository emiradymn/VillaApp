using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.VideoDtos;

namespace VillaVibe.Web.ViewComponents.Default_Index;

public class _DefaultVideo : ViewComponent
{
    private readonly IVideoService _videoService;
    private readonly IMapper _mapper;

    public _DefaultVideo(IVideoService videoService, IMapper mapper)
    {
        _videoService = videoService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var values = await _videoService.TGetListAsync();
        var videoList = _mapper.Map<List<ResultVideoDto>>(values);
        return View(videoList);
    }
}
