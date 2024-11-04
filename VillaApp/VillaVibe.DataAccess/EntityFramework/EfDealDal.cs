using System;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.DataAccess.Context;
using VillaVibe.DataAccess.Repository;
using VillaVibe.Entity.Entities;

namespace VillaVibe.DataAccess.EntityFramework;

public class EfDealDal : GenericRepository<Deal>, IDealDal
{
    public EfDealDal(VillaContext context) : base(context)
    {
    }
}
