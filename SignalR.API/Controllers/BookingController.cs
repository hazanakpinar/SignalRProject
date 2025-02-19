using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Business.Abstract;
using SignalR.Dto.Booking_Dto;
using SignalR.Entities.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
    
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Date = createBookingDto.Date,
                Mail = createBookingDto.Mail,
                Name = createBookingDto.Name,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone
            };
            _bookingService.TAdd(booking);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok("Silindi");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {

            Booking booking = new Booking()
            {
                Id = updateBookingDto.Id,   
                 Date = updateBookingDto.Date,
                  Mail = updateBookingDto.Mail,
                   Name = updateBookingDto.Name,
                    PersonCount = updateBookingDto.PersonCount,
                     Phone  = updateBookingDto.Phone
            };
            _bookingService.TUpdate(booking);
            return Ok("Güncellendi");
        }
        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }
    }
}
