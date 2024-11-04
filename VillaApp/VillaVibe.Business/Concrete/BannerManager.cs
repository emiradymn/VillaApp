using System;
using System.Linq.Expressions;
using MongoDB.Bson;
using VillaVibe.Business.Abstract;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Business.Concrete;

public class BannerManager : GenericManager<Banner>, IBannerService
{
    public BannerManager(IGenericDal<Banner> genericDal) : base(genericDal)
    {
    }
}
