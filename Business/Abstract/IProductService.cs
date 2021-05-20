using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IProductService
    {
        //Neye Göre Getir //İle Getir  //Tümüne göre getir
       //KategoryId      //By         //GetAll
        List<Product> GetAll();
        List<Product> GettAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);
        //Örnek:Sahibinden.com maximum tutar minimum tutar gibi düşün
                 
    }
}
