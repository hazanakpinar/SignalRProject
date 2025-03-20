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
    public class efCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public efCategoryDal(SignalRDbContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context = new SignalRDbContext();
            return context.Categories.Where(x => x.Status == true).Count();
        }

        public int CategoryCount()
        {
            using var context = new SignalRDbContext();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new SignalRDbContext();
            return context.Categories.Where(x => x.Status == false).Count();
        }
    }
}
