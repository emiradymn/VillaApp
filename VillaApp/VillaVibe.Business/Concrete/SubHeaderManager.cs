using System;
using VillaVibe.Business.Abstract;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Business.Concrete;

public class SubHeaderManager : GenericManager<SubHeader>, ISubHeaderService

{
    public SubHeaderManager(IGenericDal<SubHeader> genericDal) : base(genericDal)
    {
    }
}
