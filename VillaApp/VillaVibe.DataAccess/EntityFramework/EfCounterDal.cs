using System;
using System.Diagnostics.Metrics;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.DataAccess.Context;
using VillaVibe.DataAccess.Repository;
using VillaVibe.Entity.Entities;

namespace VillaVibe.DataAccess.EntityFramework;

public class EfCounterDal : GenericRepository<Counter>, ICounterDal

{
    public EfCounterDal(VillaContext context) : base(context)
    {
    }
}
