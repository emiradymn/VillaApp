using System;
using MongoDB.Bson;

namespace VillaVibe.Dto.Dtos.DealDtos;

public class ResultDealDto
{
    public ObjectId Id { get; set; }
    public string Type { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Square { get; set; } = null!;
    public string Floor { get; set; } = null!;
    public int RoomCount { get; set; }
    public bool HasParkingArea { get; set; }
    public string PaymentType { get; set; } = null!;
}
