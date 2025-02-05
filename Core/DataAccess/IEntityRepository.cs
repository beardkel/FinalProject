﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint jenerik kısıt
    //T:class referans tip olabilir, IEntity olabilir veya IEntity implemente eden bir nese olabilir.
    //new()  newlenebilir olmak durumunda
    public interface IEntityRepository<T> where T: class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
