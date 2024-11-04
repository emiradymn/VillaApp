using System;
using VillaVibe.Business.Abstract;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Business.Concrete;

public class ContactManager : GenericManager<Contact>, IContactService
{
    public ContactManager(IGenericDal<Contact> genericDal) : base(genericDal)
    {
    }
}
