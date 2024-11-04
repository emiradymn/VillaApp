using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.ProductDtos;

namespace VillaVibe.Web.ViewComponents.Default_Index;

public class _DefaultProduct : ViewComponent
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public _DefaultProduct(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var values = await _productService.TGetListAsync();
        var productList = _mapper.Map<List<ResultProductDto>>(values);
        return View(productList);
    }
}
