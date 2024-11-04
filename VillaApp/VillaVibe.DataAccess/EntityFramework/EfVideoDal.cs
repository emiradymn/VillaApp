using System;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.DataAccess.Context;
using VillaVibe.DataAccess.Repository;
using VillaVibe.Entity.Entities;

namespace VillaVibe.DataAccess.EntityFramework;

public class EfVideoDal : GenericRepository<Video>, IVideoDal
{
    public EfVideoDal(VillaContext context) : base(context)
    {
    }
}
