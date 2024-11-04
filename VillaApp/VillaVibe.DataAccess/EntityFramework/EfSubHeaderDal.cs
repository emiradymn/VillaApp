using System;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.DataAccess.Context;
using VillaVibe.DataAccess.Repository;
using VillaVibe.Entity.Entities;

namespace VillaVibe.DataAccess.EntityFramework;

public class EfSubHeaderDal : GenericRepository<SubHeader>, ISubHeaderDal
{
    public EfSubHeaderDal(VillaContext context) : base(context)
    {
    }
}
