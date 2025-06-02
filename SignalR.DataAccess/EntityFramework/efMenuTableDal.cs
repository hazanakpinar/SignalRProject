using SignalR.DataAccess.Abstract;
using SignalR.DataAccess.Concrete;
using SignalR.DataAccess.Repositories;
using SignalR.Entities.Entities;

namespace SignalR.DataAccess.EntityFramework
{
    public class efMenuTableDal : GenericRepository<MenuTable>, IMenuTableDal
    {
        public efMenuTableDal(SignalRDbContext context) : base(context)
        {
        }

        public int MenuTableCount()
        {
            using var context = new SignalRDbContext();
            return context.MenuTables.Count();
        }
    }
}
