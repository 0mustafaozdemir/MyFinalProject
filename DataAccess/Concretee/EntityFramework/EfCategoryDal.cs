﻿using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concretee.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(Category entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entitiy)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
