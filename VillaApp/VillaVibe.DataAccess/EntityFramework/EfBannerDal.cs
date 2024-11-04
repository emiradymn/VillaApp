using System;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.DataAccess.Context;
using VillaVibe.DataAccess.Repository;
using VillaVibe.Entity.Entities;

namespace VillaVibe.DataAccess.EntityFramework;

public class EfBannerDal : GenericRepository<Banner>, IBannerDal
{
    public EfBannerDal(VillaContext context) : base(context)
    {
    }
}
