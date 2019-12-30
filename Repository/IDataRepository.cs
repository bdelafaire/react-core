using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCore.Repository
{
    public interface IDataRepository<TEntity>
    {
        public IEnumerable<TEntity> GetAll();
    }
}
