using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.ContactDtos;

namespace VillaVibe.Web.ViewComponents.Default_Index;

public class _DefaultContact : ViewComponent
{

    private readonly IContactService _contactService;
    private readonly IMapper _mapper;

    public _DefaultContact(IContactService contactService, IMapper mapper)
    {
        _contactService = contactService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var values = await _contactService.TGetListAsync();
        var contactList = _mapper.Map<List<ResultContactDto>>(values);
        return View(contactList);
    }
}
