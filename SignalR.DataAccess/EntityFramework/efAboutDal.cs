using SignalR.DataAccess.Abstract;
using SignalR.DataAccess.Concrete;
using SignalR.DataAccess.Repositories;
using SignalR.Entities.Entities;

namespace SignalR.DataAccess.EntityFramework
{
    public class efAboutDal : GenericRepository<About>, IAboutDal
    {
        public efAboutDal(SignalRDbContext context) : base(context)
        {
        }
    }
}
