using System;
using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;

namespace VillaVibe.Entity.Entities;

public class UserLogin : IdentityUserLogin<ObjectId>
{

}