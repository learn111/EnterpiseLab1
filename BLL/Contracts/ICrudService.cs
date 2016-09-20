using System.Collections.Generic;

namespace BLL.Contracts
{
    public interface ICrudService<T>
    {
        IEnumerable<T> GetAll();
        void Update(T item);
        void Delete(T item);
        void Add(T item);
    }
}