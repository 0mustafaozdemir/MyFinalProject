using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class ProductManager
    {
        private EfProductDal efProductDal;

        public ProductManager(EfProductDal efProductDal)
        {
            this.efProductDal = efProductDal;
        }

        internal IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}