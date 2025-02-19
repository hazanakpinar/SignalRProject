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
    public class efTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        public efTestimonialDal(SignalRDbContext context) : base(context)
        {
        }
    }
}
