using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.VideoDtos;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Web.Controllers;

public class VideoController : Controller
{
    private readonly IVideoService _videoService;
    private readonly IMapper _mapper;

    public VideoController(IVideoService videoService, IMapper mapper)
    {
        _videoService = videoService;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        var values = await _videoService.TGetListAsync();
        var videoList = _mapper.Map<List<ResultVideoDto>>(values);
        return View(videoList);
    }

    public async Task<IActionResult> DeleteVideo(ObjectId id)
    {
        await _videoService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateVideo()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateVideo(CreateVideoDto createVideoDto)
    {
        var newVideo = _mapper.Map<Video>(createVideoDto);
        await _videoService.TCreateAsync(newVideo);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateVideo(ObjectId id)
    {
        var Video = await _videoService.TGetByIdAsync(id);
        var updateVideo = _mapper.Map<UpdateVideoDto>(Video);
        return View(updateVideo);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateVideo(UpdateVideoDto updateVideoDto)
    {
        var video = _mapper.Map<Video>(updateVideoDto);
        await _videoService.TUpdateAsync(video);
        return RedirectToAction("Index");
    }
}
