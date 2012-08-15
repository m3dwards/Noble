using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Noble.Models;

namespace Noble.Infrastructure.Data
{
    public interface IRepository<T> where T : IModel
    {
        T GetById(Guid id);
        void Delete(T entity);
        T Save(T entity);
        IList<T> GetAll();
    }
}
