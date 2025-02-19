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
    public class BookingManager:IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal BookingDal)
        {
            _bookingDal = BookingDal;
        }
        public void TAdd(Booking entity)
        {
            _bookingDal.Add(entity);
        }      
        public void TDelete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }
        public Booking TGetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public List<Booking> TGetListAll()
        {
            return _bookingDal.GetAll();
        }

        public void TUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }

    }
}
