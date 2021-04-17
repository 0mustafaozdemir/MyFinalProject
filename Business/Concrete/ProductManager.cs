using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concretee.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal= productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları
            //Yetkisi var mı?
            return _productDal.GetAll();
           
        }
    }
}
