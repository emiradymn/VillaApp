using System;
using VillaVibe.Business.Abstract;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Business.Concrete;

public class DealManager : GenericManager<Deal>, IDealService

{
    public DealManager(IGenericDal<Deal> genericDal) : base(genericDal)
    {
    }
}
