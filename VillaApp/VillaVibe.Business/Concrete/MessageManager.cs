using System;
using VillaVibe.Business.Abstract;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Business.Concrete;

public class MessageManager : GenericManager<Message>, IMessageService

{
    public MessageManager(IGenericDal<Message> genericDal) : base(genericDal)
    {
    }
}
