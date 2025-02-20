using SignalR.Business.Abstract;
using SignalR.DataAccess.Abstract;
using SignalR.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Business.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void TAdd(Discount entity)
        {
            _discountDal.Add(entity);
        }

        public void TDelete(Discount entity)
        {
            _discountDal.Delete(entity);
        }

        public List<Discount> TGetListAll()
        {
            return _discountDal.GetAll();
        }

        public Discount TGetByID(int id)
        {
            return _discountDal.GetByID(id);
        }

        public void TUpdate(Discount entity)
        {
            _discountDal.Update(entity);
        }
    }
}
