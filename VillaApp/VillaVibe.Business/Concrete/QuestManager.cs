using System;
using VillaVibe.Business.Abstract;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Business.Concrete;

public class QuestManager : GenericManager<Quest>, IQuestService
{
    public QuestManager(IGenericDal<Quest> genericDal) : base(genericDal)
    {
    }
}
