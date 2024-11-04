using System;
using System.Text.RegularExpressions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.ContactDtos;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Web.Controllers;

public class ContactController : Controller
{
    private readonly IContactService _contactService;
    private readonly IMapper _mapper;

    public ContactController(IContactService contactService, IMapper mapper)
    {
        _contactService = contactService;
        _mapper = mapper;

    }

    public async Task<IActionResult> Index()
    {
        var values = await _contactService.TGetListAsync();
        var contactList = _mapper.Map<List<ResultContactDto>>(values);
        return View(contactList);
    }

    public async Task<IActionResult> DeleteContact(ObjectId id)
    {
        await _contactService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateContact()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
    {
        var newContact = _mapper.Map<Contact>(createContactDto);
        await _contactService.TCreateAsync(newContact);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateContact(ObjectId id)
    {
        var value = await _contactService.TGetByIdAsync(id);
        var updateContact = _mapper.Map<UpdateContactDto>(value);
        return View(updateContact);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
    {
        var contact = _mapper.Map<Contact>(updateContactDto);
        await _contactService.TUpdateAsync(contact);
        return RedirectToAction("Index");
    }
}
