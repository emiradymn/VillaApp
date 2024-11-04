using System;
using VillaVibe.Business.Abstract;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Business.Concrete;

public class FeatureManager : GenericManager<Feature>, IFeatureService
{
    public FeatureManager(IGenericDal<Feature> genericDal) : base(genericDal)
    {
    }
}

