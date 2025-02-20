using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Business.Abstract;
using SignalR.Dto.About_Dto;
using SignalR.Entities.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                Image = createAboutDto.Image
            };
            _aboutService.TAdd(about);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id) 
        {
            var value = _aboutService.TGetByID (id);
            return Ok("Silindi");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                Id = updateAboutDto.Id,
                Title = updateAboutDto.Title,
                Description = updateAboutDto.Description,
                Image = updateAboutDto.Image
            };
            _aboutService.TUpdate (about);
            return Ok("Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetByID (id);
            return Ok(value);
        }
    }
}
