using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepositoryBase<T> where T: class
    {
        Task<T> AddAsync(T entity);

    }
}
