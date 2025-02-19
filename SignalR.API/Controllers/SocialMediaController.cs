using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Business.Abstract;
using SignalR.Dto.SocialMedia_Dto;
using SignalR.Entities.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(IMapper mapper, ISocialMediaService SocialMediaService)
        {
            _mapper = mapper;
            _socialMediaService = SocialMediaService;
        }
        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
                 Title= createSocialMediaDto.Title,
                 Url=createSocialMediaDto.Url,
                  Icon = createSocialMediaDto.Icon,
            });
            return Ok("Sosyal Medya Bilgisi Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("Sosyal Medya Bilgisi Silindi");
        }
        [HttpGet]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
                Id = updateSocialMediaDto.Id,
                Title = updateSocialMediaDto.Title,
                Url = updateSocialMediaDto.Url,
                Icon = updateSocialMediaDto.Icon
            });
            return Ok("Sosyal Medya Bilgisi Güncellendi");
        }
    }
}
