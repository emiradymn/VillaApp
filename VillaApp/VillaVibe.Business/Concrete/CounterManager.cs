using System;
using System.Diagnostics.Metrics;
using VillaVibe.Business.Abstract;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Business.Concrete;

public class CounterManager : GenericManager<Counter>, ICounterService

{
    public CounterManager(IGenericDal<Counter> genericDal) : base(genericDal)
    {
    }
}
