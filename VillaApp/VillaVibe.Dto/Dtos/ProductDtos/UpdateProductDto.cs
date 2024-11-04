using System;
using MongoDB.Bson;

namespace VillaVibe.Dto.Dtos.ProductDtos;

public class UpdateProductDto
{
    public ObjectId Id { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int BedroomCount { get; set; }
    public int BathroomCount { get; set; }
    public int Area { get; set; }
    public int Floor { get; set; }
    public int ParkingCount { get; set; }
}
