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

        public List<Product> GetByUnitPrice(decimal min, decimal max, object )
        {
            return _productDal.GetAll(p=>p.UnitPrice<=min&& p.UnitPrice<=max );
        }

        public List<Product> GettAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id); 
        }
    }
}
