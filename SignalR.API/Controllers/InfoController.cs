using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Business.Abstract;
using SignalR.Dto.Info_Dto;
using SignalR.Entities.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IInfoService _infoService;

        public InfoController(IMapper mapper, IInfoService InfoService)
        {
            _mapper = mapper;
            _infoService = InfoService;
        }
        [HttpGet]
        public IActionResult InfoList()
        {
            var value = _mapper.Map<List<ResultInfoDto>>(_infoService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateInfo(CreateInfoDto createInfoDto)
        {
            _infoService.TAdd(new Info()
            {
                Location = createInfoDto.Location,
                Description = createInfoDto.Description,
                Mail = createInfoDto.Mail,
                Phone = createInfoDto.Phone
            });
            return Ok("İletişim Bilgisi Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteInfo(int id)
        {
            var value = _infoService.TGetByID(id);
            _infoService.TDelete(value);
            return Ok("İletişim Bilgisi Silindi");
        }
        [HttpGet("GetInfo")]
        public IActionResult GetInfo(int id)
        {
            var value = _infoService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateInfo(UpdateInfoDto updateInfoDto)
        {
            _infoService.TUpdate(new Info()
            {
                Id = updateInfoDto.Id,
                Location = updateInfoDto.Location,
                Description = updateInfoDto.Description,
                Mail = updateInfoDto.Mail,
                Phone = updateInfoDto.Phone
            });
            return Ok("İletişim Bilgisi Güncellendi");
        }
    }
}
