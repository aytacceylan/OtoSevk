using OtoSevk.Data.Abstract;
using OtoSevk.Entities;

namespace OtoSevk.Service.Abstract
{
    public interface IService<T> : IRepository<T> where T : class, IEntity, new()
    {

    }
}
