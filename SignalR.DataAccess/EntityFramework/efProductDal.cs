using Microsoft.EntityFrameworkCore;
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
    public class efProductDal : GenericRepository<Product>, IProductDal
    {
        public efProductDal(SignalRDbContext context) : base(context)
        {
        }

        public List<Product> GetProductWithCategories()
        {
            var context = new SignalRDbContext();
            var values = context.Products.Include(x => x.Category.Name).ToList();
            return values;
        }

        public int ProductCount()
        {
            using var context = new SignalRDbContext();
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new SignalRDbContext();
            return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.Name == "İçecek").Select(z => z.Id).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new SignalRDbContext();
            return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.Name == "Hamburger").Select(z => z.Id).FirstOrDefault())).Count();
        }

        public string ProductNameByMaxPrice()
        {
            using var context = new SignalRDbContext();
            return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z=>z.Name).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            using var context = new SignalRDbContext();
            return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.Name).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            using var context = new SignalRDbContext();
            return context.Products.Average(x => x.Price);
        }
    }
}
