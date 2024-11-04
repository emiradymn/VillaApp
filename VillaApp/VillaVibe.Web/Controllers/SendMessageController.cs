using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.MessageDtos;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Web.Controllers;

public class SendMessageController : Controller
{
    private readonly IMessageService _messageService;
    private readonly IMapper _mapper;

    public SendMessageController(IMessageService messageService, IMapper mapper)
    {
        _messageService = messageService;
        _mapper = mapper;

    }

    [HttpPost]
    public async Task<IActionResult> SendMessage(CreateMessageDto createMessageDto)
    {
        var newMessage = _mapper.Map<Message>(createMessageDto);
        await _messageService.TCreateAsync(newMessage);
        return RedirectToAction("Index", "Default");
    }

}
