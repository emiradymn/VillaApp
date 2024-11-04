using System;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.DataAccess.Context;
using VillaVibe.DataAccess.Repository;
using VillaVibe.Entity.Entities;

namespace VillaVibe.DataAccess.EntityFramework;

public class EfQuestDal : GenericRepository<Quest>, IQuestDal

{
    public EfQuestDal(VillaContext context) : base(context)
    {
    }
}
