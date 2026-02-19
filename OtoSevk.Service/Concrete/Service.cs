using OtoSevk.Data;
using OtoSevk.Data.Concrete;
using OtoSevk.Entities;

namespace OtoSevk.Service.Concrete
{
    public class Service<T> : Repository<T> where T : class, IEntity, new()
    {
        public Service(DatabaseContext context) : base(context)
        {

        }
    }
}
