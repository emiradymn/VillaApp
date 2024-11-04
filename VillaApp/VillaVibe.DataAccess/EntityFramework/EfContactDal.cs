using System;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.DataAccess.Context;
using VillaVibe.DataAccess.Repository;
using VillaVibe.Entity.Entities;

namespace VillaVibe.DataAccess.EntityFramework;

public class EfContactDal : GenericRepository<Contact>, IContactDal
{
    public EfContactDal(VillaContext context) : base(context)
    {
    }
}
