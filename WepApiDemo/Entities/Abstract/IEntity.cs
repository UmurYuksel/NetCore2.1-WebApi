using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApiDemo.Entities
{
    public interface IEntity<TEntity> where TEntity : class
    {
         IEnumerable<TEntity> GetAll();

         void Delete(TEntity item);
    }
}
