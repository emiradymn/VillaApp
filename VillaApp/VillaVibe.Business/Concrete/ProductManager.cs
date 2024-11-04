using System;
using VillaVibe.Business.Abstract;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Business.Concrete;

public class ProductManager : GenericManager<Product>, IProductService
{
    public ProductManager(IGenericDal<Product> genericDal) : base(genericDal)
    {
    }
}
