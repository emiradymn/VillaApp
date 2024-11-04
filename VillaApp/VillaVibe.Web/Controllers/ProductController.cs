using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using VillaVibe.Business.Abstract;
using VillaVibe.Dto.Dtos.ProductDtos;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Web.Controllers;

public class ProductController : Controller
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public ProductController(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }
    public async Task<IActionResult> Index()
    {
        var values = await _productService.TGetListAsync();
        var productList = _mapper.Map<List<ResultProductDto>>(values);
        return View(productList);
    }

    public async Task<IActionResult> DeleteProduct(ObjectId id)
    {
        await _productService.TDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public IActionResult CreateProduct()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
    {
        var newproduct = _mapper.Map<Product>(createProductDto);
        await _productService.TCreateAsync(newproduct);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> UpdateProduct(ObjectId id)
    {
        var product = await _productService.TGetByIdAsync(id);
        var updateproduct = _mapper.Map<UpdateProductDto>(product);
        return View(updateproduct);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
    {
        var product = _mapper.Map<Product>(updateProductDto);
        await _productService.TUpdateAsync(product);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> ProductDetails(ObjectId id)
    {
        var value = await _productService.TGetByIdAsync(id);
        var product = _mapper.Map<ResultProductDto>(value);
        return View(product);

    }


}
