using SignalR.DataAccess.Abstract;
using SignalR.DataAccess.Concrete;
using SignalR.DataAccess.Repositories;
using SignalR.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccess.EntityFramework
{
    public class efOrderDal : GenericRepository<Order>, IOrderDal
    {
        public efOrderDal(SignalRDbContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            using var context = new SignalRDbContext();
            return context.Orders.Where(x=>x.Description=="Müşteri Masada").Count();
        }

        public decimal LastOrderPrice()
        {
            using var context = new SignalRDbContext();
            return context.Orders.OrderByDescending(x => x.Id).Take(1).Select(y => y.TotalPrice).FirstOrDefault();
        }

        public decimal TodayTotalPrice()
        {
            using var context = new SignalRDbContext();
            return context.Orders.Where(x=>x.OrderDate==DateTime.Parse(DateTime.Now.ToShortDateString())).Sum(y=>y.TotalPrice);
        }

        public int TotalOrderCount()
        {
            using var context = new SignalRDbContext();
            return context.Orders.Count();
        }
    }
}
