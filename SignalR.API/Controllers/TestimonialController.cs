using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Business.Abstract;
using SignalR.Dto.Testimonial_Dto;
using SignalR.Entities.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(IMapper mapper, ITestimonialService TestimonialService)
        {
            _mapper = mapper;
            _testimonialService = TestimonialService;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Title = createTestimonialDto.Title,
                Comment = createTestimonialDto.Comment,
                Image = createTestimonialDto.Image,
                Name = createTestimonialDto.Name,
                Status = createTestimonialDto.Status
            });
            return Ok("Müşteri Yorum Bilgisi Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Müşteri Yorum Bilgisi Silindi");
        }
        [HttpGet]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                Id = updateTestimonialDto.Id,
                Title = updateTestimonialDto.Title,
                Comment = updateTestimonialDto.Comment,
                Image = updateTestimonialDto.Image,
                Name = updateTestimonialDto.Name,
                Status = updateTestimonialDto.Status
            });
            return Ok("Müşteri Yorum Bilgisi Güncellendi");
        }
    }
}
