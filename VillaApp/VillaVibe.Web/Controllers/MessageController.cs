using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.MessageDtos;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Web.Controllers;

public class MessageController : Controller
{
    private readonly IMessageService _messageService;
    private readonly IMapper _mapper;
    public MessageController(IMessageService messageService, IMapper mapper)
    {
        _messageService = messageService;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        var values = await _messageService.TGetListAsync();
        var messageList = _mapper.Map<List<ResultMessageDto>>(values);
        return View(messageList);
    }

    public async Task<IActionResult> DeleteMessage(ObjectId id)
    {
        await _messageService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateMessage()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateMessage(CreateMessageDto createMessageDto)
    {
        var newMessage = _mapper.Map<Message>(createMessageDto);
        await _messageService.TCreateAsync(newMessage);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> MessageDetails(ObjectId id)
    {
        var message = await _messageService.TGetByIdAsync(id);
        var messageValue = _mapper.Map<ResultMessageDto>(message);
        return View(messageValue);
    }

}
