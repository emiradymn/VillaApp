using System;
using VillaVibe.Business.Abstract;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Business.Concrete;

public class VideoManager : GenericManager<Video>, IVideoService

{
    public VideoManager(IGenericDal<Video> genericDal) : base(genericDal)
    {
    }
}
