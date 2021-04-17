using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{//generic constraint = Generic kısım
 //class : Referans tip
 //IEntity : IEntity olabilir veya IEntity iplemente eden bir nesne olabilir
 //new() : new'lenebilir olmalı  
    public interface IEntitityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>>filter);
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);



    }
}
