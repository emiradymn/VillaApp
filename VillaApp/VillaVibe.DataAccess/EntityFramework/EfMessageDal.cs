using System;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.DataAccess.Context;
using VillaVibe.DataAccess.Repository;
using VillaVibe.Entity.Entities;

namespace VillaVibe.DataAccess.EntityFramework;

public class EfMessageDal : GenericRepository<Message>, IMessageDal
{
    public EfMessageDal(VillaContext context) : base(context)
    {
    }
}
