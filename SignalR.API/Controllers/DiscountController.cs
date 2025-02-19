using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Business.Abstract;
using SignalR.Dto.Discount_Dto;
using SignalR.Entities.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDiscountService _discountService;

        public DiscountController(IMapper mapper, IDiscountService DiscountService)
        {
            _mapper = mapper;
            _discountService = DiscountService;
        }
        [HttpGet]
        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                Title = createDiscountDto.Title,
                Image = createDiscountDto.Image,
                Description = createDiscountDto.Description,
                Amount = createDiscountDto.Amount
            });
            return Ok("İndirim Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("İndirim Silindi");
        }
        [HttpGet]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                Id = updateDiscountDto.Id,
                Title = updateDiscountDto.Title,
                Image = updateDiscountDto.Image,
                Description = updateDiscountDto.Description,
                Amount = updateDiscountDto.Amount
            });
            return Ok("İndirim Güncellendi");
        }
    }
}
