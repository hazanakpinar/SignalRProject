using SignalR.DataAccess.Abstract;
using SignalR.DataAccess.Concrete;
using SignalR.DataAccess.Repositories;
using SignalR.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccess.EntityFramework
{
    public class efDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        public efDiscountDal(SignalRDbContext context) : base(context)
        {
        }
    }
}
