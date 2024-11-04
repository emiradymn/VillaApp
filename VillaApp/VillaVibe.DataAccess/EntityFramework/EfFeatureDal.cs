using System;
using MongoDB.Driver.Core.Misc;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.DataAccess.Context;
using VillaVibe.DataAccess.Repository;

namespace VillaVibe.DataAccess.EntityFramework;

public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
{
    public EfFeatureDal(VillaContext context) : base(context)
    {
    }
}
