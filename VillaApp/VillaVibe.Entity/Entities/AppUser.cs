using System;
using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;

namespace VillaVibe.Entity.Entities;

public class AppUser : IdentityUser<ObjectId>
{
    public string NameSurname { get; set; } = null!;

}
