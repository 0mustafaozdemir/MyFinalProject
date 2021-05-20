using DataAccess.Concretee.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntitityRepository<Category>
    {
       
    }
}
